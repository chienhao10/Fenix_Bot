using LoLLauncher;
using Fenix_Bot.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Fenix_Bot
{
    public partial class FormMain : Form
    {
        public static DataTable dt = new DataTable();
        public static string Path2;
        public static string Region;
        public static int connectedAccs = 0;
        public static int curRunning = 0;
        public static string cversion;
        private static bool closeFlag = false;
        private static bool startFlag = false;
        public static bool AutoUpdate = true;
        private static Dictionary<string, Bot> dictBot = new Dictionary<string, Bot>();

        public FormMain()
        {

            InitializeComponent();
            this.Load += FormMain_Load;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Fenix Bot - Version {0}", version);

            

            InitEvent();
            InitDefault();
            InitChecks();
            LoadConfiguration();

            lolversion.Text = "League of Legends - " + cversion;

            chkLaucnher();

            LoadAccounts();

            //cboDelay.SelectedIndex = 0;
           
        }

        #region Funções

        private void chkLaucnher()
        {

            if(!File.Exists(Path2 + "lol.launcher.exe"))
            {

                MethodInvoker action = () => this.Visible = false;
                this.BeginInvoke(action);

                Thread myth = new Thread(new System.Threading.ThreadStart(ChooseFile));
                myth.ApartmentState = ApartmentState.STA;
                myth.Start();

                

            }

            if (closeFlag)
            {
                Application.Exit();
                return;
            }

        }

        

        private void ChooseFile()
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select League of Legends folder";

            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                Path2 = fbd.SelectedPath+"\\";

                if (!File.Exists(Path2 + "lol.launcher.exe"))
                {

                    Thread myth2 = new Thread(new System.Threading.ThreadStart(MensagemErro));
                    myth2.ApartmentState = ApartmentState.STA;
                    myth2.Start();


                }
                else
                {
                    if (File.Exists(@"Config\settings.xml"))
                    {
                        File.Delete(@"Config\settings.xml");
                    }

                    string str = "<?xml version= \"1.0\" encoding=\"utf-8\"?>\n<config>\n  <version>5.10.15_05_22_10_52</version>\n  <launcherpath>" + Path2 + "</launcherpath>\n</config>";
                    StringBuilder builder = new StringBuilder();
                    builder.AppendLine(str);
                    using (StreamWriter writer = new StreamWriter(@"Config\settings.xml"))
                    {
                        writer.Write(builder.ToString());
                    }

                    

                }

                MethodInvoker action = () => this.Visible = true;
                this.BeginInvoke(action);
                
            }
            else
            {

                Application.Exit();
            }

        }

        private void MensagemErro()
        {

            MessageBox.Show("Wrong folder, Please select the folder that contains \"lol.launcher.exe\".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            chkLaucnher();
        }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }


        public void restaurarConfig()
        {

            string path = Path2 + @"Config\\game.cfg";

            FileInfo fileInfo = new FileInfo(path);


            if (fileInfo.Exists && File.Exists(Path2 + @"Config\\game_top.cfg"))
            {
                FileSecurity fileSecurity = File.GetAccessControl(path);
                fileSecurity.AddAccessRule(new FileSystemAccessRule(System.Security.Principal.WindowsIdentity.GetCurrent().Name, FileSystemRights.Delete, AccessControlType.Allow));
                File.SetAccessControl(path, fileSecurity);

                fileInfo.IsReadOnly = false;
                fileInfo.Delete();

                File.Move(Path2 + @"Config\\game_top.cfg", Path2 + @"Config\\game.cfg");

            }



        }

        private void InitEvent()
        {
            

            startBtn.Click += delegate(object sender, EventArgs e) 
            {
                if (chkReplaceCfg.Checked)
                {
                    Gamecfg();
                }


                foreach (DataRow dr in dt.Rows)
                {
                    ConnectAccount(dr);
                    
                    Thread.Sleep(0 * 1000);
                }

                startFlag = true;
                startBtn.Enabled = false;
                stopBtn.Enabled = true;
            };
            stopBtn.Click += delegate(object sender, EventArgs e) 
            {
                DisConnectAccount(null);
                startFlag = false;
                stopBtn.Enabled = false;
                startBtn.Enabled = true;
                restaurarConfig();

            };

            //Draw button
            Connect.Click += delegate(object sender, EventArgs e)
            {
                if (chkReplaceCfg.Checked)
                {
                    Gamecfg();
                }

                DataGridViewSelectedRowCollection drsc = dataGridView1.SelectedRows;

                if (drsc.Count > 0)
                {
                    DataGridViewRow dvr = drsc[0];
                    DataRow dr = ((DataRowView)dvr.DataBoundItem).Row;
                    ConnectAccount(dr);
                }

                
            };
            Disconnect.Click += delegate(object sender, EventArgs e)
            {
                DataGridViewSelectedRowCollection drsc = dataGridView1.SelectedRows;

                if (drsc.Count > 0)
                {
                    DataGridViewRow dvr = drsc[0];

                    DataGridViewCellCollection dvc = dvr.Cells;

                    if (dictBot.ContainsKey(dvc[1].Value.ToString()))
                    {
                        DisConnectAccount(dvc);
                    }
                }
            };

            addAccountsBtn.Click += addAccountsBtn_Click;
            removeAccountsBtn.Click += removeAccountsBtn_Click;

        }


        private void InitDefault()
        {
            QueueTypeInput.SelectedIndex = 0;
            SelectChampionInput.SelectedIndex = 6;
            Spell1Input.SelectedIndex = 5;
            Spell2Input.SelectedIndex = 8;
            RegionInput.SelectedIndex = 7;

       
            dt.Columns.Add("Region");
            dt.Columns.Add("ID");
            dt.Columns.Add("Reconnect");
            dt.Columns.Add("Password");
            dt.Columns.Add("Summoner");
            dt.Columns.Add("Queue Type");
            dt.Columns.Add("Champion");
            dt.Columns.Add("Spell1");
            dt.Columns.Add("Spell2");
            dt.Columns.Add("Max Level");
            dt.Columns.Add("Level");
            dt.Columns.Add("XP");
            dt.Columns.Add("IP (Get IP)");
            dt.Columns.Add("Status");

            dataGridView1.DataSource = dt;


            foreach (DataGridViewColumn columns in dataGridView1.Columns)
            {
                switch (columns.Name)
                {
                    case "Region":
                        //columns.Visible = false;
                        columns.Width = 50;
                        break;
                    case "ID":
                        columns.Width = 70;
                        break;
                    case "Reconnect":
                        //columns.Width = 100;
                        columns.Visible = false;
                        break;
                    case "Password":
                        //columns.Width = 100;
                        columns.Visible = false;
                        break;
                    case "Summoner":
                        columns.Width = 85;
                        break;
                    case "Queue Type":
                        columns.Width = 120;
                        break;
                    case "Champion":
                        columns.Width = 80;
                        break;
                    case "Spell1":
                        columns.Width = 70;
                        break;
                    case "Spell2":
                        columns.Width = 70;
                        break;
                    case "Max Level":
                        columns.Width = 50;
                        columns.Visible = false;
                        break;
                    case "Level":
                        columns.Width = 50;
                        
                        break;
                    case "XP":
                        columns.Width = 100;
                        //columns.Visible = false;
                        break;
                    case "IP (Get IP)":
                        columns.Width = 90;
                        break;
                    case "Status":
                        columns.Width = 180;
                        break;
                }
            }
            dataGridView1.MultiSelect = false;
        }

        private static void InitChecks()
        {
            var theFolder = AppDomain.CurrentDomain.BaseDirectory + @"config\\";
            var accountsTxtLocation = AppDomain.CurrentDomain.BaseDirectory + @"config\\accounts.txt";
            var configTxtLocation = AppDomain.CurrentDomain.BaseDirectory + @"config\\settings.xml";

            if (!Directory.Exists(theFolder))
            {
                Directory.CreateDirectory(theFolder);
            }

            if (!File.Exists(configTxtLocation))
            {
                try
                {
                    string path = Path2 + @"Config\\settings.xml";
                    FileInfo fileInfo = new FileInfo(path);
                    fileInfo.Refresh();
                    string str = "<?xml version= \"1.0\" encoding=\"utf-8\"?>\n<config>\n  <version>5.10.15_05_22_10_52</version>\n  <launcherpath>C:\\Riot Games\\League of Legends\\</launcherpath>\n</config>";
                    StringBuilder builder = new StringBuilder();
                    builder.AppendLine(str);
                    using (StreamWriter writer = new StreamWriter(Path2 + @"Config\settings.xml"))
                    {
                        writer.Write(builder.ToString());
                    }
                    fileInfo.Refresh();
                    
                }
                catch (Exception exception2)
                {
                    Console.WriteLine("Fail create settings.xml.\nException:" + exception2.Message);
                }

            }
            if (!File.Exists(accountsTxtLocation))
            {
                try
                {

                    string path = Path2 + @"Config\\accounts.txt";
                    TextWriter tw = new StreamWriter(path, true);
                    tw.Close();
                    
                    
                }
                catch (Exception exception2)
                {
                    Console.WriteLine("Fail create accounts.txt.\nException:" + exception2.Message);
                }
            }

        }

        

        public void LoadAccounts()
        {
            var accountsTxtPath = AppDomain.CurrentDomain.BaseDirectory + "config\\accounts.txt";
            TextReader tr = File.OpenText(accountsTxtPath);
            string line;
            while ((line = tr.ReadLine()) != null)
            {
                DataRow dr = dt.NewRow();

                string[] acc = line.Split('|');
                if (acc.Length == 8)
                {
                    dr["Region"] = acc[0];
                    dr["ID"] = acc[1];
                    dr["Reconnect"] = "OFF";
                    dr["Password"] = acc[2];
                    dr["Queue Type"] = acc[3];
                    dr["Champion"] = acc[4];
                    dr["Spell1"] = acc[5];
                    dr["Spell2"] = acc[6];
                    dr["Max Level"] = acc[7];
                    dr["Level"] = "";
                    dr["XP"] = "";
                    dr["IP (Get IP)"] = "";
                    dr["Status"] = "Ready";

                    dt.Rows.Add(dr);
                }
            }
            tr.Close();
        }

        public static void LoadConfiguration()
        {
            try
            {
                XmlUtil xml = new XmlUtil(AppDomain.CurrentDomain.BaseDirectory + "config\\settings.xml");
                Path2 = xml.GetNodeValue("/config/launcherpath");
                cversion = xml.GetNodeValue("/config/version") == "0" ? cversion : xml.GetNodeValue("/config/version");

           
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(10000);
                Application.Exit();
            }
        }

        public static void Gamecfg()
        {

               

                string path = Path2 + @"Config\\game.cfg";

                if (File.Exists(path) && !File.Exists(Path2 + @"Config\\game_top.cfg"))
                {
                    File.Move(Path2 + @"Config\\game.cfg", Path2 + @"Config\\game_top.cfg");
                }

                if (!File.Exists(path))
                {
                    FileInfo fileInfo = new FileInfo(path);
                    //fileInfo.IsReadOnly = true;
                    fileInfo.Refresh();
                    string str = "[General]\nGameMouseSpeed=9\nEnableAudio=0\nUserSetResolution=1\nBindSysKeys=0\nSnapCameraOnRespawn=1\nOSXMouseAcceleration=1\nAutoAcquireTarget=0\nEnableLightFx=0\nWindowMode=1\nShowTurretRangeIndicators=0\nPredictMovement=0\nWaitForVerticalSync=0\nColors=16\nHeight=200\nWidth=300\nSystemMouseSpeed=0\nCfgVersion=4.13.265\n\n[HUD]\nShowNeutralCamps=0\nDrawHealthBars=0\nAutoDisplayTarget=0\nMinimapMoveSelf=0\nItemShopPrevY=19\nItemShopPrevX=117\nShowAllChannelChat=1\nShowTimestamps=0\nObjectTooltips=0\nFlashScreenWhenDamaged=0\nNameTagDisplay=1\nShowChampionIndicator=0\nShowSummonerNames=0\nScrollSmoothingEnabled=0\nMiddleMouseScrollSpeed=0.5000\nMapScrollSpeed=0.5000\nShowAttackRadius=0\nNumericCooldownFormat=3\nSmartCastOnKeyRelease=0\nEnableLineMissileVis=0\nFlipMiniMap=0\nItemShopResizeHeight=47\nItemShopResizeWidth=455\nItemShopPrevResizeHeight=200\nItemShopPrevResizeWidth=300\nItemShopItemDisplayMode=1\nItemShopStartPane=1\n\n[Performance]\nShadowsEnabled=0\nEnableHUDAnimations=0\nPerPixelPointLighting=0\nEnableParticleOptimizations=0\nBudgetOverdrawAverage=10\nBudgetSkinnedVertexCount=10\nBudgetSkinnedDrawCallCount=10\nBudgetTextureUsage=10\nBudgetVertexCount=10\nBudgetTriangleCount=10\nBudgetDrawCallCount=1000\nEnableGrassSwaying=0\nEnableFXAA=0\nAdvancedShader=0\nFrameCapType=3\nGammaEnabled=1\nFull3DModeEnabled=0\nAutoPerformanceSettings=0\n=0\nEnvironmentQuality=0\nEffectsQuality=0\nShadowQuality=0\nGraphicsSlider=0\n\n[Volume]\nMasterVolume=1\nMusicMute=0\n\n[LossOfControl]\nShowSlows=0\n\n[ColorPalette]\nColorPalette=0\n\n[FloatingText]\nCountdown_Enabled=0\nEnemyTrueDamage_Enabled=0\nEnemyMagicalDamage_Enabled=0\nEnemyPhysicalDamage_Enabled=0\nTrueDamage_Enabled=0\nMagicalDamage_Enabled=0\nPhysicalDamage_Enabled=0\nScore_Enabled=0\nDisable_Enabled=0\nLevel_Enabled=0\nGold_Enabled=0\nDodge_Enabled=0\nHeal_Enabled=0\nSpecial_Enabled=0\nInvulnerable_Enabled=0\nDebug_Enabled=1\nAbsorbed_Enabled=1\nOMW_Enabled=1\nEnemyCritical_Enabled=0\nQuestComplete_Enabled=0\nQuestReceived_Enabled=0\nMagicCritical_Enabled=0\nCritical_Enabled=1\n\n[Replay]\nEnableHelpTip=0";
                    StringBuilder builder = new StringBuilder();
                    builder.AppendLine(str);
                    using (StreamWriter writer = new StreamWriter(Path2 + @"Config\game.cfg"))
                    {
                        writer.Write(builder.ToString());
                    }
                    fileInfo.Attributes &= ~FileAttributes.Hidden;
                    fileInfo.IsReadOnly = true;
                    
                    fileInfo.Refresh();
                }

                

        }

      

        private void Clean()
        {

            newUserNameInput.Text = "";
            newPasswordInput.Text = "";
            QueueTypeInput.SelectedIndex = 0;
            SelectChampionInput.SelectedIndex = 6;
            Spell1Input.SelectedIndex = 5;
            Spell2Input.SelectedIndex = 8;
            RegionInput.SelectedIndex = 7;

        }

        #endregion

        #region Conexão

        public static void ConnectAccount(DataRow dr)
        {
            if (dr != null)
            {
                dr["Reconnect"] = "ON";

                
   
                    curRunning += 1;
                    Bot bot;
                    if (!dr["Queue Type"].ToString().Equals(""))
                    {
                        QueueTypes queuetype = (QueueTypes)System.Enum.Parse(typeof(QueueTypes), dr["Queue Type"].ToString());
                        bot = new Bot(dr["ID"].ToString(), dr["Password"].ToString(), dr["Region"].ToString(), Path2, curRunning, queuetype);

                        FormMain.UpdateStatus("Connecting", dr["ID"].ToString(), "Status");
                    }
                    else
                    {
                        QueueTypes queuetype = QueueTypes.ARAM;
                        bot = new Bot(dr["ID"].ToString(), dr["Password"].ToString(), dr["Region"].ToString(), Path2, curRunning, queuetype);
                        FormMain.UpdateStatus("Connecting", dr["ID"].ToString(), "Status");
                    }

                    if (dictBot.ContainsKey(dr["ID"].ToString()))
                        dictBot[dr["ID"].ToString()] = bot;
                    else
                        dictBot.Add(dr["ID"].ToString(), bot);
                
                
                
            }
        }


        public static void DisConnectAccount(DataGridViewCellCollection row)
        {
            try
            {
                if (row != null)
                {
                    if (dictBot.ContainsKey(row[1].Value.ToString()))
                    {
                        dictBot[row[1].Value.ToString()].connection.Disconnect();

                        foreach (DataRow rows in dt.Rows)
                        {
                            if (rows["ID"].ToString().Equals(row[1].Value.ToString()))
                            {
                                rows["Reconnect"] = "OFF";
                            }
                    
                        }

                        Process.GetCurrentProcess().Threads[dictBot[row[1].Value.ToString()].threadID].Dispose();
                        dictBot.Remove(row[1].Value.ToString());
                    }
                }
                else
                {

                    foreach (DataRow rows in dt.Rows)
                    {
                       
                            rows["Reconnect"] = "OFF";
                     

                    }

                    try
                    {
                        foreach (Bot bot in dictBot.Values)
                        {

                            bot.connection.Disconnect();
                            if (bot.connection.heartbeatThread.IsAlive)
                                bot.connection.heartbeatThread.Abort();



                            Process.GetCurrentProcess().Threads[bot.threadID].Dispose();
                        }
                    }
                    catch (Exception)
                    {


                    }



                    dictBot.Clear();
                }
            }
            catch (Exception)
            {
                

            }
            
        }


        public static String GetTimestamp()
        {
            return "[" + DateTime.Now.ToString("HH:mm:ss") + "] ";
        }

        public static string GetChampion(string accName)
        {
            DataRow[] tempRow = dt.Select("ID = '" + accName + "'");
            return tempRow[0]["Champion"].ToString();
        }
        
        public static int GetMaxLevel(string accName)
        {
            DataRow[] tempRow = dt.Select("ID = '" + accName + "'");
            return Convert.ToInt16(tempRow[0]["Max Level"].ToString());
        }

        public static string GetSpells(string accName, string spellNumber)
        {
            DataRow[] tempRow = dt.Select("ID = '" + accName + "'");
            return tempRow[0]["Spell" + spellNumber].ToString();
        }

        public static int ExpNeed(string accName, int Level)
        {
            
            int exp = 0;

            switch (Level)
            {
                case 1:
                    exp = 90;
                    break;
                case 2:
                    exp = 98;
                    break;
                case 3:
                    exp = 105;
                    break;
                case 4:
                    exp = 113;
                    break;
                case 5:
                    exp = 448;
                    break;
                case 6:
                    exp = 476;
                    break;
                case 7:
                    exp = 504;
                    break;
                case 8:
                    exp = 532;
                    break;
                case 9:
                    exp = 560;
                    break;
                case 10:
                    exp = 1050;
                    break;
                case 11:
                    exp = 1100;
                    break;
                case 12:
                    exp = 1150;
                    break;
                case 13:
                    exp = 1200;
                    break;
                case 14:
                    exp = 1250;
                    break;
                case 15:
                    exp = 1300;
                    break;
                case 16:
                    exp = 1350;
                    break;
                case 17:
                    exp = 1400;
                    break;
                case 18:
                    exp = 1450;
                    break;
                case 19:
                    exp = 1500;
                    break;
                case 20:
                    exp = 2131;
                    break;
                case 21:
                    exp = 2200;
                    break;
                case 22:
                    exp = 2269;
                    break;
                case 23:
                    exp = 2338;
                    break;
                case 24:
                    exp = 2406;
                    break;
                case 25:
                    exp = 2475;
                    break;
                case 26:
                    exp = 2544;
                    break;
                case 27:
                    exp = 2613;
                    break;
                case 28:
                    exp = 2681;
                    break;
                case 29:
                    exp = 2750;
                    break;
                case 30:
                    exp = 0;
                    break;

            }

            return exp;
            
        }



        public static void UpdateStatus(string message, string accname, string columnName)
        {
            try
            {
                foreach (DataRow rows in dt.Rows)
                {
                    if (rows["ID"].ToString().Equals(accname))
                    {

                        if (columnName != "Status")
                        {
                            if (columnName == "IP (Get IP)")
                            {
                                Regex reg = new Regex("[0-9]+");

                                int getIP = rows[columnName].ToString() != "" ? Convert.ToInt32(message) - Convert.ToInt32(reg.Match(rows[columnName].ToString()).Value) : 0;
                                try
                                {
                                    string IpAntigo = rows["IP (Get IP)"].ToString();

                                    string[] parts = IpAntigo.Split('(', ' ', '+', ')');

                                    int IPGanho = Convert.ToInt32(parts[3].ToString()) + getIP;

                                    rows[columnName] = message + " (+" + IPGanho + ")";
                                }
                                catch (Exception)
                                {
                                    rows[columnName] = message + " (+0)";
                                }

                            }
                            else if (columnName == "XP")
                            {
                                int getLv = Convert.ToInt32(rows["Level"].ToString());
                                string lv = "0";
                                if (!message.Equals("")) lv = message;

                                rows[columnName] = " (" + lv + " / " + ExpNeed(accname, getLv) + ")";

                            }
                            else
                                rows[columnName] = message;
                        
                         
                        }
                        else if (message.Contains("Fenix bot updated"))
                        {
                            if (MessageBox.Show("Fenix bot updated for version \"" + cversion + "\". Please restart.") == DialogResult.OK)
                            {

                                Process[] myBot = Process.GetProcessesByName("Fenix_Bot");

                                if (myBot.Length > 0)
                                {
                                    for (int i = 0; i < myBot.Length; i++)
                                    {
                                        myBot[i].Kill();
                                    }
                                }


                                Application.Exit();
                            }
                            else
                            {

                                Process[] myBot = Process.GetProcessesByName("Fenix_Bot");

                                if (myBot.Length > 0)
                                {
                                    for (int i = 0; i < myBot.Length; i++)
                                    {
                                        myBot[i].Kill();
                                    }
                                }


                                Application.Exit();
                            }
                        }
                        else
                        {
                            if (message.Length > 40 || message.Contains("Disconnected") && rows["Reconnect"].ToString() == "ON" && !message.Contains("Please log in to answer the notice Leave Busted!"))
                            {

                                FormMain.UpdateStatus("Reconnecting...", rows["ID"].ToString(), "Status");
                                Thread.Sleep(10 * 1000);

                                curRunning += 1;
                                Bot bot;
                                if (!rows["Queue Type"].ToString().Equals(""))
                                {
                                    QueueTypes queuetype = (QueueTypes)System.Enum.Parse(typeof(QueueTypes), rows["Queue Type"].ToString());
                                    bot = new Bot(rows["ID"].ToString(), rows["Password"].ToString(), rows["Region"].ToString(), Path2, curRunning, queuetype);

                                    
                                }
                                else
                                {
                                    QueueTypes queuetype = QueueTypes.ARAM;
                                    bot = new Bot(rows["ID"].ToString(), rows["Password"].ToString(), rows["Region"].ToString(), Path2, curRunning, queuetype);

                                }

                                if (dictBot.ContainsKey(rows["ID"].ToString()))
                                    dictBot[rows["ID"].ToString()] = bot;
                                else
                                    dictBot.Add(rows["ID"].ToString(), bot);
                            }
                            else
                            {
                                rows[columnName] = GetTimestamp() + message;
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            
        }        
        #endregion

        #region Contas

        private void addAccountsBtn_Click(object sender, EventArgs e)
        {
            if (newUserNameInput.Text.Length == 0)
            { MessageBox.Show("Please input to ID."); return; }


            if (newPasswordInput.Text.Length == 0)
            { MessageBox.Show("Please input to Password."); return; }


            foreach (DataRow rows in dt.Rows)
            {
                if (newUserNameInput.Text.Equals(rows["ID"].ToString()))
                { MessageBox.Show("Has already been added."); return; }
            }

            DataRow dr = dt.NewRow();
            dr["Region"] = RegionInput.Text;
            dr["ID"] = newUserNameInput.Text;
            dr["Password"] = Encrypt(newPasswordInput.Text);           
            dr["Queue Type"] = QueueTypeInput.Text;
            dr["Champion"] = SelectChampionInput.Text;
            dr["Spell1"] = Spell1Input.Text;
            dr["Spell2"] = Spell2Input.Text;
            dr["Max Level"] = MaxLevelInput.Text;
            dr["Status"] = "Ready";
            dt.Rows.Add(dr);

            FileHandlers.Account("ADD", dr[0].ToString(), dr[1].ToString(), dr[3].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());


            if (startFlag)
                ConnectAccount(dr);
            Clean();
        }

        private void removeAccountsBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection drsc = dataGridView1.SelectedRows;

            if (drsc.Count > 0)
            {
                DataGridViewRow dvr = drsc[0];

                DataGridViewCellCollection dvc = dvr.Cells;

                if (dictBot.ContainsKey(dvc[1].Value.ToString()))
                {
                    DialogResult result = MessageBox.Show("If Remove the Row, Disconnect is as well. \nDo you want to continue?", "Disconnect", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                        DisConnectAccount(dvc);
                    else
                        return;
                }

                    FileHandlers.Account("REMOVE", (string)dvc[0].Value, (string)dvc[1].Value, (string)dvc[3].Value, (string)dvc[5].Value, (string)dvc[6].Value, (string)dvc[7].Value, (string)dvc[8].Value, (string)dvc[9].Value);

                
                dataGridView1.Rows.Remove(dvr);
            }

        }




        #endregion

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            restaurarConfig();

            Process[] myBot = Process.GetProcessesByName("Fenix_Bot");

            if (myBot.Length > 0)
            {
                for (int i = 0; i < myBot.Length; i++)
                {
                    myBot[i].Kill();
                }
            }


            Application.Exit();
        }












    }
}

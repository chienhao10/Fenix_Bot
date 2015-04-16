namespace Fenix_Bot
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lolversion = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SelectChampionInput = new System.Windows.Forms.ComboBox();
            this.selectChampionLabel = new System.Windows.Forms.Label();
            this.QueueTypeInput = new System.Windows.Forms.ComboBox();
            this.QueueTypeLabel = new System.Windows.Forms.Label();
            this.newPasswordInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.newUserNameInput = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.MaxLevelInput = new System.Windows.Forms.TextBox();
            this.maxLevelLabel = new System.Windows.Forms.Label();
            this.Spell2Input = new System.Windows.Forms.ComboBox();
            this.spell2Label = new System.Windows.Forms.Label();
            this.Spell1Input = new System.Windows.Forms.ComboBox();
            this.spell1Label = new System.Windows.Forms.Label();
            this.RegionInput = new System.Windows.Forms.ComboBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkReplaceCfg = new System.Windows.Forms.CheckBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.removeAccountsBtn = new System.Windows.Forms.Button();
            this.addAccountsBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.accountsLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connect,
            this.Disconnect});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 48);
            // 
            // Connect
            // 
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(193, 22);
            this.Connect.Text = "Select Row Connect";
            // 
            // Disconnect
            // 
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(193, 22);
            this.Disconnect.Text = "Select Row Disconnect";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(920, 258);
            this.dataGridView1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(6, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 255);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lolversion);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 44);
            this.panel3.TabIndex = 10;
            // 
            // lolversion
            // 
            this.lolversion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lolversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lolversion.ForeColor = System.Drawing.Color.Black;
            this.lolversion.Location = new System.Drawing.Point(0, 0);
            this.lolversion.Name = "lolversion";
            this.lolversion.Size = new System.Drawing.Size(915, 42);
            this.lolversion.TabIndex = 5;
            this.lolversion.Text = "Version";
            this.lolversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SelectChampionInput);
            this.splitContainer1.Panel1.Controls.Add(this.selectChampionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.QueueTypeInput);
            this.splitContainer1.Panel1.Controls.Add(this.QueueTypeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.newPasswordInput);
            this.splitContainer1.Panel1.Controls.Add(this.passwordLabel);
            this.splitContainer1.Panel1.Controls.Add(this.newUserNameInput);
            this.splitContainer1.Panel1.Controls.Add(this.userNameLabel);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MaxLevelInput);
            this.splitContainer1.Panel2.Controls.Add(this.maxLevelLabel);
            this.splitContainer1.Panel2.Controls.Add(this.Spell2Input);
            this.splitContainer1.Panel2.Controls.Add(this.spell2Label);
            this.splitContainer1.Panel2.Controls.Add(this.Spell1Input);
            this.splitContainer1.Panel2.Controls.Add(this.spell1Label);
            this.splitContainer1.Panel2.Controls.Add(this.RegionInput);
            this.splitContainer1.Panel2.Controls.Add(this.regionLabel);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Size = new System.Drawing.Size(917, 153);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.SplitterWidth = 9;
            this.splitContainer1.TabIndex = 15;
            // 
            // SelectChampionInput
            // 
            this.SelectChampionInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectChampionInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectChampionInput.FormattingEnabled = true;
            this.SelectChampionInput.Items.AddRange(new object[] {
            "AATROX",
            "AHRI",
            "AKALI",
            "ALISTAR",
            "AMUMU",
            "ANIVIA",
            "ANNIE",
            "ASHE",
            "AZIR",
            "BLITZCRANK",
            "BRAND",
            "BRAUM",
            "CAITLYN",
            "CASSIOPEIA",
            "CHOGATH",
            "CORKI",
            "DARIUS",
            "DIANA",
            "MUNDO",
            "DRAVEN",
            "ELISE",
            "EVELYNN",
            "EZREAL",
            "FIDDLESTICKS",
            "FIORA",
            "FIZZ",
            "GALIO",
            "GANGPLANK",
            "GAREN",
            "GNAR",
            "GRAGAS",
            "GRAVES",
            "HECARIM",
            "HEIMERDIGER",
            "IRELIA",
            "JANNA",
            "JARVAN",
            "JAX",
            "JAYCE",
            "JINX",
            "KALISTA",
            "KARMA",
            "KARTHUS",
            "KASSADIN",
            "KATARINA",
            "KAYLE",
            "KENNEN",
            "KHAZIX",
            "KOGMAW",
            "LEBLANC",
            "LEESIN",
            "LEONA",
            "LISSANDRA",
            "LUCIAN",
            "LULU",
            "LUX",
            "MALPHITE",
            "MALZAHAR",
            "MAOKAI",
            "MASTERYI",
            "MISSFORTUNE",
            "MORDEKAISER",
            "MORGANA",
            "NAMI",
            "NASUS",
            "NAUTILUS",
            "NIDALEE",
            "NOCTURNE",
            "NUNU",
            "OLAF",
            "ORIANNA",
            "PANTHEON",
            "POPPY",
            "QUINN",
            "REKSAI",
            "RAMMUS",
            "RENEKTON",
            "RENGAR",
            "RIVEN",
            "RUMBLE",
            "RYZE",
            "SEJUANI",
            "SHACO",
            "SHEN",
            "SHYVANA",
            "SINGED",
            "SION",
            "SIVIR",
            "SKARNER",
            "SONA",
            "SORAKA",
            "SWAIN",
            "SYNDRA",
            "TALON",
            "TARIC",
            "TEEMO",
            "THRESH",
            "TRISTANA",
            "TRUNDLE",
            "TRYNDAMERE",
            "TWISTEDFATE",
            "TWITCH",
            "UDYR",
            "URGOT",
            "VARUS",
            "VAYNE",
            "VEIGAR",
            "VELKOZ",
            "VI",
            "VIKTOR",
            "VLADIMIR",
            "VOLIBEAR",
            "WARWICK",
            "WUKONG",
            "XERATH",
            "XINZHAO",
            "YASUO",
            "YORICK",
            "ZAC",
            "ZED",
            "ZIGGS",
            "ZILEAN",
            "ZYRA"});
            this.SelectChampionInput.Location = new System.Drawing.Point(4, 118);
            this.SelectChampionInput.Name = "SelectChampionInput";
            this.SelectChampionInput.Size = new System.Drawing.Size(452, 21);
            this.SelectChampionInput.TabIndex = 17;
            // 
            // selectChampionLabel
            // 
            this.selectChampionLabel.AutoSize = true;
            this.selectChampionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectChampionLabel.Location = new System.Drawing.Point(4, 105);
            this.selectChampionLabel.Name = "selectChampionLabel";
            this.selectChampionLabel.Size = new System.Drawing.Size(87, 13);
            this.selectChampionLabel.TabIndex = 16;
            this.selectChampionLabel.Text = "Select Champion";
            // 
            // QueueTypeInput
            // 
            this.QueueTypeInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.QueueTypeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QueueTypeInput.FormattingEnabled = true;
            this.QueueTypeInput.Items.AddRange(new object[] {
            "NORMAL_5x5",
            "NORMAL_3x3",
            "URF_5x5",
            "URF_BOT",
            "DOMINION_5x5",
            "DOMINION_BOT",
            "INTRO_BOT",
            "BEGINNER_BOT",
            "MEDIUM_BOT",
            "ARAM"});
            this.QueueTypeInput.Location = new System.Drawing.Point(4, 84);
            this.QueueTypeInput.Name = "QueueTypeInput";
            this.QueueTypeInput.Size = new System.Drawing.Size(452, 21);
            this.QueueTypeInput.TabIndex = 15;
            // 
            // QueueTypeLabel
            // 
            this.QueueTypeLabel.AutoSize = true;
            this.QueueTypeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QueueTypeLabel.Location = new System.Drawing.Point(4, 71);
            this.QueueTypeLabel.Name = "QueueTypeLabel";
            this.QueueTypeLabel.Size = new System.Drawing.Size(66, 13);
            this.QueueTypeLabel.TabIndex = 14;
            this.QueueTypeLabel.Text = "Queue Type";
            // 
            // newPasswordInput
            // 
            this.newPasswordInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.newPasswordInput.Location = new System.Drawing.Point(4, 51);
            this.newPasswordInput.Name = "newPasswordInput";
            this.newPasswordInput.PasswordChar = '*';
            this.newPasswordInput.Size = new System.Drawing.Size(452, 20);
            this.newPasswordInput.TabIndex = 12;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordLabel.Location = new System.Drawing.Point(4, 38);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password";
            // 
            // newUserNameInput
            // 
            this.newUserNameInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.newUserNameInput.Location = new System.Drawing.Point(4, 18);
            this.newUserNameInput.Name = "newUserNameInput";
            this.newUserNameInput.Size = new System.Drawing.Size(452, 20);
            this.newUserNameInput.TabIndex = 10;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userNameLabel.Location = new System.Drawing.Point(4, 5);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(18, 13);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "ID";
            // 
            // MaxLevelInput
            // 
            this.MaxLevelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxLevelInput.Location = new System.Drawing.Point(4, 120);
            this.MaxLevelInput.Name = "MaxLevelInput";
            this.MaxLevelInput.Size = new System.Drawing.Size(436, 20);
            this.MaxLevelInput.TabIndex = 29;
            this.MaxLevelInput.Text = "31";
            // 
            // maxLevelLabel
            // 
            this.maxLevelLabel.AutoSize = true;
            this.maxLevelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.maxLevelLabel.Location = new System.Drawing.Point(4, 107);
            this.maxLevelLabel.Name = "maxLevelLabel";
            this.maxLevelLabel.Size = new System.Drawing.Size(52, 13);
            this.maxLevelLabel.TabIndex = 28;
            this.maxLevelLabel.Text = "Max level";
            // 
            // Spell2Input
            // 
            this.Spell2Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.Spell2Input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Spell2Input.FormattingEnabled = true;
            this.Spell2Input.Items.AddRange(new object[] {
            "BARRIER",
            "CLAIRVOYANCE",
            "CLARITY",
            "CLEANSE",
            "EXHAUST",
            "FLASH",
            "GARRISON",
            "GHOST",
            "HEAL",
            "IGNITE",
            "REVIVE",
            "SMITE",
            "TELEPORT"});
            this.Spell2Input.Location = new System.Drawing.Point(4, 86);
            this.Spell2Input.Name = "Spell2Input";
            this.Spell2Input.Size = new System.Drawing.Size(436, 21);
            this.Spell2Input.TabIndex = 27;
            // 
            // spell2Label
            // 
            this.spell2Label.AutoSize = true;
            this.spell2Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.spell2Label.Location = new System.Drawing.Point(4, 73);
            this.spell2Label.Name = "spell2Label";
            this.spell2Label.Size = new System.Drawing.Size(36, 13);
            this.spell2Label.TabIndex = 26;
            this.spell2Label.Text = "Spell2";
            // 
            // Spell1Input
            // 
            this.Spell1Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.Spell1Input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Spell1Input.FormattingEnabled = true;
            this.Spell1Input.Items.AddRange(new object[] {
            "BARRIER",
            "CLAIRVOYANCE",
            "CLARITY",
            "CLEANSE",
            "EXHAUST",
            "FLASH",
            "GARRISON",
            "GHOST",
            "HEAL",
            "IGNITE",
            "REVIVE",
            "SMITE",
            "TELEPORT"});
            this.Spell1Input.Location = new System.Drawing.Point(4, 52);
            this.Spell1Input.Name = "Spell1Input";
            this.Spell1Input.Size = new System.Drawing.Size(436, 21);
            this.Spell1Input.TabIndex = 25;
            // 
            // spell1Label
            // 
            this.spell1Label.AutoSize = true;
            this.spell1Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.spell1Label.Location = new System.Drawing.Point(4, 39);
            this.spell1Label.Name = "spell1Label";
            this.spell1Label.Size = new System.Drawing.Size(36, 13);
            this.spell1Label.TabIndex = 24;
            this.spell1Label.Text = "Spell1";
            // 
            // RegionInput
            // 
            this.RegionInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegionInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionInput.FormattingEnabled = true;
            this.RegionInput.Items.AddRange(new object[] {
            "KR",
            "NA",
            "EUW",
            "EUNE",
            "OCE",
            "LAN",
            "LAS",
            "BR",
            "TR",
            "RU",
            "QQ"});
            this.RegionInput.Location = new System.Drawing.Point(4, 18);
            this.RegionInput.Name = "RegionInput";
            this.RegionInput.Size = new System.Drawing.Size(436, 21);
            this.RegionInput.TabIndex = 23;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.regionLabel.Location = new System.Drawing.Point(4, 5);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(41, 13);
            this.regionLabel.TabIndex = 22;
            this.regionLabel.Text = "Region";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkReplaceCfg);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.removeAccountsBtn);
            this.panel1.Controls.Add(this.addAccountsBtn);
            this.panel1.Location = new System.Drawing.Point(3, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 40);
            this.panel1.TabIndex = 22;
            // 
            // chkReplaceCfg
            // 
            this.chkReplaceCfg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReplaceCfg.AutoSize = true;
            this.chkReplaceCfg.Checked = true;
            this.chkReplaceCfg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReplaceCfg.Location = new System.Drawing.Point(655, 9);
            this.chkReplaceCfg.Name = "chkReplaceCfg";
            this.chkReplaceCfg.Size = new System.Drawing.Size(99, 17);
            this.chkReplaceCfg.TabIndex = 25;
            this.chkReplaceCfg.Text = "Replace Config";
            this.chkReplaceCfg.UseVisualStyleBackColor = true;
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(841, 5);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(64, 23);
            this.stopBtn.TabIndex = 24;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(772, 5);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(64, 23);
            this.startBtn.TabIndex = 23;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // removeAccountsBtn
            // 
            this.removeAccountsBtn.Location = new System.Drawing.Point(105, 7);
            this.removeAccountsBtn.Name = "removeAccountsBtn";
            this.removeAccountsBtn.Size = new System.Drawing.Size(92, 23);
            this.removeAccountsBtn.TabIndex = 22;
            this.removeAccountsBtn.Text = "Remove Acount";
            this.removeAccountsBtn.UseVisualStyleBackColor = true;
            // 
            // addAccountsBtn
            // 
            this.addAccountsBtn.Location = new System.Drawing.Point(8, 7);
            this.addAccountsBtn.Name = "addAccountsBtn";
            this.addAccountsBtn.Size = new System.Drawing.Size(92, 23);
            this.addAccountsBtn.TabIndex = 21;
            this.addAccountsBtn.Text = "Add Acount";
            this.addAccountsBtn.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.accountsLabel);
            this.panel4.Location = new System.Drawing.Point(6, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(920, 23);
            this.panel4.TabIndex = 9;
            // 
            // accountsLabel
            // 
            this.accountsLabel.AutoSize = true;
            this.accountsLabel.ForeColor = System.Drawing.Color.Black;
            this.accountsLabel.Location = new System.Drawing.Point(5, 4);
            this.accountsLabel.Name = "accountsLabel";
            this.accountsLabel.Size = new System.Drawing.Size(80, 13);
            this.accountsLabel.TabIndex = 5;
            this.accountsLabel.Text = "Account Status";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(935, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenix Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Connect;
        private System.Windows.Forms.ToolStripMenuItem Disconnect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox SelectChampionInput;
        private System.Windows.Forms.Label selectChampionLabel;
        private System.Windows.Forms.ComboBox QueueTypeInput;
        private System.Windows.Forms.Label QueueTypeLabel;
        private System.Windows.Forms.TextBox newPasswordInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox newUserNameInput;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox MaxLevelInput;
        private System.Windows.Forms.Label maxLevelLabel;
        private System.Windows.Forms.ComboBox Spell2Input;
        private System.Windows.Forms.Label spell2Label;
        private System.Windows.Forms.ComboBox Spell1Input;
        private System.Windows.Forms.Label spell1Label;
        private System.Windows.Forms.ComboBox RegionInput;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkReplaceCfg;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button removeAccountsBtn;
        private System.Windows.Forms.Button addAccountsBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label accountsLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lolversion;



    }
}
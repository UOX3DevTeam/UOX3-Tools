namespace UOX3_INI_Editor
{
	partial class INIEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INIEditor));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtINIFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.grpStartPrivs = new System.Windows.Forms.GroupBox();
            this.mtxtStartGold = new System.Windows.Forms.MaskedTextBox();
            this.lblStartGold = new System.Windows.Forms.Label();
            this.dataGridPrivs = new System.Windows.Forms.DataGridView();
            this.grpLocations = new System.Windows.Forms.GroupBox();
            this.dataGridLocations = new System.Windows.Forms.DataGridView();
            this.dgvLocationTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocationX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocationY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocationZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCombat = new System.Windows.Forms.TabPage();
            this.grpCombat = new System.Windows.Forms.GroupBox();
            this.chkPersecute = new System.Windows.Forms.CheckBox();
            this.chkDeathAnim = new System.Windows.Forms.CheckBox();
            this.grpCombatRange = new System.Windows.Forms.GroupBox();
            this.mtxtMagicRange = new System.Windows.Forms.MaskedTextBox();
            this.mtxtArcheryRange = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCombatRange = new System.Windows.Forms.MaskedTextBox();
            this.lblMagicRange = new System.Windows.Forms.Label();
            this.lblArcheryRange = new System.Windows.Forms.Label();
            this.lblCombatRange = new System.Windows.Forms.Label();
            this.mtxtMaxKills = new System.Windows.Forms.MaskedTextBox();
            this.lblMaxKills = new System.Windows.Forms.Label();
            this.mtxtStamPerHit = new System.Windows.Forms.MaskedTextBox();
            this.chkArcheryOnMount = new System.Windows.Forms.CheckBox();
            this.lblStamPerHit = new System.Windows.Forms.Label();
            this.chkHitMessage = new System.Windows.Forms.CheckBox();
            this.grpCombatAnimals = new System.Windows.Forms.GroupBox();
            this.mtxtAnimalAttChance = new System.Windows.Forms.MaskedTextBox();
            this.chkAnimalsGuarded = new System.Windows.Forms.CheckBox();
            this.lblAnimalAttChance = new System.Windows.Forms.Label();
            this.chkMonsterVsAnimals = new System.Windows.Forms.CheckBox();
            this.grpCombatNPC = new System.Windows.Forms.GroupBox();
            this.mtxtReAttackAt = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFleeAt = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNPCDmgRate = new System.Windows.Forms.MaskedTextBox();
            this.lblReAttackAt = new System.Windows.Forms.Label();
            this.lblFleeAt = new System.Windows.Forms.Label();
            this.lblNPCDmgRate = new System.Windows.Forms.Label();
            this.tabSettings2 = new System.Windows.Forms.TabPage();
            this.grpGumps = new System.Windows.Forms.GroupBox();
            this.mtxtGumpBackground = new System.Windows.Forms.MaskedTextBox();
            this.lblGumpBackground = new System.Windows.Forms.Label();
            this.lblGumpText = new System.Windows.Forms.Label();
            this.lblGumpButtons = new System.Windows.Forms.Label();
            this.comboGumpButtons = new System.Windows.Forms.ComboBox();
            this.mtxtGumpButtons = new System.Windows.Forms.MaskedTextBox();
            this.comboGumpText = new System.Windows.Forms.ComboBox();
            this.mtxtGumpText = new System.Windows.Forms.MaskedTextBox();
            this.grpHunger = new System.Windows.Forms.GroupBox();
            this.grpSound = new System.Windows.Forms.GroupBox();
            this.chkAmbientFootsteps = new System.Windows.Forms.CheckBox();
            this.comboAmbientSound = new System.Windows.Forms.ComboBox();
            this.lblAmbientSounds = new System.Windows.Forms.Label();
            this.mtxtPetOfflineTimeout = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHungerDmg = new System.Windows.Forms.MaskedTextBox();
            this.lblPetOfflineTimeoutDays = new System.Windows.Forms.Label();
            this.lblPetOfflineTimeout = new System.Windows.Forms.Label();
            this.chkPetHungerOffline = new System.Windows.Forms.CheckBox();
            this.lblHungerDmg = new System.Windows.Forms.Label();
            this.grpResources = new System.Windows.Forms.GroupBox();
            this.lblMaxOre = new System.Windows.Forms.Label();
            this.mtxtLogArea = new System.Windows.Forms.MaskedTextBox();
            this.lblMaxLogs = new System.Windows.Forms.Label();
            this.comboMineCheck = new System.Windows.Forms.ComboBox();
            this.lblMineCheck = new System.Windows.Forms.Label();
            this.mtxtOreArea = new System.Windows.Forms.MaskedTextBox();
            this.lblOreArea = new System.Windows.Forms.Label();
            this.mtxtMaxLogs = new System.Windows.Forms.MaskedTextBox();
            this.lblLogArea = new System.Windows.Forms.Label();
            this.mtxtMaxOre = new System.Windows.Forms.MaskedTextBox();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.grpSkills = new System.Windows.Forms.GroupBox();
            this.mtxtMaxStaminaMove = new System.Windows.Forms.MaskedTextBox();
            this.lblMaxStamMove = new System.Windows.Forms.Label();
            this.grpCrafting = new System.Windows.Forms.GroupBox();
            this.chkAdvCrafting = new System.Windows.Forms.CheckBox();
            this.comboCraftDiff = new System.Windows.Forms.ComboBox();
            this.lblCraftDiff = new System.Windows.Forms.Label();
            this.grpTracking = new System.Windows.Forms.GroupBox();
            this.mtxtTrackMaxTarg = new System.Windows.Forms.MaskedTextBox();
            this.lblTrackBaseRange = new System.Windows.Forms.Label();
            this.lblTrackMaxTarg = new System.Windows.Forms.Label();
            this.mtxtTrackBaseRange = new System.Windows.Forms.MaskedTextBox();
            this.grpTrade = new System.Windows.Forms.GroupBox();
            this.lblMaxSellItems = new System.Windows.Forms.Label();
            this.chkSellByName = new System.Windows.Forms.CheckBox();
            this.chkAdvTrade = new System.Windows.Forms.CheckBox();
            this.mtxtMaxSellItems = new System.Windows.Forms.MaskedTextBox();
            this.mtxtStatCap = new System.Windows.Forms.MaskedTextBox();
            this.chkSnoopIsCrime = new System.Windows.Forms.CheckBox();
            this.chkHideWhileMounted = new System.Windows.Forms.CheckBox();
            this.chkNPCTrain = new System.Windows.Forms.CheckBox();
            this.chkArmorAffectRegen = new System.Windows.Forms.CheckBox();
            this.mtxtWeightPerSTR = new System.Windows.Forms.MaskedTextBox();
            this.lblWeightPerStr = new System.Windows.Forms.Label();
            this.chkScrollSkill = new System.Windows.Forms.CheckBox();
            this.lblSkillCap = new System.Windows.Forms.Label();
            this.mtxtMaxStealthMove = new System.Windows.Forms.MaskedTextBox();
            this.lblStatCap = new System.Windows.Forms.Label();
            this.mtxtSkillCap = new System.Windows.Forms.MaskedTextBox();
            this.lblMaxStealthMove = new System.Windows.Forms.Label();
            this.tabTimers = new System.Windows.Forms.TabPage();
            this.grpSpeedCheck = new System.Windows.Forms.GroupBox();
            this.dataGridSpeed = new System.Windows.Forms.DataGridView();
            this.dgvSpeedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSpeedSeconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpGameTimers = new System.Windows.Forms.GroupBox();
            this.mtxtSecondsPerUOMin = new System.Windows.Forms.MaskedTextBox();
            this.lblSecondsPerUOMin = new System.Windows.Forms.Label();
            this.dataGridTimers = new System.Windows.Forms.DataGridView();
            this.dgvTimerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTimerSeconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.grpAnnounce = new System.Windows.Forms.GroupBox();
            this.grpLight = new System.Windows.Forms.GroupBox();
            this.mtxtDarkLight = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBrightLight = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDungeonLight = new System.Windows.Forms.MaskedTextBox();
            this.lblDarkLight = new System.Windows.Forms.Label();
            this.lblBrightLight = new System.Windows.Forms.Label();
            this.lblDungeonLight = new System.Windows.Forms.Label();
            this.chkAnnLog = new System.Windows.Forms.CheckBox();
            this.chkAnnSave = new System.Windows.Forms.CheckBox();
            this.grpSettingsGeneral = new System.Windows.Forms.GroupBox();
            this.mtxtBackupRatio = new System.Windows.Forms.MaskedTextBox();
            this.chkEscorts = new System.Windows.Forms.CheckBox();
            this.chkAdvPathfind = new System.Windows.Forms.CheckBox();
            this.chkOverloadPackets = new System.Windows.Forms.CheckBox();
            this.chkShowOfflinePCs = new System.Windows.Forms.CheckBox();
            this.chkAutoAccount = new System.Windows.Forms.CheckBox();
            this.chkGuards = new System.Windows.Forms.CheckBox();
            this.chkLootDecay = new System.Windows.Forms.CheckBox();
            this.lblBackupSaves = new System.Windows.Forms.Label();
            this.chkBackup = new System.Windows.Forms.CheckBox();
            this.chkCrashProtect = new System.Windows.Forms.CheckBox();
            this.chkLogConsole = new System.Windows.Forms.CheckBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.grpDirectories = new System.Windows.Forms.GroupBox();
            this.dataGridDirectories = new System.Windows.Forms.DataGridView();
            this.grpServers = new System.Windows.Forms.GroupBox();
            this.mtxtLSPort = new System.Windows.Forms.MaskedTextBox();
            this.lblLSPort = new System.Windows.Forms.Label();
            this.dataGridServers = new System.Windows.Forms.DataGridView();
            this.dgvServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServerIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServerPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvDirectoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDirectoryPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrivelegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrivelegeEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.tabCreate.SuspendLayout();
            this.grpStartPrivs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrivs)).BeginInit();
            this.grpLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocations)).BeginInit();
            this.tabCombat.SuspendLayout();
            this.grpCombat.SuspendLayout();
            this.grpCombatRange.SuspendLayout();
            this.grpCombatAnimals.SuspendLayout();
            this.grpCombatNPC.SuspendLayout();
            this.tabSettings2.SuspendLayout();
            this.grpGumps.SuspendLayout();
            this.grpHunger.SuspendLayout();
            this.grpSound.SuspendLayout();
            this.grpResources.SuspendLayout();
            this.tabSkills.SuspendLayout();
            this.grpSkills.SuspendLayout();
            this.grpCrafting.SuspendLayout();
            this.grpTracking.SuspendLayout();
            this.grpTrade.SuspendLayout();
            this.tabTimers.SuspendLayout();
            this.grpSpeedCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpeed)).BeginInit();
            this.grpGameTimers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimers)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.grpAnnounce.SuspendLayout();
            this.grpLight.SuspendLayout();
            this.grpSettingsGeneral.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.grpDirectories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDirectories)).BeginInit();
            this.grpServers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServers)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(461, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(378, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(9, 11);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(43, 13);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "INI File:";
            // 
            // txtINIFile
            // 
            this.txtINIFile.Location = new System.Drawing.Point(58, 7);
            this.txtINIFile.Name = "txtINIFile";
            this.txtINIFile.Size = new System.Drawing.Size(397, 20);
            this.txtINIFile.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(461, 7);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(77, 20);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.grpStartPrivs);
            this.tabCreate.Controls.Add(this.grpLocations);
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(518, 193);
            this.tabCreate.TabIndex = 6;
            this.tabCreate.Text = "Character Creation";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // grpStartPrivs
            // 
            this.grpStartPrivs.Controls.Add(this.mtxtStartGold);
            this.grpStartPrivs.Controls.Add(this.lblStartGold);
            this.grpStartPrivs.Controls.Add(this.dataGridPrivs);
            this.grpStartPrivs.Location = new System.Drawing.Point(315, 6);
            this.grpStartPrivs.Name = "grpStartPrivs";
            this.grpStartPrivs.Size = new System.Drawing.Size(197, 181);
            this.grpStartPrivs.TabIndex = 31;
            this.grpStartPrivs.TabStop = false;
            this.grpStartPrivs.Text = "Initial Priveledges";
            // 
            // mtxtStartGold
            // 
            this.mtxtStartGold.Location = new System.Drawing.Point(46, 19);
            this.mtxtStartGold.Mask = "00000";
            this.mtxtStartGold.Name = "mtxtStartGold";
            this.mtxtStartGold.PromptChar = ' ';
            this.mtxtStartGold.Size = new System.Drawing.Size(42, 20);
            this.mtxtStartGold.TabIndex = 84;
            this.mtxtStartGold.ValidatingType = typeof(int);
            // 
            // lblStartGold
            // 
            this.lblStartGold.AutoSize = true;
            this.lblStartGold.Location = new System.Drawing.Point(8, 22);
            this.lblStartGold.Name = "lblStartGold";
            this.lblStartGold.Size = new System.Drawing.Size(32, 13);
            this.lblStartGold.TabIndex = 83;
            this.lblStartGold.Text = "Gold:";
            // 
            // dataGridPrivs
            // 
            this.dataGridPrivs.AllowUserToAddRows = false;
            this.dataGridPrivs.AllowUserToDeleteRows = false;
            this.dataGridPrivs.AllowUserToResizeRows = false;
            this.dataGridPrivs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPrivs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridPrivs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridPrivs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrivs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPrivelegeName,
            this.dgvPrivelegeEnabled});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPrivs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPrivs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridPrivs.Location = new System.Drawing.Point(6, 45);
            this.dataGridPrivs.MultiSelect = false;
            this.dataGridPrivs.Name = "dataGridPrivs";
            this.dataGridPrivs.RowHeadersVisible = false;
            this.dataGridPrivs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridPrivs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPrivs.Size = new System.Drawing.Size(185, 130);
            this.dataGridPrivs.TabIndex = 29;
            // 
            // grpLocations
            // 
            this.grpLocations.Controls.Add(this.dataGridLocations);
            this.grpLocations.Location = new System.Drawing.Point(6, 6);
            this.grpLocations.Name = "grpLocations";
            this.grpLocations.Size = new System.Drawing.Size(311, 181);
            this.grpLocations.TabIndex = 30;
            this.grpLocations.TabStop = false;
            this.grpLocations.Text = "Starting Locations";
            // 
            // dataGridLocations
            // 
            this.dataGridLocations.AllowUserToResizeRows = false;
            this.dataGridLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridLocations.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridLocations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridLocations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLocationTown,
            this.dgvLocationName,
            this.dgvLocationX,
            this.dgvLocationY,
            this.dgvLocationZ});
            this.dataGridLocations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridLocations.Location = new System.Drawing.Point(6, 19);
            this.dataGridLocations.MultiSelect = false;
            this.dataGridLocations.Name = "dataGridLocations";
            this.dataGridLocations.RowHeadersVisible = false;
            this.dataGridLocations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLocations.Size = new System.Drawing.Size(299, 156);
            this.dataGridLocations.TabIndex = 0;
            // 
            // dgvLocationTown
            // 
            this.dgvLocationTown.HeaderText = "Town";
            this.dgvLocationTown.Name = "dgvLocationTown";
            this.dgvLocationTown.Width = 59;
            // 
            // dgvLocationName
            // 
            this.dgvLocationName.HeaderText = "Name";
            this.dgvLocationName.Name = "dgvLocationName";
            this.dgvLocationName.Width = 60;
            // 
            // dgvLocationX
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLocationX.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLocationX.HeaderText = "X";
            this.dgvLocationX.Name = "dgvLocationX";
            this.dgvLocationX.Width = 39;
            // 
            // dgvLocationY
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLocationY.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLocationY.HeaderText = "Y";
            this.dgvLocationY.Name = "dgvLocationY";
            this.dgvLocationY.Width = 39;
            // 
            // dgvLocationZ
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLocationZ.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLocationZ.HeaderText = "Z";
            this.dgvLocationZ.Name = "dgvLocationZ";
            this.dgvLocationZ.Width = 39;
            // 
            // tabCombat
            // 
            this.tabCombat.Controls.Add(this.grpCombat);
            this.tabCombat.Location = new System.Drawing.Point(4, 22);
            this.tabCombat.Name = "tabCombat";
            this.tabCombat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCombat.Size = new System.Drawing.Size(518, 193);
            this.tabCombat.TabIndex = 5;
            this.tabCombat.Text = "Combat";
            this.tabCombat.UseVisualStyleBackColor = true;
            // 
            // grpCombat
            // 
            this.grpCombat.Controls.Add(this.chkPersecute);
            this.grpCombat.Controls.Add(this.chkDeathAnim);
            this.grpCombat.Controls.Add(this.grpCombatRange);
            this.grpCombat.Controls.Add(this.mtxtMaxKills);
            this.grpCombat.Controls.Add(this.lblMaxKills);
            this.grpCombat.Controls.Add(this.mtxtStamPerHit);
            this.grpCombat.Controls.Add(this.chkArcheryOnMount);
            this.grpCombat.Controls.Add(this.lblStamPerHit);
            this.grpCombat.Controls.Add(this.chkHitMessage);
            this.grpCombat.Controls.Add(this.grpCombatAnimals);
            this.grpCombat.Controls.Add(this.grpCombatNPC);
            this.grpCombat.Location = new System.Drawing.Point(6, 6);
            this.grpCombat.Name = "grpCombat";
            this.grpCombat.Size = new System.Drawing.Size(506, 181);
            this.grpCombat.TabIndex = 1;
            this.grpCombat.TabStop = false;
            this.grpCombat.Text = "General";
            // 
            // chkPersecute
            // 
            this.chkPersecute.AutoSize = true;
            this.chkPersecute.Location = new System.Drawing.Point(154, 42);
            this.chkPersecute.Name = "chkPersecute";
            this.chkPersecute.Size = new System.Drawing.Size(169, 17);
            this.chkPersecute.TabIndex = 88;
            this.chkPersecute.Text = "Ghosts Can Persecute Players";
            this.chkPersecute.UseVisualStyleBackColor = true;
            // 
            // chkDeathAnim
            // 
            this.chkDeathAnim.AutoSize = true;
            this.chkDeathAnim.Location = new System.Drawing.Point(6, 42);
            this.chkDeathAnim.Name = "chkDeathAnim";
            this.chkDeathAnim.Size = new System.Drawing.Size(139, 17);
            this.chkDeathAnim.TabIndex = 87;
            this.chkDeathAnim.Text = "Show Death Animations";
            this.chkDeathAnim.UseVisualStyleBackColor = true;
            // 
            // grpCombatRange
            // 
            this.grpCombatRange.Controls.Add(this.mtxtMagicRange);
            this.grpCombatRange.Controls.Add(this.mtxtArcheryRange);
            this.grpCombatRange.Controls.Add(this.mtxtCombatRange);
            this.grpCombatRange.Controls.Add(this.lblMagicRange);
            this.grpCombatRange.Controls.Add(this.lblArcheryRange);
            this.grpCombatRange.Controls.Add(this.lblCombatRange);
            this.grpCombatRange.Location = new System.Drawing.Point(0, 81);
            this.grpCombatRange.Name = "grpCombatRange";
            this.grpCombatRange.Size = new System.Drawing.Size(148, 100);
            this.grpCombatRange.TabIndex = 1;
            this.grpCombatRange.TabStop = false;
            this.grpCombatRange.Text = "Maximum Range";
            // 
            // mtxtMagicRange
            // 
            this.mtxtMagicRange.Location = new System.Drawing.Point(95, 70);
            this.mtxtMagicRange.Mask = "00000";
            this.mtxtMagicRange.Name = "mtxtMagicRange";
            this.mtxtMagicRange.PromptChar = ' ';
            this.mtxtMagicRange.Size = new System.Drawing.Size(42, 20);
            this.mtxtMagicRange.TabIndex = 78;
            this.mtxtMagicRange.ValidatingType = typeof(int);
            // 
            // mtxtArcheryRange
            // 
            this.mtxtArcheryRange.Location = new System.Drawing.Point(95, 44);
            this.mtxtArcheryRange.Mask = "00000";
            this.mtxtArcheryRange.Name = "mtxtArcheryRange";
            this.mtxtArcheryRange.PromptChar = ' ';
            this.mtxtArcheryRange.Size = new System.Drawing.Size(42, 20);
            this.mtxtArcheryRange.TabIndex = 77;
            this.mtxtArcheryRange.ValidatingType = typeof(int);
            // 
            // mtxtCombatRange
            // 
            this.mtxtCombatRange.Location = new System.Drawing.Point(95, 18);
            this.mtxtCombatRange.Mask = "00000";
            this.mtxtCombatRange.Name = "mtxtCombatRange";
            this.mtxtCombatRange.PromptChar = ' ';
            this.mtxtCombatRange.Size = new System.Drawing.Size(42, 20);
            this.mtxtCombatRange.TabIndex = 76;
            this.mtxtCombatRange.ValidatingType = typeof(int);
            // 
            // lblMagicRange
            // 
            this.lblMagicRange.AutoSize = true;
            this.lblMagicRange.Location = new System.Drawing.Point(8, 74);
            this.lblMagicRange.Name = "lblMagicRange";
            this.lblMagicRange.Size = new System.Drawing.Size(74, 13);
            this.lblMagicRange.TabIndex = 75;
            this.lblMagicRange.Text = "Magic Range:";
            // 
            // lblArcheryRange
            // 
            this.lblArcheryRange.AutoSize = true;
            this.lblArcheryRange.Location = new System.Drawing.Point(8, 48);
            this.lblArcheryRange.Name = "lblArcheryRange";
            this.lblArcheryRange.Size = new System.Drawing.Size(81, 13);
            this.lblArcheryRange.TabIndex = 74;
            this.lblArcheryRange.Text = "Archery Range:";
            // 
            // lblCombatRange
            // 
            this.lblCombatRange.AutoSize = true;
            this.lblCombatRange.Location = new System.Drawing.Point(8, 22);
            this.lblCombatRange.Name = "lblCombatRange";
            this.lblCombatRange.Size = new System.Drawing.Size(81, 13);
            this.lblCombatRange.TabIndex = 73;
            this.lblCombatRange.Text = "Combat Range:";
            // 
            // mtxtMaxKills
            // 
            this.mtxtMaxKills.Location = new System.Drawing.Point(455, 17);
            this.mtxtMaxKills.Mask = "00000";
            this.mtxtMaxKills.Name = "mtxtMaxKills";
            this.mtxtMaxKills.PromptChar = ' ';
            this.mtxtMaxKills.Size = new System.Drawing.Size(42, 20);
            this.mtxtMaxKills.TabIndex = 86;
            this.mtxtMaxKills.ValidatingType = typeof(int);
            // 
            // lblMaxKills
            // 
            this.lblMaxKills.AutoSize = true;
            this.lblMaxKills.Location = new System.Drawing.Point(338, 21);
            this.lblMaxKills.Name = "lblMaxKills";
            this.lblMaxKills.Size = new System.Drawing.Size(111, 13);
            this.lblMaxKills.TabIndex = 85;
            this.lblMaxKills.Text = "Max Kills for Murderer:";
            // 
            // mtxtStamPerHit
            // 
            this.mtxtStamPerHit.Location = new System.Drawing.Point(455, 43);
            this.mtxtStamPerHit.Mask = "-0000";
            this.mtxtStamPerHit.Name = "mtxtStamPerHit";
            this.mtxtStamPerHit.PromptChar = ' ';
            this.mtxtStamPerHit.Size = new System.Drawing.Size(42, 20);
            this.mtxtStamPerHit.TabIndex = 84;
            // 
            // chkArcheryOnMount
            // 
            this.chkArcheryOnMount.AutoSize = true;
            this.chkArcheryOnMount.Location = new System.Drawing.Point(154, 19);
            this.chkArcheryOnMount.Name = "chkArcheryOnMount";
            this.chkArcheryOnMount.Size = new System.Drawing.Size(177, 17);
            this.chkArcheryOnMount.TabIndex = 83;
            this.chkArcheryOnMount.Text = "Archery Allowed While Mounted";
            this.chkArcheryOnMount.UseVisualStyleBackColor = true;
            // 
            // lblStamPerHit
            // 
            this.lblStamPerHit.AutoSize = true;
            this.lblStamPerHit.Location = new System.Drawing.Point(338, 47);
            this.lblStamPerHit.Name = "lblStamPerHit";
            this.lblStamPerHit.Size = new System.Drawing.Size(106, 13);
            this.lblStamPerHit.TabIndex = 82;
            this.lblStamPerHit.Text = "Stamina Lost Per Hit:";
            // 
            // chkHitMessage
            // 
            this.chkHitMessage.AutoSize = true;
            this.chkHitMessage.Location = new System.Drawing.Point(6, 19);
            this.chkHitMessage.Name = "chkHitMessage";
            this.chkHitMessage.Size = new System.Drawing.Size(122, 17);
            this.chkHitMessage.TabIndex = 81;
            this.chkHitMessage.Text = "Display Hit Message";
            this.chkHitMessage.UseVisualStyleBackColor = true;
            // 
            // grpCombatAnimals
            // 
            this.grpCombatAnimals.Controls.Add(this.mtxtAnimalAttChance);
            this.grpCombatAnimals.Controls.Add(this.chkAnimalsGuarded);
            this.grpCombatAnimals.Controls.Add(this.lblAnimalAttChance);
            this.grpCombatAnimals.Controls.Add(this.chkMonsterVsAnimals);
            this.grpCombatAnimals.Location = new System.Drawing.Point(143, 81);
            this.grpCombatAnimals.Name = "grpCombatAnimals";
            this.grpCombatAnimals.Size = new System.Drawing.Size(170, 100);
            this.grpCombatAnimals.TabIndex = 1;
            this.grpCombatAnimals.TabStop = false;
            this.grpCombatAnimals.Text = "Animals";
            // 
            // mtxtAnimalAttChance
            // 
            this.mtxtAnimalAttChance.Location = new System.Drawing.Point(118, 70);
            this.mtxtAnimalAttChance.Mask = "00000";
            this.mtxtAnimalAttChance.Name = "mtxtAnimalAttChance";
            this.mtxtAnimalAttChance.PromptChar = ' ';
            this.mtxtAnimalAttChance.ReadOnly = true;
            this.mtxtAnimalAttChance.Size = new System.Drawing.Size(42, 20);
            this.mtxtAnimalAttChance.TabIndex = 77;
            this.mtxtAnimalAttChance.ValidatingType = typeof(int);
            // 
            // chkAnimalsGuarded
            // 
            this.chkAnimalsGuarded.AutoSize = true;
            this.chkAnimalsGuarded.Location = new System.Drawing.Point(11, 20);
            this.chkAnimalsGuarded.Name = "chkAnimalsGuarded";
            this.chkAnimalsGuarded.Size = new System.Drawing.Size(123, 17);
            this.chkAnimalsGuarded.TabIndex = 76;
            this.chkAnimalsGuarded.Text = "Protected by Guards";
            this.chkAnimalsGuarded.UseVisualStyleBackColor = true;
            // 
            // lblAnimalAttChance
            // 
            this.lblAnimalAttChance.AutoSize = true;
            this.lblAnimalAttChance.Location = new System.Drawing.Point(19, 74);
            this.lblAnimalAttChance.Name = "lblAnimalAttChance";
            this.lblAnimalAttChance.Size = new System.Drawing.Size(93, 13);
            this.lblAnimalAttChance.TabIndex = 75;
            this.lblAnimalAttChance.Text = "Chance of Attack:";
            // 
            // chkMonsterVsAnimals
            // 
            this.chkMonsterVsAnimals.AutoSize = true;
            this.chkMonsterVsAnimals.Location = new System.Drawing.Point(11, 43);
            this.chkMonsterVsAnimals.Name = "chkMonsterVsAnimals";
            this.chkMonsterVsAnimals.Size = new System.Drawing.Size(142, 17);
            this.chkMonsterVsAnimals.TabIndex = 74;
            this.chkMonsterVsAnimals.Text = "Monsters Attack Animals";
            this.chkMonsterVsAnimals.UseVisualStyleBackColor = true;
            this.chkMonsterVsAnimals.CheckedChanged += new System.EventHandler(this.chkMonsterVsAnimals_CheckedChanged);
            // 
            // grpCombatNPC
            // 
            this.grpCombatNPC.Controls.Add(this.mtxtReAttackAt);
            this.grpCombatNPC.Controls.Add(this.mtxtFleeAt);
            this.grpCombatNPC.Controls.Add(this.mtxtNPCDmgRate);
            this.grpCombatNPC.Controls.Add(this.lblReAttackAt);
            this.grpCombatNPC.Controls.Add(this.lblFleeAt);
            this.grpCombatNPC.Controls.Add(this.lblNPCDmgRate);
            this.grpCombatNPC.Location = new System.Drawing.Point(309, 81);
            this.grpCombatNPC.Name = "grpCombatNPC";
            this.grpCombatNPC.Size = new System.Drawing.Size(197, 100);
            this.grpCombatNPC.TabIndex = 0;
            this.grpCombatNPC.TabStop = false;
            this.grpCombatNPC.Text = "NPC Combat";
            // 
            // mtxtReAttackAt
            // 
            this.mtxtReAttackAt.Location = new System.Drawing.Point(146, 70);
            this.mtxtReAttackAt.Mask = "00000";
            this.mtxtReAttackAt.Name = "mtxtReAttackAt";
            this.mtxtReAttackAt.PromptChar = ' ';
            this.mtxtReAttackAt.Size = new System.Drawing.Size(42, 20);
            this.mtxtReAttackAt.TabIndex = 82;
            this.mtxtReAttackAt.ValidatingType = typeof(int);
            // 
            // mtxtFleeAt
            // 
            this.mtxtFleeAt.Location = new System.Drawing.Point(146, 44);
            this.mtxtFleeAt.Mask = "00000";
            this.mtxtFleeAt.Name = "mtxtFleeAt";
            this.mtxtFleeAt.PromptChar = ' ';
            this.mtxtFleeAt.Size = new System.Drawing.Size(42, 20);
            this.mtxtFleeAt.TabIndex = 81;
            this.mtxtFleeAt.ValidatingType = typeof(int);
            // 
            // mtxtNPCDmgRate
            // 
            this.mtxtNPCDmgRate.Location = new System.Drawing.Point(146, 18);
            this.mtxtNPCDmgRate.Mask = "00000";
            this.mtxtNPCDmgRate.Name = "mtxtNPCDmgRate";
            this.mtxtNPCDmgRate.PromptChar = ' ';
            this.mtxtNPCDmgRate.Size = new System.Drawing.Size(42, 20);
            this.mtxtNPCDmgRate.TabIndex = 80;
            this.mtxtNPCDmgRate.ValidatingType = typeof(int);
            // 
            // lblReAttackAt
            // 
            this.lblReAttackAt.AutoSize = true;
            this.lblReAttackAt.Location = new System.Drawing.Point(6, 74);
            this.lblReAttackAt.Name = "lblReAttackAt";
            this.lblReAttackAt.Size = new System.Drawing.Size(134, 13);
            this.lblReAttackAt.TabIndex = 79;
            this.lblReAttackAt.Text = "Stops Fleeing At HP Level:";
            // 
            // lblFleeAt
            // 
            this.lblFleeAt.AutoSize = true;
            this.lblFleeAt.Location = new System.Drawing.Point(6, 48);
            this.lblFleeAt.Name = "lblFleeAt";
            this.lblFleeAt.Size = new System.Drawing.Size(95, 13);
            this.lblFleeAt.TabIndex = 78;
            this.lblFleeAt.Text = "Flees At HP Level:";
            // 
            // lblNPCDmgRate
            // 
            this.lblNPCDmgRate.AutoSize = true;
            this.lblNPCDmgRate.Location = new System.Drawing.Point(5, 22);
            this.lblNPCDmgRate.Name = "lblNPCDmgRate";
            this.lblNPCDmgRate.Size = new System.Drawing.Size(94, 13);
            this.lblNPCDmgRate.TabIndex = 77;
            this.lblNPCDmgRate.Text = "Damage Multiplier:";
            // 
            // tabSettings2
            // 
            this.tabSettings2.Controls.Add(this.grpGumps);
            this.tabSettings2.Controls.Add(this.grpHunger);
            this.tabSettings2.Controls.Add(this.grpResources);
            this.tabSettings2.Location = new System.Drawing.Point(4, 22);
            this.tabSettings2.Name = "tabSettings2";
            this.tabSettings2.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings2.Size = new System.Drawing.Size(518, 193);
            this.tabSettings2.TabIndex = 4;
            this.tabSettings2.Text = "Other Settings";
            this.tabSettings2.UseVisualStyleBackColor = true;
            // 
            // grpGumps
            // 
            this.grpGumps.Controls.Add(this.mtxtGumpBackground);
            this.grpGumps.Controls.Add(this.lblGumpBackground);
            this.grpGumps.Controls.Add(this.lblGumpText);
            this.grpGumps.Controls.Add(this.lblGumpButtons);
            this.grpGumps.Controls.Add(this.comboGumpButtons);
            this.grpGumps.Controls.Add(this.mtxtGumpButtons);
            this.grpGumps.Controls.Add(this.comboGumpText);
            this.grpGumps.Controls.Add(this.mtxtGumpText);
            this.grpGumps.Location = new System.Drawing.Point(354, 6);
            this.grpGumps.Name = "grpGumps";
            this.grpGumps.Size = new System.Drawing.Size(158, 181);
            this.grpGumps.TabIndex = 69;
            this.grpGumps.TabStop = false;
            this.grpGumps.Text = "Custom Gumps";
            // 
            // mtxtGumpBackground
            // 
            this.mtxtGumpBackground.Location = new System.Drawing.Point(110, 129);
            this.mtxtGumpBackground.Mask = "00000";
            this.mtxtGumpBackground.Name = "mtxtGumpBackground";
            this.mtxtGumpBackground.PromptChar = ' ';
            this.mtxtGumpBackground.Size = new System.Drawing.Size(42, 20);
            this.mtxtGumpBackground.TabIndex = 90;
            this.mtxtGumpBackground.ValidatingType = typeof(int);
            // 
            // lblGumpBackground
            // 
            this.lblGumpBackground.AutoSize = true;
            this.lblGumpBackground.Location = new System.Drawing.Point(8, 133);
            this.lblGumpBackground.Name = "lblGumpBackground";
            this.lblGumpBackground.Size = new System.Drawing.Size(82, 13);
            this.lblGumpBackground.TabIndex = 89;
            this.lblGumpBackground.Text = "Background ID:";
            // 
            // lblGumpText
            // 
            this.lblGumpText.AutoSize = true;
            this.lblGumpText.Location = new System.Drawing.Point(8, 22);
            this.lblGumpText.Name = "lblGumpText";
            this.lblGumpText.Size = new System.Drawing.Size(60, 13);
            this.lblGumpText.TabIndex = 88;
            this.lblGumpText.Text = "Text Colors";
            // 
            // lblGumpButtons
            // 
            this.lblGumpButtons.AutoSize = true;
            this.lblGumpButtons.Location = new System.Drawing.Point(8, 72);
            this.lblGumpButtons.Name = "lblGumpButtons";
            this.lblGumpButtons.Size = new System.Drawing.Size(59, 13);
            this.lblGumpButtons.TabIndex = 87;
            this.lblGumpButtons.Text = "Button ID\'s";
            // 
            // comboGumpButtons
            // 
            this.comboGumpButtons.FormattingEnabled = true;
            this.comboGumpButtons.Items.AddRange(new object[] {
            "Cancel Button",
            "Forward Button",
            "Back Button"});
            this.comboGumpButtons.Location = new System.Drawing.Point(8, 88);
            this.comboGumpButtons.Name = "comboGumpButtons";
            this.comboGumpButtons.Size = new System.Drawing.Size(96, 21);
            this.comboGumpButtons.TabIndex = 86;
            this.comboGumpButtons.SelectedIndexChanged += new System.EventHandler(this.comboGumpButtons_SelectedIndexChanged);
            // 
            // mtxtGumpButtons
            // 
            this.mtxtGumpButtons.Location = new System.Drawing.Point(110, 88);
            this.mtxtGumpButtons.Mask = "00000";
            this.mtxtGumpButtons.Name = "mtxtGumpButtons";
            this.mtxtGumpButtons.PromptChar = ' ';
            this.mtxtGumpButtons.Size = new System.Drawing.Size(42, 20);
            this.mtxtGumpButtons.TabIndex = 85;
            this.mtxtGumpButtons.ValidatingType = typeof(int);
            // 
            // comboGumpText
            // 
            this.comboGumpText.FormattingEnabled = true;
            this.comboGumpText.Items.AddRange(new object[] {
            "Title Color",
            "Right Color",
            "Left Color"});
            this.comboGumpText.Location = new System.Drawing.Point(8, 38);
            this.comboGumpText.Name = "comboGumpText";
            this.comboGumpText.Size = new System.Drawing.Size(96, 21);
            this.comboGumpText.TabIndex = 75;
            this.comboGumpText.SelectedIndexChanged += new System.EventHandler(this.comboGumpText_SelectedIndexChanged);
            // 
            // mtxtGumpText
            // 
            this.mtxtGumpText.Location = new System.Drawing.Point(110, 38);
            this.mtxtGumpText.Mask = "00000";
            this.mtxtGumpText.Name = "mtxtGumpText";
            this.mtxtGumpText.PromptChar = ' ';
            this.mtxtGumpText.Size = new System.Drawing.Size(42, 20);
            this.mtxtGumpText.TabIndex = 64;
            this.mtxtGumpText.ValidatingType = typeof(int);
            // 
            // grpHunger
            // 
            this.grpHunger.Controls.Add(this.grpSound);
            this.grpHunger.Controls.Add(this.mtxtPetOfflineTimeout);
            this.grpHunger.Controls.Add(this.mtxtHungerDmg);
            this.grpHunger.Controls.Add(this.lblPetOfflineTimeoutDays);
            this.grpHunger.Controls.Add(this.lblPetOfflineTimeout);
            this.grpHunger.Controls.Add(this.chkPetHungerOffline);
            this.grpHunger.Controls.Add(this.lblHungerDmg);
            this.grpHunger.Location = new System.Drawing.Point(182, 6);
            this.grpHunger.Name = "grpHunger";
            this.grpHunger.Size = new System.Drawing.Size(174, 181);
            this.grpHunger.TabIndex = 68;
            this.grpHunger.TabStop = false;
            this.grpHunger.Text = "Hunger";
            // 
            // grpSound
            // 
            this.grpSound.Controls.Add(this.chkAmbientFootsteps);
            this.grpSound.Controls.Add(this.comboAmbientSound);
            this.grpSound.Controls.Add(this.lblAmbientSounds);
            this.grpSound.Location = new System.Drawing.Point(0, 105);
            this.grpSound.Name = "grpSound";
            this.grpSound.Size = new System.Drawing.Size(174, 76);
            this.grpSound.TabIndex = 71;
            this.grpSound.TabStop = false;
            this.grpSound.Text = "Sounds";
            // 
            // chkAmbientFootsteps
            // 
            this.chkAmbientFootsteps.AutoSize = true;
            this.chkAmbientFootsteps.Location = new System.Drawing.Point(9, 49);
            this.chkAmbientFootsteps.Name = "chkAmbientFootsteps";
            this.chkAmbientFootsteps.Size = new System.Drawing.Size(113, 17);
            this.chkAmbientFootsteps.TabIndex = 67;
            this.chkAmbientFootsteps.Text = "Ambient Footsteps";
            this.chkAmbientFootsteps.UseVisualStyleBackColor = true;
            // 
            // comboAmbientSound
            // 
            this.comboAmbientSound.FormattingEnabled = true;
            this.comboAmbientSound.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboAmbientSound.Location = new System.Drawing.Point(123, 24);
            this.comboAmbientSound.Name = "comboAmbientSound";
            this.comboAmbientSound.Size = new System.Drawing.Size(42, 21);
            this.comboAmbientSound.TabIndex = 66;
            // 
            // lblAmbientSounds
            // 
            this.lblAmbientSounds.AutoSize = true;
            this.lblAmbientSounds.Location = new System.Drawing.Point(6, 27);
            this.lblAmbientSounds.Name = "lblAmbientSounds";
            this.lblAmbientSounds.Size = new System.Drawing.Size(111, 13);
            this.lblAmbientSounds.TabIndex = 65;
            this.lblAmbientSounds.Text = "Ambient Sound Level:";
            // 
            // mtxtPetOfflineTimeout
            // 
            this.mtxtPetOfflineTimeout.Location = new System.Drawing.Point(81, 72);
            this.mtxtPetOfflineTimeout.Mask = "00000";
            this.mtxtPetOfflineTimeout.Name = "mtxtPetOfflineTimeout";
            this.mtxtPetOfflineTimeout.PromptChar = ' ';
            this.mtxtPetOfflineTimeout.Size = new System.Drawing.Size(42, 20);
            this.mtxtPetOfflineTimeout.TabIndex = 70;
            this.mtxtPetOfflineTimeout.ValidatingType = typeof(int);
            // 
            // mtxtHungerDmg
            // 
            this.mtxtHungerDmg.Location = new System.Drawing.Point(113, 19);
            this.mtxtHungerDmg.Mask = "00000";
            this.mtxtHungerDmg.Name = "mtxtHungerDmg";
            this.mtxtHungerDmg.PromptChar = ' ';
            this.mtxtHungerDmg.Size = new System.Drawing.Size(42, 20);
            this.mtxtHungerDmg.TabIndex = 69;
            this.mtxtHungerDmg.ValidatingType = typeof(int);
            // 
            // lblPetOfflineTimeoutDays
            // 
            this.lblPetOfflineTimeoutDays.AutoSize = true;
            this.lblPetOfflineTimeoutDays.Location = new System.Drawing.Point(123, 76);
            this.lblPetOfflineTimeoutDays.Name = "lblPetOfflineTimeoutDays";
            this.lblPetOfflineTimeoutDays.Size = new System.Drawing.Size(31, 13);
            this.lblPetOfflineTimeoutDays.TabIndex = 68;
            this.lblPetOfflineTimeoutDays.Text = "Days";
            // 
            // lblPetOfflineTimeout
            // 
            this.lblPetOfflineTimeout.AutoSize = true;
            this.lblPetOfflineTimeout.Location = new System.Drawing.Point(15, 76);
            this.lblPetOfflineTimeout.Name = "lblPetOfflineTimeout";
            this.lblPetOfflineTimeout.Size = new System.Drawing.Size(60, 13);
            this.lblPetOfflineTimeout.TabIndex = 67;
            this.lblPetOfflineTimeout.Text = "Go Wild In:";
            // 
            // chkPetHungerOffline
            // 
            this.chkPetHungerOffline.AutoSize = true;
            this.chkPetHungerOffline.Location = new System.Drawing.Point(9, 48);
            this.chkPetHungerOffline.Name = "chkPetHungerOffline";
            this.chkPetHungerOffline.Size = new System.Drawing.Size(121, 17);
            this.chkPetHungerOffline.TabIndex = 66;
            this.chkPetHungerOffline.Text = "Pets Always Hunger";
            this.chkPetHungerOffline.UseVisualStyleBackColor = true;
            // 
            // lblHungerDmg
            // 
            this.lblHungerDmg.AutoSize = true;
            this.lblHungerDmg.Location = new System.Drawing.Point(6, 23);
            this.lblHungerDmg.Name = "lblHungerDmg";
            this.lblHungerDmg.Size = new System.Drawing.Size(101, 13);
            this.lblHungerDmg.TabIndex = 65;
            this.lblHungerDmg.Text = "Starvation Damage:";
            // 
            // grpResources
            // 
            this.grpResources.Controls.Add(this.lblMaxOre);
            this.grpResources.Controls.Add(this.mtxtLogArea);
            this.grpResources.Controls.Add(this.lblMaxLogs);
            this.grpResources.Controls.Add(this.comboMineCheck);
            this.grpResources.Controls.Add(this.lblMineCheck);
            this.grpResources.Controls.Add(this.mtxtOreArea);
            this.grpResources.Controls.Add(this.lblOreArea);
            this.grpResources.Controls.Add(this.mtxtMaxLogs);
            this.grpResources.Controls.Add(this.lblLogArea);
            this.grpResources.Controls.Add(this.mtxtMaxOre);
            this.grpResources.Location = new System.Drawing.Point(6, 6);
            this.grpResources.Name = "grpResources";
            this.grpResources.Size = new System.Drawing.Size(178, 181);
            this.grpResources.TabIndex = 65;
            this.grpResources.TabStop = false;
            this.grpResources.Text = "Resources";
            // 
            // lblMaxOre
            // 
            this.lblMaxOre.AutoSize = true;
            this.lblMaxOre.Location = new System.Drawing.Point(7, 50);
            this.lblMaxOre.Name = "lblMaxOre";
            this.lblMaxOre.Size = new System.Drawing.Size(94, 13);
            this.lblMaxOre.TabIndex = 38;
            this.lblMaxOre.Text = "Max Ore Per Area:";
            // 
            // mtxtLogArea
            // 
            this.mtxtLogArea.Location = new System.Drawing.Point(128, 124);
            this.mtxtLogArea.Mask = "00000";
            this.mtxtLogArea.Name = "mtxtLogArea";
            this.mtxtLogArea.PromptChar = ' ';
            this.mtxtLogArea.Size = new System.Drawing.Size(42, 20);
            this.mtxtLogArea.TabIndex = 62;
            this.mtxtLogArea.ValidatingType = typeof(int);
            // 
            // lblMaxLogs
            // 
            this.lblMaxLogs.AutoSize = true;
            this.lblMaxLogs.Location = new System.Drawing.Point(7, 76);
            this.lblMaxLogs.Name = "lblMaxLogs";
            this.lblMaxLogs.Size = new System.Drawing.Size(100, 13);
            this.lblMaxLogs.TabIndex = 40;
            this.lblMaxLogs.Text = "Max Logs Per Area:";
            // 
            // comboMineCheck
            // 
            this.comboMineCheck.FormattingEnabled = true;
            this.comboMineCheck.Items.AddRange(new object[] {
            "Everywhere",
            "Cave Floors",
            "Regional"});
            this.comboMineCheck.Location = new System.Drawing.Point(88, 19);
            this.comboMineCheck.Name = "comboMineCheck";
            this.comboMineCheck.Size = new System.Drawing.Size(82, 21);
            this.comboMineCheck.TabIndex = 37;
            // 
            // lblMineCheck
            // 
            this.lblMineCheck.AutoSize = true;
            this.lblMineCheck.Location = new System.Drawing.Point(7, 23);
            this.lblMineCheck.Name = "lblMineCheck";
            this.lblMineCheck.Size = new System.Drawing.Size(69, 13);
            this.lblMineCheck.TabIndex = 36;
            this.lblMineCheck.Text = "Allow Mining:";
            // 
            // mtxtOreArea
            // 
            this.mtxtOreArea.Location = new System.Drawing.Point(128, 98);
            this.mtxtOreArea.Mask = "00000";
            this.mtxtOreArea.Name = "mtxtOreArea";
            this.mtxtOreArea.PromptChar = ' ';
            this.mtxtOreArea.Size = new System.Drawing.Size(42, 20);
            this.mtxtOreArea.TabIndex = 61;
            this.mtxtOreArea.ValidatingType = typeof(int);
            // 
            // lblOreArea
            // 
            this.lblOreArea.AutoSize = true;
            this.lblOreArea.Location = new System.Drawing.Point(7, 101);
            this.lblOreArea.Name = "lblOreArea";
            this.lblOreArea.Size = new System.Drawing.Size(75, 13);
            this.lblOreArea.TabIndex = 42;
            this.lblOreArea.Text = "Ore Area Size:";
            // 
            // mtxtMaxLogs
            // 
            this.mtxtMaxLogs.Location = new System.Drawing.Point(128, 72);
            this.mtxtMaxLogs.Mask = "00000";
            this.mtxtMaxLogs.Name = "mtxtMaxLogs";
            this.mtxtMaxLogs.PromptChar = ' ';
            this.mtxtMaxLogs.Size = new System.Drawing.Size(42, 20);
            this.mtxtMaxLogs.TabIndex = 60;
            this.mtxtMaxLogs.ValidatingType = typeof(int);
            // 
            // lblLogArea
            // 
            this.lblLogArea.AutoSize = true;
            this.lblLogArea.Location = new System.Drawing.Point(7, 127);
            this.lblLogArea.Name = "lblLogArea";
            this.lblLogArea.Size = new System.Drawing.Size(76, 13);
            this.lblLogArea.TabIndex = 44;
            this.lblLogArea.Text = "Log Area Size:";
            // 
            // mtxtMaxOre
            // 
            this.mtxtMaxOre.Location = new System.Drawing.Point(128, 46);
            this.mtxtMaxOre.Mask = "00000";
            this.mtxtMaxOre.Name = "mtxtMaxOre";
            this.mtxtMaxOre.PromptChar = ' ';
            this.mtxtMaxOre.Size = new System.Drawing.Size(42, 20);
            this.mtxtMaxOre.TabIndex = 59;
            this.mtxtMaxOre.ValidatingType = typeof(int);
            // 
            // tabSkills
            // 
            this.tabSkills.Controls.Add(this.grpSkills);
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkills.Size = new System.Drawing.Size(518, 193);
            this.tabSkills.TabIndex = 3;
            this.tabSkills.Text = "Skills & Stats";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // grpSkills
            // 
            this.grpSkills.Controls.Add(this.mtxtMaxStaminaMove);
            this.grpSkills.Controls.Add(this.lblMaxStamMove);
            this.grpSkills.Controls.Add(this.grpCrafting);
            this.grpSkills.Controls.Add(this.grpTracking);
            this.grpSkills.Controls.Add(this.grpTrade);
            this.grpSkills.Controls.Add(this.mtxtStatCap);
            this.grpSkills.Controls.Add(this.chkSnoopIsCrime);
            this.grpSkills.Controls.Add(this.chkHideWhileMounted);
            this.grpSkills.Controls.Add(this.chkNPCTrain);
            this.grpSkills.Controls.Add(this.chkArmorAffectRegen);
            this.grpSkills.Controls.Add(this.mtxtWeightPerSTR);
            this.grpSkills.Controls.Add(this.lblWeightPerStr);
            this.grpSkills.Controls.Add(this.chkScrollSkill);
            this.grpSkills.Controls.Add(this.lblSkillCap);
            this.grpSkills.Controls.Add(this.mtxtMaxStealthMove);
            this.grpSkills.Controls.Add(this.lblStatCap);
            this.grpSkills.Controls.Add(this.mtxtSkillCap);
            this.grpSkills.Controls.Add(this.lblMaxStealthMove);
            this.grpSkills.Location = new System.Drawing.Point(4, 5);
            this.grpSkills.Name = "grpSkills";
            this.grpSkills.Size = new System.Drawing.Size(511, 185);
            this.grpSkills.TabIndex = 67;
            this.grpSkills.TabStop = false;
            this.grpSkills.Text = "General";
            // 
            // mtxtMaxStaminaMove
            // 
            this.mtxtMaxStaminaMove.Location = new System.Drawing.Point(281, 68);
            this.mtxtMaxStaminaMove.Mask = "00000";
            this.mtxtMaxStaminaMove.Name = "mtxtMaxStaminaMove";
            this.mtxtMaxStaminaMove.PromptChar = ' ';
            this.mtxtMaxStaminaMove.Size = new System.Drawing.Size(42, 20);
            this.mtxtMaxStaminaMove.TabIndex = 84;
            this.mtxtMaxStaminaMove.ValidatingType = typeof(int);
            // 
            // lblMaxStamMove
            // 
            this.lblMaxStamMove.AutoSize = true;
            this.lblMaxStamMove.Location = new System.Drawing.Point(153, 71);
            this.lblMaxStamMove.Name = "lblMaxStamMove";
            this.lblMaxStamMove.Size = new System.Drawing.Size(122, 13);
            this.lblMaxStamMove.TabIndex = 83;
            this.lblMaxStamMove.Text = "Steps Per Point of Stam:";
            // 
            // grpCrafting
            // 
            this.grpCrafting.Controls.Add(this.chkAdvCrafting);
            this.grpCrafting.Controls.Add(this.comboCraftDiff);
            this.grpCrafting.Controls.Add(this.lblCraftDiff);
            this.grpCrafting.Location = new System.Drawing.Point(171, 113);
            this.grpCrafting.Name = "grpCrafting";
            this.grpCrafting.Size = new System.Drawing.Size(173, 72);
            this.grpCrafting.TabIndex = 73;
            this.grpCrafting.TabStop = false;
            this.grpCrafting.Text = "Crafting";
            // 
            // chkAdvCrafting
            // 
            this.chkAdvCrafting.AutoSize = true;
            this.chkAdvCrafting.Location = new System.Drawing.Point(8, 21);
            this.chkAdvCrafting.Name = "chkAdvCrafting";
            this.chkAdvCrafting.Size = new System.Drawing.Size(151, 17);
            this.chkAdvCrafting.TabIndex = 47;
            this.chkAdvCrafting.Text = "Advanced Crafting System";
            this.chkAdvCrafting.UseVisualStyleBackColor = true;
            // 
            // comboCraftDiff
            // 
            this.comboCraftDiff.FormattingEnabled = true;
            this.comboCraftDiff.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboCraftDiff.Location = new System.Drawing.Point(103, 45);
            this.comboCraftDiff.Name = "comboCraftDiff";
            this.comboCraftDiff.Size = new System.Drawing.Size(42, 21);
            this.comboCraftDiff.TabIndex = 40;
            // 
            // lblCraftDiff
            // 
            this.lblCraftDiff.AutoSize = true;
            this.lblCraftDiff.Location = new System.Drawing.Point(8, 49);
            this.lblCraftDiff.Name = "lblCraftDiff";
            this.lblCraftDiff.Size = new System.Drawing.Size(89, 13);
            this.lblCraftDiff.TabIndex = 33;
            this.lblCraftDiff.Text = "Crafting Difficulty:";
            // 
            // grpTracking
            // 
            this.grpTracking.Controls.Add(this.mtxtTrackMaxTarg);
            this.grpTracking.Controls.Add(this.lblTrackBaseRange);
            this.grpTracking.Controls.Add(this.lblTrackMaxTarg);
            this.grpTracking.Controls.Add(this.mtxtTrackBaseRange);
            this.grpTracking.Location = new System.Drawing.Point(342, 113);
            this.grpTracking.Name = "grpTracking";
            this.grpTracking.Size = new System.Drawing.Size(169, 72);
            this.grpTracking.TabIndex = 72;
            this.grpTracking.TabStop = false;
            this.grpTracking.Text = "Tracking";
            // 
            // mtxtTrackMaxTarg
            // 
            this.mtxtTrackMaxTarg.Location = new System.Drawing.Point(116, 45);
            this.mtxtTrackMaxTarg.Mask = "00000";
            this.mtxtTrackMaxTarg.Name = "mtxtTrackMaxTarg";
            this.mtxtTrackMaxTarg.PromptChar = ' ';
            this.mtxtTrackMaxTarg.Size = new System.Drawing.Size(42, 20);
            this.mtxtTrackMaxTarg.TabIndex = 61;
            this.mtxtTrackMaxTarg.ValidatingType = typeof(int);
            // 
            // lblTrackBaseRange
            // 
            this.lblTrackBaseRange.AutoSize = true;
            this.lblTrackBaseRange.Location = new System.Drawing.Point(21, 49);
            this.lblTrackBaseRange.Name = "lblTrackBaseRange";
            this.lblTrackBaseRange.Size = new System.Drawing.Size(69, 13);
            this.lblTrackBaseRange.TabIndex = 58;
            this.lblTrackBaseRange.Text = "Base Range:";
            // 
            // lblTrackMaxTarg
            // 
            this.lblTrackMaxTarg.AutoSize = true;
            this.lblTrackMaxTarg.Location = new System.Drawing.Point(21, 23);
            this.lblTrackMaxTarg.Name = "lblTrackMaxTarg";
            this.lblTrackMaxTarg.Size = new System.Drawing.Size(69, 13);
            this.lblTrackMaxTarg.TabIndex = 59;
            this.lblTrackMaxTarg.Text = "Max Targets:";
            // 
            // mtxtTrackBaseRange
            // 
            this.mtxtTrackBaseRange.Location = new System.Drawing.Point(116, 19);
            this.mtxtTrackBaseRange.Mask = "00000";
            this.mtxtTrackBaseRange.Name = "mtxtTrackBaseRange";
            this.mtxtTrackBaseRange.PromptChar = ' ';
            this.mtxtTrackBaseRange.Size = new System.Drawing.Size(42, 20);
            this.mtxtTrackBaseRange.TabIndex = 60;
            this.mtxtTrackBaseRange.ValidatingType = typeof(int);
            // 
            // grpTrade
            // 
            this.grpTrade.Controls.Add(this.lblMaxSellItems);
            this.grpTrade.Controls.Add(this.chkSellByName);
            this.grpTrade.Controls.Add(this.chkAdvTrade);
            this.grpTrade.Controls.Add(this.mtxtMaxSellItems);
            this.grpTrade.Location = new System.Drawing.Point(0, 94);
            this.grpTrade.Name = "grpTrade";
            this.grpTrade.Size = new System.Drawing.Size(173, 91);
            this.grpTrade.TabIndex = 71;
            this.grpTrade.TabStop = false;
            this.grpTrade.Text = "Trade";
            // 
            // lblMaxSellItems
            // 
            this.lblMaxSellItems.AutoSize = true;
            this.lblMaxSellItems.Location = new System.Drawing.Point(9, 22);
            this.lblMaxSellItems.Name = "lblMaxSellItems";
            this.lblMaxSellItems.Size = new System.Drawing.Size(101, 13);
            this.lblMaxSellItems.TabIndex = 45;
            this.lblMaxSellItems.Text = "Max Items Per Sale:";
            // 
            // chkSellByName
            // 
            this.chkSellByName.AutoSize = true;
            this.chkSellByName.Location = new System.Drawing.Point(9, 67);
            this.chkSellByName.Name = "chkSellByName";
            this.chkSellByName.Size = new System.Drawing.Size(117, 17);
            this.chkSellByName.TabIndex = 62;
            this.chkSellByName.Text = "Sell Items By Name";
            this.chkSellByName.UseVisualStyleBackColor = true;
            // 
            // chkAdvTrade
            // 
            this.chkAdvTrade.AutoSize = true;
            this.chkAdvTrade.Location = new System.Drawing.Point(9, 46);
            this.chkAdvTrade.Name = "chkAdvTrade";
            this.chkAdvTrade.Size = new System.Drawing.Size(143, 17);
            this.chkAdvTrade.TabIndex = 46;
            this.chkAdvTrade.Text = "Advanced Trade System";
            this.chkAdvTrade.UseVisualStyleBackColor = true;
            // 
            // mtxtMaxSellItems
            // 
            this.mtxtMaxSellItems.Location = new System.Drawing.Point(116, 18);
            this.mtxtMaxSellItems.Mask = "00000";
            this.mtxtMaxSellItems.Name = "mtxtMaxSellItems";
            this.mtxtMaxSellItems.PromptChar = ' ';
            this.mtxtMaxSellItems.Size = new System.Drawing.Size(42, 20);
            this.mtxtMaxSellItems.TabIndex = 52;
            this.mtxtMaxSellItems.ValidatingType = typeof(int);
            // 
            // mtxtStatCap
            // 
            this.mtxtStatCap.Location = new System.Drawing.Point(84, 42);
            this.mtxtStatCap.Mask = "00000";
            this.mtxtStatCap.Name = "mtxtStatCap";
            this.mtxtStatCap.PromptChar = ' ';
            this.mtxtStatCap.Size = new System.Drawing.Size(42, 20);
            this.mtxtStatCap.TabIndex = 51;
            this.mtxtStatCap.ValidatingType = typeof(int);
            // 
            // chkSnoopIsCrime
            // 
            this.chkSnoopIsCrime.AutoSize = true;
            this.chkSnoopIsCrime.Location = new System.Drawing.Point(341, 87);
            this.chkSnoopIsCrime.Name = "chkSnoopIsCrime";
            this.chkSnoopIsCrime.Size = new System.Drawing.Size(119, 17);
            this.chkSnoopIsCrime.TabIndex = 49;
            this.chkSnoopIsCrime.Text = "Snooping is a Crime";
            this.chkSnoopIsCrime.UseVisualStyleBackColor = true;
            // 
            // chkHideWhileMounted
            // 
            this.chkHideWhileMounted.AutoSize = true;
            this.chkHideWhileMounted.Location = new System.Drawing.Point(341, 18);
            this.chkHideWhileMounted.Name = "chkHideWhileMounted";
            this.chkHideWhileMounted.Size = new System.Drawing.Size(159, 17);
            this.chkHideWhileMounted.TabIndex = 57;
            this.chkHideWhileMounted.Text = "Allow Hiding While Mounted";
            this.chkHideWhileMounted.UseVisualStyleBackColor = true;
            // 
            // chkNPCTrain
            // 
            this.chkNPCTrain.AutoSize = true;
            this.chkNPCTrain.Location = new System.Drawing.Point(6, 70);
            this.chkNPCTrain.Name = "chkNPCTrain";
            this.chkNPCTrain.Size = new System.Drawing.Size(125, 17);
            this.chkNPCTrain.TabIndex = 56;
            this.chkNPCTrain.Text = "Enable NPC Training";
            this.chkNPCTrain.UseVisualStyleBackColor = true;
            // 
            // chkArmorAffectRegen
            // 
            this.chkArmorAffectRegen.AutoSize = true;
            this.chkArmorAffectRegen.Location = new System.Drawing.Point(341, 41);
            this.chkArmorAffectRegen.Name = "chkArmorAffectRegen";
            this.chkArmorAffectRegen.Size = new System.Drawing.Size(154, 17);
            this.chkArmorAffectRegen.TabIndex = 50;
            this.chkArmorAffectRegen.Text = "Armor Affects Mana Regen";
            this.chkArmorAffectRegen.UseVisualStyleBackColor = true;
            // 
            // mtxtWeightPerSTR
            // 
            this.mtxtWeightPerSTR.Location = new System.Drawing.Point(281, 42);
            this.mtxtWeightPerSTR.Mask = "00000";
            this.mtxtWeightPerSTR.Name = "mtxtWeightPerSTR";
            this.mtxtWeightPerSTR.PromptChar = ' ';
            this.mtxtWeightPerSTR.Size = new System.Drawing.Size(42, 20);
            this.mtxtWeightPerSTR.TabIndex = 59;
            this.mtxtWeightPerSTR.ValidatingType = typeof(int);
            // 
            // lblWeightPerStr
            // 
            this.lblWeightPerStr.AutoSize = true;
            this.lblWeightPerStr.Location = new System.Drawing.Point(148, 46);
            this.lblWeightPerStr.Name = "lblWeightPerStr";
            this.lblWeightPerStr.Size = new System.Drawing.Size(127, 13);
            this.lblWeightPerStr.TabIndex = 58;
            this.lblWeightPerStr.Text = "Weight Per Point of STR:";
            // 
            // chkScrollSkill
            // 
            this.chkScrollSkill.AutoSize = true;
            this.chkScrollSkill.Location = new System.Drawing.Point(341, 64);
            this.chkScrollSkill.Name = "chkScrollSkill";
            this.chkScrollSkill.Size = new System.Drawing.Size(164, 17);
            this.chkScrollSkill.TabIndex = 55;
            this.chkScrollSkill.Text = "Use Scroll Skill Requirements";
            this.chkScrollSkill.UseVisualStyleBackColor = true;
            // 
            // lblSkillCap
            // 
            this.lblSkillCap.AutoSize = true;
            this.lblSkillCap.Location = new System.Drawing.Point(6, 20);
            this.lblSkillCap.Name = "lblSkillCap";
            this.lblSkillCap.Size = new System.Drawing.Size(51, 13);
            this.lblSkillCap.TabIndex = 45;
            this.lblSkillCap.Text = "Skill Cap:";
            // 
            // mtxtMaxStealthMove
            // 
            this.mtxtMaxStealthMove.Location = new System.Drawing.Point(281, 16);
            this.mtxtMaxStealthMove.Mask = "00000";
            this.mtxtMaxStealthMove.Name = "mtxtMaxStealthMove";
            this.mtxtMaxStealthMove.PromptChar = ' ';
            this.mtxtMaxStealthMove.Size = new System.Drawing.Size(42, 20);
            this.mtxtMaxStealthMove.TabIndex = 53;
            this.mtxtMaxStealthMove.ValidatingType = typeof(int);
            // 
            // lblStatCap
            // 
            this.lblStatCap.AutoSize = true;
            this.lblStatCap.Location = new System.Drawing.Point(6, 46);
            this.lblStatCap.Name = "lblStatCap";
            this.lblStatCap.Size = new System.Drawing.Size(51, 13);
            this.lblStatCap.TabIndex = 46;
            this.lblStatCap.Text = "Stat Cap:";
            // 
            // mtxtSkillCap
            // 
            this.mtxtSkillCap.Location = new System.Drawing.Point(84, 16);
            this.mtxtSkillCap.Mask = "00000";
            this.mtxtSkillCap.Name = "mtxtSkillCap";
            this.mtxtSkillCap.PromptChar = ' ';
            this.mtxtSkillCap.Size = new System.Drawing.Size(42, 20);
            this.mtxtSkillCap.TabIndex = 52;
            this.mtxtSkillCap.ValidatingType = typeof(int);
            // 
            // lblMaxStealthMove
            // 
            this.lblMaxStealthMove.AutoSize = true;
            this.lblMaxStealthMove.Location = new System.Drawing.Point(151, 20);
            this.lblMaxStealthMove.Name = "lblMaxStealthMove";
            this.lblMaxStealthMove.Size = new System.Drawing.Size(124, 13);
            this.lblMaxStealthMove.TabIndex = 47;
            this.lblMaxStealthMove.Text = "Max Stealth Movements:";
            // 
            // tabTimers
            // 
            this.tabTimers.Controls.Add(this.grpSpeedCheck);
            this.tabTimers.Controls.Add(this.grpGameTimers);
            this.tabTimers.Location = new System.Drawing.Point(4, 22);
            this.tabTimers.Name = "tabTimers";
            this.tabTimers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimers.Size = new System.Drawing.Size(518, 193);
            this.tabTimers.TabIndex = 2;
            this.tabTimers.Text = "Timers";
            this.tabTimers.UseVisualStyleBackColor = true;
            // 
            // grpSpeedCheck
            // 
            this.grpSpeedCheck.Controls.Add(this.dataGridSpeed);
            this.grpSpeedCheck.Location = new System.Drawing.Point(262, 6);
            this.grpSpeedCheck.Name = "grpSpeedCheck";
            this.grpSpeedCheck.Size = new System.Drawing.Size(250, 181);
            this.grpSpeedCheck.TabIndex = 30;
            this.grpSpeedCheck.TabStop = false;
            this.grpSpeedCheck.Text = "Server Speed Checks";
            // 
            // dataGridSpeed
            // 
            this.dataGridSpeed.AllowUserToAddRows = false;
            this.dataGridSpeed.AllowUserToDeleteRows = false;
            this.dataGridSpeed.AllowUserToResizeRows = false;
            this.dataGridSpeed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridSpeed.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridSpeed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridSpeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSpeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSpeedName,
            this.dgvSpeedSeconds});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSpeed.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridSpeed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridSpeed.Location = new System.Drawing.Point(6, 19);
            this.dataGridSpeed.MultiSelect = false;
            this.dataGridSpeed.Name = "dataGridSpeed";
            this.dataGridSpeed.RowHeadersVisible = false;
            this.dataGridSpeed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSpeed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSpeed.Size = new System.Drawing.Size(238, 156);
            this.dataGridSpeed.TabIndex = 28;
            // 
            // dgvSpeedName
            // 
            dataGridViewCellStyle7.NullValue = null;
            this.dgvSpeedName.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSpeedName.HeaderText = "Check";
            this.dgvSpeedName.Name = "dgvSpeedName";
            this.dgvSpeedName.ReadOnly = true;
            this.dgvSpeedName.Width = 63;
            // 
            // dgvSpeedSeconds
            // 
            dataGridViewCellStyle8.NullValue = null;
            this.dgvSpeedSeconds.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSpeedSeconds.HeaderText = "Interval (s)";
            this.dgvSpeedSeconds.Name = "dgvSpeedSeconds";
            this.dgvSpeedSeconds.Width = 81;
            // 
            // grpGameTimers
            // 
            this.grpGameTimers.Controls.Add(this.mtxtSecondsPerUOMin);
            this.grpGameTimers.Controls.Add(this.lblSecondsPerUOMin);
            this.grpGameTimers.Controls.Add(this.dataGridTimers);
            this.grpGameTimers.Location = new System.Drawing.Point(6, 6);
            this.grpGameTimers.Name = "grpGameTimers";
            this.grpGameTimers.Size = new System.Drawing.Size(258, 181);
            this.grpGameTimers.TabIndex = 29;
            this.grpGameTimers.TabStop = false;
            this.grpGameTimers.Text = "Gameplay Timers";
            // 
            // mtxtSecondsPerUOMin
            // 
            this.mtxtSecondsPerUOMin.Location = new System.Drawing.Point(137, 19);
            this.mtxtSecondsPerUOMin.Mask = "00000";
            this.mtxtSecondsPerUOMin.Name = "mtxtSecondsPerUOMin";
            this.mtxtSecondsPerUOMin.PromptChar = ' ';
            this.mtxtSecondsPerUOMin.Size = new System.Drawing.Size(42, 20);
            this.mtxtSecondsPerUOMin.TabIndex = 87;
            this.mtxtSecondsPerUOMin.ValidatingType = typeof(int);
            // 
            // lblSecondsPerUOMin
            // 
            this.lblSecondsPerUOMin.AutoSize = true;
            this.lblSecondsPerUOMin.Location = new System.Drawing.Point(6, 22);
            this.lblSecondsPerUOMin.Name = "lblSecondsPerUOMin";
            this.lblSecondsPerUOMin.Size = new System.Drawing.Size(125, 13);
            this.lblSecondsPerUOMin.TabIndex = 86;
            this.lblSecondsPerUOMin.Text = "Seconds Per UO Minute:";
            // 
            // dataGridTimers
            // 
            this.dataGridTimers.AllowUserToAddRows = false;
            this.dataGridTimers.AllowUserToDeleteRows = false;
            this.dataGridTimers.AllowUserToResizeRows = false;
            this.dataGridTimers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridTimers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridTimers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridTimers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridTimers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTimers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTimerName,
            this.dgvTimerSeconds});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTimers.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridTimers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridTimers.Location = new System.Drawing.Point(6, 45);
            this.dataGridTimers.MultiSelect = false;
            this.dataGridTimers.Name = "dataGridTimers";
            this.dataGridTimers.RowHeadersVisible = false;
            this.dataGridTimers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridTimers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTimers.Size = new System.Drawing.Size(246, 130);
            this.dataGridTimers.TabIndex = 0;
            // 
            // dgvTimerName
            // 
            dataGridViewCellStyle10.NullValue = null;
            this.dgvTimerName.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTimerName.HeaderText = "Timer";
            this.dgvTimerName.Name = "dgvTimerName";
            this.dgvTimerName.ReadOnly = true;
            this.dgvTimerName.Width = 58;
            // 
            // dgvTimerSeconds
            // 
            dataGridViewCellStyle11.NullValue = null;
            this.dgvTimerSeconds.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTimerSeconds.HeaderText = "Value (s)";
            this.dgvTimerSeconds.Name = "dgvTimerSeconds";
            this.dgvTimerSeconds.Width = 73;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.grpAnnounce);
            this.tabSettings.Controls.Add(this.grpSettingsGeneral);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(518, 193);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // grpAnnounce
            // 
            this.grpAnnounce.Controls.Add(this.grpLight);
            this.grpAnnounce.Controls.Add(this.chkAnnLog);
            this.grpAnnounce.Controls.Add(this.chkAnnSave);
            this.grpAnnounce.Location = new System.Drawing.Point(353, 6);
            this.grpAnnounce.Name = "grpAnnounce";
            this.grpAnnounce.Size = new System.Drawing.Size(159, 181);
            this.grpAnnounce.TabIndex = 99;
            this.grpAnnounce.TabStop = false;
            this.grpAnnounce.Text = "Automatically Broadcast";
            // 
            // grpLight
            // 
            this.grpLight.Controls.Add(this.mtxtDarkLight);
            this.grpLight.Controls.Add(this.mtxtBrightLight);
            this.grpLight.Controls.Add(this.mtxtDungeonLight);
            this.grpLight.Controls.Add(this.lblDarkLight);
            this.grpLight.Controls.Add(this.lblBrightLight);
            this.grpLight.Controls.Add(this.lblDungeonLight);
            this.grpLight.Location = new System.Drawing.Point(0, 83);
            this.grpLight.Name = "grpLight";
            this.grpLight.Size = new System.Drawing.Size(159, 98);
            this.grpLight.TabIndex = 10;
            this.grpLight.TabStop = false;
            this.grpLight.Text = "Light Levels";
            // 
            // mtxtDarkLight
            // 
            this.mtxtDarkLight.Location = new System.Drawing.Point(108, 71);
            this.mtxtDarkLight.Mask = "00000";
            this.mtxtDarkLight.Name = "mtxtDarkLight";
            this.mtxtDarkLight.PromptChar = ' ';
            this.mtxtDarkLight.Size = new System.Drawing.Size(42, 20);
            this.mtxtDarkLight.TabIndex = 60;
            this.mtxtDarkLight.ValidatingType = typeof(int);
            // 
            // mtxtBrightLight
            // 
            this.mtxtBrightLight.Location = new System.Drawing.Point(108, 45);
            this.mtxtBrightLight.Mask = "00000";
            this.mtxtBrightLight.Name = "mtxtBrightLight";
            this.mtxtBrightLight.PromptChar = ' ';
            this.mtxtBrightLight.Size = new System.Drawing.Size(42, 20);
            this.mtxtBrightLight.TabIndex = 59;
            this.mtxtBrightLight.ValidatingType = typeof(int);
            // 
            // mtxtDungeonLight
            // 
            this.mtxtDungeonLight.Location = new System.Drawing.Point(108, 19);
            this.mtxtDungeonLight.Mask = "00000";
            this.mtxtDungeonLight.Name = "mtxtDungeonLight";
            this.mtxtDungeonLight.PromptChar = ' ';
            this.mtxtDungeonLight.Size = new System.Drawing.Size(42, 20);
            this.mtxtDungeonLight.TabIndex = 58;
            this.mtxtDungeonLight.ValidatingType = typeof(int);
            // 
            // lblDarkLight
            // 
            this.lblDarkLight.AutoSize = true;
            this.lblDarkLight.Location = new System.Drawing.Point(10, 75);
            this.lblDarkLight.Name = "lblDarkLight";
            this.lblDarkLight.Size = new System.Drawing.Size(74, 13);
            this.lblDarkLight.TabIndex = 57;
            this.lblDarkLight.Text = "Outside Night:";
            // 
            // lblBrightLight
            // 
            this.lblBrightLight.AutoSize = true;
            this.lblBrightLight.Location = new System.Drawing.Point(10, 49);
            this.lblBrightLight.Name = "lblBrightLight";
            this.lblBrightLight.Size = new System.Drawing.Size(68, 13);
            this.lblBrightLight.TabIndex = 56;
            this.lblBrightLight.Text = "Outside Day:";
            // 
            // lblDungeonLight
            // 
            this.lblDungeonLight.AutoSize = true;
            this.lblDungeonLight.Location = new System.Drawing.Point(10, 23);
            this.lblDungeonLight.Name = "lblDungeonLight";
            this.lblDungeonLight.Size = new System.Drawing.Size(59, 13);
            this.lblDungeonLight.TabIndex = 55;
            this.lblDungeonLight.Text = "Dungeons:";
            // 
            // chkAnnLog
            // 
            this.chkAnnLog.AutoSize = true;
            this.chkAnnLog.Location = new System.Drawing.Point(13, 45);
            this.chkAnnLog.Name = "chkAnnLog";
            this.chkAnnLog.Size = new System.Drawing.Size(131, 17);
            this.chkAnnLog.TabIndex = 9;
            this.chkAnnLog.Text = "Connect / Disconnect";
            this.chkAnnLog.UseVisualStyleBackColor = true;
            // 
            // chkAnnSave
            // 
            this.chkAnnSave.AutoSize = true;
            this.chkAnnSave.Location = new System.Drawing.Point(13, 22);
            this.chkAnnSave.Name = "chkAnnSave";
            this.chkAnnSave.Size = new System.Drawing.Size(82, 17);
            this.chkAnnSave.TabIndex = 8;
            this.chkAnnSave.Text = "Worldsaves";
            this.chkAnnSave.UseVisualStyleBackColor = true;
            // 
            // grpSettingsGeneral
            // 
            this.grpSettingsGeneral.Controls.Add(this.mtxtBackupRatio);
            this.grpSettingsGeneral.Controls.Add(this.chkEscorts);
            this.grpSettingsGeneral.Controls.Add(this.chkAdvPathfind);
            this.grpSettingsGeneral.Controls.Add(this.chkOverloadPackets);
            this.grpSettingsGeneral.Controls.Add(this.chkShowOfflinePCs);
            this.grpSettingsGeneral.Controls.Add(this.chkAutoAccount);
            this.grpSettingsGeneral.Controls.Add(this.chkGuards);
            this.grpSettingsGeneral.Controls.Add(this.chkLootDecay);
            this.grpSettingsGeneral.Controls.Add(this.lblBackupSaves);
            this.grpSettingsGeneral.Controls.Add(this.chkBackup);
            this.grpSettingsGeneral.Controls.Add(this.chkCrashProtect);
            this.grpSettingsGeneral.Controls.Add(this.chkLogConsole);
            this.grpSettingsGeneral.Controls.Add(this.txtPrefix);
            this.grpSettingsGeneral.Controls.Add(this.lblPrefix);
            this.grpSettingsGeneral.Location = new System.Drawing.Point(6, 6);
            this.grpSettingsGeneral.Name = "grpSettingsGeneral";
            this.grpSettingsGeneral.Size = new System.Drawing.Size(349, 181);
            this.grpSettingsGeneral.TabIndex = 85;
            this.grpSettingsGeneral.TabStop = false;
            this.grpSettingsGeneral.Text = "General";
            // 
            // mtxtBackupRatio
            // 
            this.mtxtBackupRatio.Location = new System.Drawing.Point(153, 19);
            this.mtxtBackupRatio.Mask = "00000";
            this.mtxtBackupRatio.Name = "mtxtBackupRatio";
            this.mtxtBackupRatio.PromptChar = ' ';
            this.mtxtBackupRatio.ReadOnly = true;
            this.mtxtBackupRatio.Size = new System.Drawing.Size(25, 20);
            this.mtxtBackupRatio.TabIndex = 61;
            this.mtxtBackupRatio.ValidatingType = typeof(int);
            // 
            // chkEscorts
            // 
            this.chkEscorts.AutoSize = true;
            this.chkEscorts.Location = new System.Drawing.Point(9, 137);
            this.chkEscorts.Name = "chkEscorts";
            this.chkEscorts.Size = new System.Drawing.Size(128, 17);
            this.chkEscorts.TabIndex = 97;
            this.chkEscorts.Text = "Enable Escort Quests";
            this.chkEscorts.UseVisualStyleBackColor = true;
            // 
            // chkAdvPathfind
            // 
            this.chkAdvPathfind.AutoSize = true;
            this.chkAdvPathfind.Location = new System.Drawing.Point(153, 91);
            this.chkAdvPathfind.Name = "chkAdvPathfind";
            this.chkAdvPathfind.Size = new System.Drawing.Size(131, 17);
            this.chkAdvPathfind.TabIndex = 96;
            this.chkAdvPathfind.Text = "Advanced Pathfinding";
            this.chkAdvPathfind.UseVisualStyleBackColor = true;
            // 
            // chkOverloadPackets
            // 
            this.chkOverloadPackets.AutoSize = true;
            this.chkOverloadPackets.Location = new System.Drawing.Point(153, 114);
            this.chkOverloadPackets.Name = "chkOverloadPackets";
            this.chkOverloadPackets.Size = new System.Drawing.Size(148, 17);
            this.chkOverloadPackets.TabIndex = 95;
            this.chkOverloadPackets.Text = "Allow Packet Overloading";
            this.chkOverloadPackets.UseVisualStyleBackColor = true;
            // 
            // chkShowOfflinePCs
            // 
            this.chkShowOfflinePCs.AutoSize = true;
            this.chkShowOfflinePCs.Location = new System.Drawing.Point(153, 45);
            this.chkShowOfflinePCs.Name = "chkShowOfflinePCs";
            this.chkShowOfflinePCs.Size = new System.Drawing.Size(162, 17);
            this.chkShowOfflinePCs.TabIndex = 94;
            this.chkShowOfflinePCs.Text = "GMs Can See Offline Players";
            this.chkShowOfflinePCs.UseVisualStyleBackColor = true;
            // 
            // chkAutoAccount
            // 
            this.chkAutoAccount.AutoSize = true;
            this.chkAutoAccount.Location = new System.Drawing.Point(9, 91);
            this.chkAutoAccount.Name = "chkAutoAccount";
            this.chkAutoAccount.Size = new System.Drawing.Size(133, 17);
            this.chkAutoAccount.TabIndex = 93;
            this.chkAutoAccount.Text = "Auto Account Creation";
            this.chkAutoAccount.UseVisualStyleBackColor = true;
            // 
            // chkGuards
            // 
            this.chkGuards.AutoSize = true;
            this.chkGuards.Location = new System.Drawing.Point(9, 114);
            this.chkGuards.Name = "chkGuards";
            this.chkGuards.Size = new System.Drawing.Size(93, 17);
            this.chkGuards.TabIndex = 92;
            this.chkGuards.Text = "Guards Active";
            this.chkGuards.UseVisualStyleBackColor = true;
            // 
            // chkLootDecay
            // 
            this.chkLootDecay.AutoSize = true;
            this.chkLootDecay.Location = new System.Drawing.Point(153, 68);
            this.chkLootDecay.Name = "chkLootDecay";
            this.chkLootDecay.Size = new System.Drawing.Size(144, 17);
            this.chkLootDecay.TabIndex = 91;
            this.chkLootDecay.Text = "Loot Decays with Corpse";
            this.chkLootDecay.UseVisualStyleBackColor = true;
            // 
            // lblBackupSaves
            // 
            this.lblBackupSaves.AutoSize = true;
            this.lblBackupSaves.Location = new System.Drawing.Point(178, 23);
            this.lblBackupSaves.Name = "lblBackupSaves";
            this.lblBackupSaves.Size = new System.Drawing.Size(60, 13);
            this.lblBackupSaves.TabIndex = 90;
            this.lblBackupSaves.Text = "worldsaves";
            // 
            // chkBackup
            // 
            this.chkBackup.AutoSize = true;
            this.chkBackup.Location = new System.Drawing.Point(9, 21);
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.Size = new System.Drawing.Size(144, 17);
            this.chkBackup.TabIndex = 88;
            this.chkBackup.Text = "Backup World Data after";
            this.chkBackup.UseVisualStyleBackColor = true;
            this.chkBackup.CheckedChanged += new System.EventHandler(this.chkBackup_CheckedChanged);
            // 
            // chkCrashProtect
            // 
            this.chkCrashProtect.AutoSize = true;
            this.chkCrashProtect.Location = new System.Drawing.Point(9, 68);
            this.chkCrashProtect.Name = "chkCrashProtect";
            this.chkCrashProtect.Size = new System.Drawing.Size(104, 17);
            this.chkCrashProtect.TabIndex = 87;
            this.chkCrashProtect.Text = "Crash Protection";
            this.chkCrashProtect.UseVisualStyleBackColor = true;
            // 
            // chkLogConsole
            // 
            this.chkLogConsole.AutoSize = true;
            this.chkLogConsole.Location = new System.Drawing.Point(9, 45);
            this.chkLogConsole.Name = "chkLogConsole";
            this.chkLogConsole.Size = new System.Drawing.Size(121, 17);
            this.chkLogConsole.TabIndex = 86;
            this.chkLogConsole.Text = "Log Console Events";
            this.chkLogConsole.UseVisualStyleBackColor = true;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(242, 154);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(22, 20);
            this.txtPrefix.TabIndex = 85;
            this.txtPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(153, 158);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(86, 13);
            this.lblPrefix.TabIndex = 84;
            this.lblPrefix.Text = "Command Prefix:";
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.grpDirectories);
            this.tabGeneral.Controls.Add(this.grpServers);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(518, 193);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // grpDirectories
            // 
            this.grpDirectories.Controls.Add(this.dataGridDirectories);
            this.grpDirectories.Location = new System.Drawing.Point(239, 6);
            this.grpDirectories.Name = "grpDirectories";
            this.grpDirectories.Size = new System.Drawing.Size(272, 181);
            this.grpDirectories.TabIndex = 7;
            this.grpDirectories.TabStop = false;
            this.grpDirectories.Text = "Directories";
            // 
            // dataGridDirectories
            // 
            this.dataGridDirectories.AllowUserToAddRows = false;
            this.dataGridDirectories.AllowUserToDeleteRows = false;
            this.dataGridDirectories.AllowUserToResizeRows = false;
            this.dataGridDirectories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridDirectories.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridDirectories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridDirectories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridDirectories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDirectories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDirectoryName,
            this.dgvDirectoryPath});
            this.dataGridDirectories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridDirectories.Location = new System.Drawing.Point(7, 19);
            this.dataGridDirectories.MultiSelect = false;
            this.dataGridDirectories.Name = "dataGridDirectories";
            this.dataGridDirectories.RowHeadersVisible = false;
            this.dataGridDirectories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridDirectories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDirectories.Size = new System.Drawing.Size(259, 156);
            this.dataGridDirectories.TabIndex = 3;
            this.dataGridDirectories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDirectories_CellDoubleClick);
            // 
            // grpServers
            // 
            this.grpServers.Controls.Add(this.mtxtLSPort);
            this.grpServers.Controls.Add(this.lblLSPort);
            this.grpServers.Controls.Add(this.dataGridServers);
            this.grpServers.Location = new System.Drawing.Point(6, 6);
            this.grpServers.Name = "grpServers";
            this.grpServers.Size = new System.Drawing.Size(234, 181);
            this.grpServers.TabIndex = 6;
            this.grpServers.TabStop = false;
            this.grpServers.Text = "Server List";
            // 
            // mtxtLSPort
            // 
            this.mtxtLSPort.Location = new System.Drawing.Point(101, 16);
            this.mtxtLSPort.Mask = "00000";
            this.mtxtLSPort.Name = "mtxtLSPort";
            this.mtxtLSPort.PromptChar = ' ';
            this.mtxtLSPort.Size = new System.Drawing.Size(42, 20);
            this.mtxtLSPort.TabIndex = 30;
            this.mtxtLSPort.ValidatingType = typeof(int);
            // 
            // lblLSPort
            // 
            this.lblLSPort.AutoSize = true;
            this.lblLSPort.Location = new System.Drawing.Point(6, 19);
            this.lblLSPort.Name = "lblLSPort";
            this.lblLSPort.Size = new System.Drawing.Size(92, 13);
            this.lblLSPort.TabIndex = 29;
            this.lblLSPort.Text = "Login Server Port:";
            // 
            // dataGridServers
            // 
            this.dataGridServers.AllowUserToResizeRows = false;
            this.dataGridServers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridServers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridServers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridServers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvServerName,
            this.dgvServerIP,
            this.dgvServerPort});
            this.dataGridServers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridServers.Location = new System.Drawing.Point(6, 42);
            this.dataGridServers.MultiSelect = false;
            this.dataGridServers.Name = "dataGridServers";
            this.dataGridServers.RowHeadersVisible = false;
            this.dataGridServers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridServers.Size = new System.Drawing.Size(222, 133);
            this.dataGridServers.TabIndex = 0;
            // 
            // dgvServerName
            // 
            this.dgvServerName.HeaderText = "Server";
            this.dgvServerName.Name = "dgvServerName";
            this.dgvServerName.Width = 63;
            // 
            // dgvServerIP
            // 
            this.dgvServerIP.HeaderText = "IP";
            this.dgvServerIP.Name = "dgvServerIP";
            this.dgvServerIP.Width = 42;
            // 
            // dgvServerPort
            // 
            this.dgvServerPort.HeaderText = "Port";
            this.dgvServerPort.Name = "dgvServerPort";
            this.dgvServerPort.Width = 51;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabSettings2);
            this.tabControl.Controls.Add(this.tabTimers);
            this.tabControl.Controls.Add(this.tabSkills);
            this.tabControl.Controls.Add(this.tabCombat);
            this.tabControl.Controls.Add(this.tabCreate);
            this.tabControl.Location = new System.Drawing.Point(12, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(526, 219);
            this.tabControl.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // dgvDirectoryName
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvDirectoryName.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDirectoryName.HeaderText = "Directory";
            this.dgvDirectoryName.Name = "dgvDirectoryName";
            this.dgvDirectoryName.ReadOnly = true;
            this.dgvDirectoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvDirectoryName.Width = 55;
            // 
            // dgvDirectoryPath
            // 
            this.dgvDirectoryPath.HeaderText = "Path";
            this.dgvDirectoryPath.Name = "dgvDirectoryPath";
            this.dgvDirectoryPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvDirectoryPath.Width = 35;
            // 
            // dgvPrivelegeName
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.dgvPrivelegeName.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrivelegeName.HeaderText = "Priveledge";
            this.dgvPrivelegeName.Name = "dgvPrivelegeName";
            this.dgvPrivelegeName.ReadOnly = true;
            this.dgvPrivelegeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvPrivelegeName.Width = 63;
            // 
            // dgvPrivelegeEnabled
            // 
            this.dgvPrivelegeEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrivelegeEnabled.HeaderText = "";
            this.dgvPrivelegeEnabled.Name = "dgvPrivelegeEnabled";
            this.dgvPrivelegeEnabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrivelegeEnabled.Width = 25;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(295, 258);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(77, 23);
            this.btnSaveAs.TabIndex = 7;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // INIEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 293);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtINIFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "INIEditor";
            this.Text = "UOX3 INI Editor v0.1";
            this.tabCreate.ResumeLayout(false);
            this.grpStartPrivs.ResumeLayout(false);
            this.grpStartPrivs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrivs)).EndInit();
            this.grpLocations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocations)).EndInit();
            this.tabCombat.ResumeLayout(false);
            this.grpCombat.ResumeLayout(false);
            this.grpCombat.PerformLayout();
            this.grpCombatRange.ResumeLayout(false);
            this.grpCombatRange.PerformLayout();
            this.grpCombatAnimals.ResumeLayout(false);
            this.grpCombatAnimals.PerformLayout();
            this.grpCombatNPC.ResumeLayout(false);
            this.grpCombatNPC.PerformLayout();
            this.tabSettings2.ResumeLayout(false);
            this.grpGumps.ResumeLayout(false);
            this.grpGumps.PerformLayout();
            this.grpHunger.ResumeLayout(false);
            this.grpHunger.PerformLayout();
            this.grpSound.ResumeLayout(false);
            this.grpSound.PerformLayout();
            this.grpResources.ResumeLayout(false);
            this.grpResources.PerformLayout();
            this.tabSkills.ResumeLayout(false);
            this.grpSkills.ResumeLayout(false);
            this.grpSkills.PerformLayout();
            this.grpCrafting.ResumeLayout(false);
            this.grpCrafting.PerformLayout();
            this.grpTracking.ResumeLayout(false);
            this.grpTracking.PerformLayout();
            this.grpTrade.ResumeLayout(false);
            this.grpTrade.PerformLayout();
            this.tabTimers.ResumeLayout(false);
            this.grpSpeedCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpeed)).EndInit();
            this.grpGameTimers.ResumeLayout(false);
            this.grpGameTimers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimers)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.grpAnnounce.ResumeLayout(false);
            this.grpAnnounce.PerformLayout();
            this.grpLight.ResumeLayout(false);
            this.grpLight.PerformLayout();
            this.grpSettingsGeneral.ResumeLayout(false);
            this.grpSettingsGeneral.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.grpDirectories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDirectories)).EndInit();
            this.grpServers.ResumeLayout(false);
            this.grpServers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServers)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblFile;
		private System.Windows.Forms.TextBox txtINIFile;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.DataGridView dataGridPrivs;
		private System.Windows.Forms.DataGridView dataGridLocations;
		private System.Windows.Forms.TabPage tabCombat;
		private System.Windows.Forms.TabPage tabSettings2;
		private System.Windows.Forms.ComboBox comboMineCheck;
		private System.Windows.Forms.Label lblMineCheck;
		private System.Windows.Forms.TabPage tabSkills;
		private System.Windows.Forms.GroupBox grpSkills;
		private System.Windows.Forms.MaskedTextBox mtxtStatCap;
		private System.Windows.Forms.CheckBox chkSnoopIsCrime;
		private System.Windows.Forms.CheckBox chkHideWhileMounted;
		private System.Windows.Forms.CheckBox chkNPCTrain;
		private System.Windows.Forms.CheckBox chkArmorAffectRegen;
		private System.Windows.Forms.MaskedTextBox mtxtWeightPerSTR;
		private System.Windows.Forms.Label lblWeightPerStr;
		private System.Windows.Forms.CheckBox chkScrollSkill;
		private System.Windows.Forms.Label lblSkillCap;
		private System.Windows.Forms.MaskedTextBox mtxtMaxStealthMove;
		private System.Windows.Forms.Label lblStatCap;
		private System.Windows.Forms.MaskedTextBox mtxtSkillCap;
		private System.Windows.Forms.Label lblMaxStealthMove;
		private System.Windows.Forms.TabPage tabTimers;
		private System.Windows.Forms.DataGridView dataGridSpeed;
		private System.Windows.Forms.DataGridView dataGridTimers;
		private System.Windows.Forms.TabPage tabSettings;
		private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.DataGridView dataGridDirectories;
		private System.Windows.Forms.DataGridView dataGridServers;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvServerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvServerIP;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvServerPort;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.GroupBox grpCrafting;
		private System.Windows.Forms.CheckBox chkAdvCrafting;
		private System.Windows.Forms.ComboBox comboCraftDiff;
		private System.Windows.Forms.Label lblCraftDiff;
		private System.Windows.Forms.GroupBox grpTracking;
		private System.Windows.Forms.MaskedTextBox mtxtTrackMaxTarg;
		private System.Windows.Forms.Label lblTrackBaseRange;
		private System.Windows.Forms.Label lblTrackMaxTarg;
		private System.Windows.Forms.MaskedTextBox mtxtTrackBaseRange;
		private System.Windows.Forms.GroupBox grpTrade;
		private System.Windows.Forms.Label lblMaxSellItems;
		private System.Windows.Forms.CheckBox chkSellByName;
		private System.Windows.Forms.CheckBox chkAdvTrade;
		private System.Windows.Forms.MaskedTextBox mtxtMaxSellItems;
		private System.Windows.Forms.GroupBox grpCombat;
		private System.Windows.Forms.GroupBox grpCombatRange;
		private System.Windows.Forms.MaskedTextBox mtxtMagicRange;
		private System.Windows.Forms.MaskedTextBox mtxtArcheryRange;
		private System.Windows.Forms.MaskedTextBox mtxtCombatRange;
		private System.Windows.Forms.Label lblMagicRange;
		private System.Windows.Forms.Label lblArcheryRange;
		private System.Windows.Forms.Label lblCombatRange;
		private System.Windows.Forms.MaskedTextBox mtxtMaxKills;
		private System.Windows.Forms.Label lblMaxKills;
		private System.Windows.Forms.MaskedTextBox mtxtStamPerHit;
		private System.Windows.Forms.CheckBox chkArcheryOnMount;
		private System.Windows.Forms.Label lblStamPerHit;
		private System.Windows.Forms.CheckBox chkHitMessage;
		private System.Windows.Forms.GroupBox grpCombatAnimals;
		private System.Windows.Forms.MaskedTextBox mtxtAnimalAttChance;
		private System.Windows.Forms.CheckBox chkAnimalsGuarded;
		private System.Windows.Forms.Label lblAnimalAttChance;
		private System.Windows.Forms.CheckBox chkMonsterVsAnimals;
		private System.Windows.Forms.GroupBox grpCombatNPC;
		private System.Windows.Forms.MaskedTextBox mtxtReAttackAt;
		private System.Windows.Forms.MaskedTextBox mtxtFleeAt;
		private System.Windows.Forms.MaskedTextBox mtxtNPCDmgRate;
		private System.Windows.Forms.Label lblReAttackAt;
		private System.Windows.Forms.Label lblFleeAt;
		private System.Windows.Forms.Label lblNPCDmgRate;
		private System.Windows.Forms.CheckBox chkPersecute;
		private System.Windows.Forms.CheckBox chkDeathAnim;
		private System.Windows.Forms.GroupBox grpResources;
		private System.Windows.Forms.Label lblMaxOre;
		private System.Windows.Forms.MaskedTextBox mtxtLogArea;
		private System.Windows.Forms.Label lblMaxLogs;
		private System.Windows.Forms.MaskedTextBox mtxtOreArea;
		private System.Windows.Forms.Label lblOreArea;
		private System.Windows.Forms.MaskedTextBox mtxtMaxLogs;
		private System.Windows.Forms.Label lblLogArea;
		private System.Windows.Forms.MaskedTextBox mtxtMaxOre;
		private System.Windows.Forms.GroupBox grpHunger;
		private System.Windows.Forms.GroupBox grpSound;
		private System.Windows.Forms.CheckBox chkAmbientFootsteps;
		private System.Windows.Forms.ComboBox comboAmbientSound;
		private System.Windows.Forms.Label lblAmbientSounds;
		private System.Windows.Forms.MaskedTextBox mtxtPetOfflineTimeout;
		private System.Windows.Forms.MaskedTextBox mtxtHungerDmg;
		private System.Windows.Forms.Label lblPetOfflineTimeoutDays;
		private System.Windows.Forms.Label lblPetOfflineTimeout;
		private System.Windows.Forms.CheckBox chkPetHungerOffline;
		private System.Windows.Forms.Label lblHungerDmg;
		private System.Windows.Forms.GroupBox grpServers;
		private System.Windows.Forms.GroupBox grpDirectories;
		private System.Windows.Forms.GroupBox grpSpeedCheck;
		private System.Windows.Forms.GroupBox grpGameTimers;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvSpeedName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvSpeedSeconds;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvTimerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvTimerSeconds;
		private System.Windows.Forms.GroupBox grpStartPrivs;
		private System.Windows.Forms.GroupBox grpLocations;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocationTown;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocationName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocationX;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocationY;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocationZ;
		private System.Windows.Forms.MaskedTextBox mtxtStartGold;
		private System.Windows.Forms.Label lblStartGold;
		private System.Windows.Forms.MaskedTextBox mtxtLSPort;
		private System.Windows.Forms.Label lblLSPort;
		private System.Windows.Forms.MaskedTextBox mtxtSecondsPerUOMin;
		private System.Windows.Forms.Label lblSecondsPerUOMin;
		private System.Windows.Forms.MaskedTextBox mtxtMaxStaminaMove;
		private System.Windows.Forms.Label lblMaxStamMove;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.GroupBox grpGumps;
		private System.Windows.Forms.MaskedTextBox mtxtGumpText;
        private System.Windows.Forms.GroupBox grpSettingsGeneral;
		private System.Windows.Forms.CheckBox chkEscorts;
		private System.Windows.Forms.CheckBox chkAdvPathfind;
		private System.Windows.Forms.CheckBox chkOverloadPackets;
		private System.Windows.Forms.CheckBox chkShowOfflinePCs;
		private System.Windows.Forms.CheckBox chkAutoAccount;
		private System.Windows.Forms.CheckBox chkGuards;
		private System.Windows.Forms.CheckBox chkLootDecay;
        private System.Windows.Forms.Label lblBackupSaves;
		private System.Windows.Forms.CheckBox chkBackup;
		private System.Windows.Forms.CheckBox chkCrashProtect;
		private System.Windows.Forms.CheckBox chkLogConsole;
		private System.Windows.Forms.TextBox txtPrefix;
		private System.Windows.Forms.Label lblPrefix;
		private System.Windows.Forms.ComboBox comboGumpText;
		private System.Windows.Forms.Label lblGumpButtons;
		private System.Windows.Forms.ComboBox comboGumpButtons;
		private System.Windows.Forms.MaskedTextBox mtxtGumpButtons;
		private System.Windows.Forms.Label lblGumpText;
		private System.Windows.Forms.MaskedTextBox mtxtGumpBackground;
		private System.Windows.Forms.Label lblGumpBackground;

		ushort[] gumpText = new ushort[3];
		ushort[] gumpButtons = new ushort[3];
        private System.Windows.Forms.GroupBox grpAnnounce;
        private System.Windows.Forms.GroupBox grpLight;
        private System.Windows.Forms.MaskedTextBox mtxtDarkLight;
        private System.Windows.Forms.MaskedTextBox mtxtBrightLight;
        private System.Windows.Forms.MaskedTextBox mtxtDungeonLight;
        private System.Windows.Forms.Label lblDarkLight;
        private System.Windows.Forms.Label lblBrightLight;
        private System.Windows.Forms.Label lblDungeonLight;
        private System.Windows.Forms.CheckBox chkAnnLog;
        private System.Windows.Forms.CheckBox chkAnnSave;
        private System.Windows.Forms.MaskedTextBox mtxtBackupRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDirectoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDirectoryPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrivelegeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvPrivelegeEnabled;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveAs;
	}
}


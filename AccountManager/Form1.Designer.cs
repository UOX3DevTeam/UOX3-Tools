using System.Collections.Generic;

namespace AccountManager
{
	partial class AccountManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManager));
			this.listAccounts = new System.Windows.Forms.ListBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblDirectory = new System.Windows.Forms.Label();
			this.txtAccountsDir = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.lblProgress = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblPass = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.cbPublic = new System.Windows.Forms.CheckBox();
			this.grpLevel = new System.Windows.Forms.GroupBox();
			this.rdPlayer = new System.Windows.Forms.RadioButton();
			this.rdGM = new System.Windows.Forms.RadioButton();
			this.rdCns = new System.Windows.Forms.RadioButton();
			this.rdSeer = new System.Windows.Forms.RadioButton();
			this.grpStatus = new System.Windows.Forms.GroupBox();
			this.rdBanned = new System.Windows.Forms.RadioButton();
			this.rdSuspended = new System.Windows.Forms.RadioButton();
			this.lblContact = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.lblPath = new System.Windows.Forms.Label();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.lblTimeban = new System.Windows.Forms.Label();
			this.btnEditChar = new System.Windows.Forms.Button();
			this.grpAccountSettings = new System.Windows.Forms.GroupBox();
			this.txtTimeban = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.txtAccountStats = new System.Windows.Forms.TextBox();
			this.txtBanStats = new System.Windows.Forms.TextBox();
			this.txtPlayerStats = new System.Windows.Forms.TextBox();
			this.btnRenumber = new System.Windows.Forms.Button();
			this.grpLevel.SuspendLayout();
			this.grpStatus.SuspendLayout();
			this.grpAccountSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// listAccounts
			// 
			this.listAccounts.FormattingEnabled = true;
			this.listAccounts.HorizontalScrollbar = true;
			this.listAccounts.Location = new System.Drawing.Point(96, 33);
			this.listAccounts.Name = "listAccounts";
			this.listAccounts.Size = new System.Drawing.Size(126, 238);
			this.listAccounts.TabIndex = 8;
			this.listAccounts.SelectedIndexChanged += new System.EventHandler(this.listAccounts_SelectedIndexChanged);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(425, 277);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(77, 23);
			this.btnCancel.TabIndex = 25;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(344, 277);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 24;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblDirectory
			// 
			this.lblDirectory.AutoSize = true;
			this.lblDirectory.Location = new System.Drawing.Point(3, 10);
			this.lblDirectory.Name = "lblDirectory";
			this.lblDirectory.Size = new System.Drawing.Size(87, 13);
			this.lblDirectory.TabIndex = 3;
			this.lblDirectory.Text = "Accounts Folder:";
			// 
			// txtAccountsDir
			// 
			this.txtAccountsDir.Location = new System.Drawing.Point(96, 7);
			this.txtAccountsDir.Name = "txtAccountsDir";
			this.txtAccountsDir.Size = new System.Drawing.Size(334, 20);
			this.txtAccountsDir.TabIndex = 1;
			this.txtAccountsDir.TextChanged += new System.EventHandler(this.txtAccountsDir_TextChanged);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(436, 7);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(66, 20);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(6, 32);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(84, 22);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(6, 60);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(84, 22);
			this.btnRemove.TabIndex = 4;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// lblProgress
			// 
			this.lblProgress.AutoSize = true;
			this.lblProgress.Location = new System.Drawing.Point(3, 230);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(48, 13);
			this.lblProgress.TabIndex = 8;
			this.lblProgress.Text = "Progress";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(6, 247);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(84, 24);
			this.progressBar.TabIndex = 7;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(9, 21);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 10;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(69, 18);
			this.txtName.MaxLength = 256;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(195, 20);
			this.txtName.TabIndex = 9;
			this.txtName.LostFocus += new System.EventHandler(this.txtName_LostFocus);
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// lblPass
			// 
			this.lblPass.AutoSize = true;
			this.lblPass.Location = new System.Drawing.Point(9, 47);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(56, 13);
			this.lblPass.TabIndex = 12;
			this.lblPass.Text = "Password:";
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(69, 44);
			this.txtPass.MaxLength = 256;
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(195, 20);
			this.txtPass.TabIndex = 10;
			this.txtPass.UseSystemPasswordChar = true;
			this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
			// 
			// cbPublic
			// 
			this.cbPublic.AutoSize = true;
			this.cbPublic.Location = new System.Drawing.Point(69, 121);
			this.cbPublic.Name = "cbPublic";
			this.cbPublic.Size = new System.Drawing.Size(121, 17);
			this.cbPublic.TabIndex = 13;
			this.cbPublic.Text = "Display Contact Info";
			this.cbPublic.UseVisualStyleBackColor = true;
			this.cbPublic.CheckedChanged += new System.EventHandler(this.cbPublic_CheckedChanged);
			// 
			// grpLevel
			// 
			this.grpLevel.Controls.Add(this.rdPlayer);
			this.grpLevel.Controls.Add(this.rdGM);
			this.grpLevel.Controls.Add(this.rdCns);
			this.grpLevel.Controls.Add(this.rdSeer);
			this.grpLevel.Location = new System.Drawing.Point(13, 166);
			this.grpLevel.Name = "grpLevel";
			this.grpLevel.Size = new System.Drawing.Size(122, 66);
			this.grpLevel.TabIndex = 15;
			this.grpLevel.TabStop = false;
			this.grpLevel.Text = "Level";
			// 
			// rdPlayer
			// 
			this.rdPlayer.AutoSize = true;
			this.rdPlayer.Location = new System.Drawing.Point(6, 19);
			this.rdPlayer.Name = "rdPlayer";
			this.rdPlayer.Size = new System.Drawing.Size(54, 17);
			this.rdPlayer.TabIndex = 15;
			this.rdPlayer.TabStop = true;
			this.rdPlayer.Text = "Player";
			this.rdPlayer.UseVisualStyleBackColor = true;
			// 
			// rdGM
			// 
			this.rdGM.AutoSize = true;
			this.rdGM.Location = new System.Drawing.Point(66, 42);
			this.rdGM.Name = "rdGM";
			this.rdGM.Size = new System.Drawing.Size(42, 17);
			this.rdGM.TabIndex = 18;
			this.rdGM.TabStop = true;
			this.rdGM.Text = "GM";
			this.rdGM.UseVisualStyleBackColor = true;
			this.rdGM.CheckedChanged += new System.EventHandler(this.rdGM_CheckedChanged);
			// 
			// rdCns
			// 
			this.rdCns.AutoSize = true;
			this.rdCns.Location = new System.Drawing.Point(6, 41);
			this.rdCns.Name = "rdCns";
			this.rdCns.Size = new System.Drawing.Size(47, 17);
			this.rdCns.TabIndex = 17;
			this.rdCns.TabStop = true;
			this.rdCns.Text = "CNS";
			this.rdCns.UseVisualStyleBackColor = true;
			this.rdCns.CheckedChanged += new System.EventHandler(this.rdCns_CheckedChanged);
			// 
			// rdSeer
			// 
			this.rdSeer.AutoSize = true;
			this.rdSeer.Location = new System.Drawing.Point(66, 19);
			this.rdSeer.Name = "rdSeer";
			this.rdSeer.Size = new System.Drawing.Size(47, 17);
			this.rdSeer.TabIndex = 16;
			this.rdSeer.TabStop = true;
			this.rdSeer.Text = "Seer";
			this.rdSeer.UseVisualStyleBackColor = true;
			this.rdSeer.CheckedChanged += new System.EventHandler(this.rdSeer_CheckedChanged);
			// 
			// grpStatus
			// 
			this.grpStatus.Controls.Add(this.rdBanned);
			this.grpStatus.Controls.Add(this.rdSuspended);
			this.grpStatus.Location = new System.Drawing.Point(141, 166);
			this.grpStatus.Name = "grpStatus";
			this.grpStatus.Size = new System.Drawing.Size(89, 66);
			this.grpStatus.TabIndex = 19;
			this.grpStatus.TabStop = false;
			this.grpStatus.Text = "Status";
			// 
			// rdBanned
			// 
			this.rdBanned.AutoSize = true;
			this.rdBanned.Location = new System.Drawing.Point(6, 19);
			this.rdBanned.Name = "rdBanned";
			this.rdBanned.Size = new System.Drawing.Size(62, 17);
			this.rdBanned.TabIndex = 19;
			this.rdBanned.TabStop = true;
			this.rdBanned.Text = "Banned";
			this.rdBanned.UseVisualStyleBackColor = true;
			this.rdBanned.CheckedChanged += new System.EventHandler(this.rdBanned_CheckedChanged);
			// 
			// rdSuspended
			// 
			this.rdSuspended.AutoSize = true;
			this.rdSuspended.Location = new System.Drawing.Point(6, 41);
			this.rdSuspended.Name = "rdSuspended";
			this.rdSuspended.Size = new System.Drawing.Size(79, 17);
			this.rdSuspended.TabIndex = 20;
			this.rdSuspended.TabStop = true;
			this.rdSuspended.Text = "Suspended";
			this.rdSuspended.UseVisualStyleBackColor = true;
			this.rdSuspended.CheckedChanged += new System.EventHandler(this.rdSuspended_CheckedChanged);
			// 
			// lblContact
			// 
			this.lblContact.AutoSize = true;
			this.lblContact.Location = new System.Drawing.Point(9, 99);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(47, 13);
			this.lblContact.TabIndex = 31;
			this.lblContact.Text = "Contact:";
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(69, 70);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(195, 20);
			this.txtPath.TabIndex = 11;
			this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new System.Drawing.Point(9, 73);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(32, 13);
			this.lblPath.TabIndex = 33;
			this.lblPath.Text = "Path:";
			// 
			// txtContact
			// 
			this.txtContact.Location = new System.Drawing.Point(69, 96);
			this.txtContact.MaxLength = 256;
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(195, 20);
			this.txtContact.TabIndex = 12;
			this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
			// 
			// lblTimeban
			// 
			this.lblTimeban.AutoSize = true;
			this.lblTimeban.Location = new System.Drawing.Point(9, 143);
			this.lblTimeban.Name = "lblTimeban";
			this.lblTimeban.Size = new System.Drawing.Size(52, 13);
			this.lblTimeban.TabIndex = 35;
			this.lblTimeban.Text = "TimeBan:";
			// 
			// btnEditChar
			// 
			this.btnEditChar.Location = new System.Drawing.Point(6, 116);
			this.btnEditChar.Name = "btnEditChar";
			this.btnEditChar.Size = new System.Drawing.Size(84, 22);
			this.btnEditChar.TabIndex = 6;
			this.btnEditChar.Text = "Edit Chars";
			this.btnEditChar.UseVisualStyleBackColor = true;
			this.btnEditChar.Click += new System.EventHandler(this.btnEditChar_Click);
			// 
			// grpAccountSettings
			// 
			this.grpAccountSettings.Controls.Add(this.txtTimeban);
			this.grpAccountSettings.Controls.Add(this.lblName);
			this.grpAccountSettings.Controls.Add(this.txtName);
			this.grpAccountSettings.Controls.Add(this.lblPass);
			this.grpAccountSettings.Controls.Add(this.txtPass);
			this.grpAccountSettings.Controls.Add(this.txtPath);
			this.grpAccountSettings.Controls.Add(this.grpStatus);
			this.grpAccountSettings.Controls.Add(this.grpLevel);
			this.grpAccountSettings.Controls.Add(this.txtContact);
			this.grpAccountSettings.Controls.Add(this.lblTimeban);
			this.grpAccountSettings.Controls.Add(this.lblPath);
			this.grpAccountSettings.Controls.Add(this.lblContact);
			this.grpAccountSettings.Controls.Add(this.cbPublic);
			this.grpAccountSettings.Location = new System.Drawing.Point(228, 30);
			this.grpAccountSettings.Name = "grpAccountSettings";
			this.grpAccountSettings.Size = new System.Drawing.Size(274, 241);
			this.grpAccountSettings.TabIndex = 9;
			this.grpAccountSettings.TabStop = false;
			this.grpAccountSettings.Text = "Account Settings";
			// 
			// txtTimeban
			// 
			this.txtTimeban.Location = new System.Drawing.Point(69, 140);
			this.txtTimeban.MaxLength = 10;
			this.txtTimeban.Name = "txtTimeban";
			this.txtTimeban.Size = new System.Drawing.Size(195, 20);
			this.txtTimeban.TabIndex = 14;
			this.txtTimeban.TextChanged += new System.EventHandler(this.txtTimeban_TextChanged);
			// 
			// txtAccountStats
			// 
			this.txtAccountStats.Location = new System.Drawing.Point(6, 280);
			this.txtAccountStats.Name = "txtAccountStats";
			this.txtAccountStats.ReadOnly = true;
			this.txtAccountStats.Size = new System.Drawing.Size(99, 20);
			this.txtAccountStats.TabIndex = 21;
			// 
			// txtBanStats
			// 
			this.txtBanStats.Location = new System.Drawing.Point(111, 280);
			this.txtBanStats.Name = "txtBanStats";
			this.txtBanStats.ReadOnly = true;
			this.txtBanStats.Size = new System.Drawing.Size(99, 20);
			this.txtBanStats.TabIndex = 22;
			// 
			// txtPlayerStats
			// 
			this.txtPlayerStats.Location = new System.Drawing.Point(216, 280);
			this.txtPlayerStats.Name = "txtPlayerStats";
			this.txtPlayerStats.ReadOnly = true;
			this.txtPlayerStats.Size = new System.Drawing.Size(99, 20);
			this.txtPlayerStats.TabIndex = 23;
			// 
			// btnRenumber
			// 
			this.btnRenumber.Location = new System.Drawing.Point(6, 88);
			this.btnRenumber.Name = "btnRenumber";
			this.btnRenumber.Size = new System.Drawing.Size(84, 22);
			this.btnRenumber.TabIndex = 5;
			this.btnRenumber.Text = "Re-Number";
			this.btnRenumber.UseVisualStyleBackColor = true;
			this.btnRenumber.Click += new System.EventHandler(this.btnRenumber_Click);
			// 
			// AccountManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 306);
			this.Controls.Add(this.btnRenumber);
			this.Controls.Add(this.txtPlayerStats);
			this.Controls.Add(this.txtBanStats);
			this.Controls.Add(this.txtAccountStats);
			this.Controls.Add(this.grpAccountSettings);
			this.Controls.Add(this.btnEditChar);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.lblProgress);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtAccountsDir);
			this.Controls.Add(this.lblDirectory);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.listAccounts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AccountManager";
			this.Text = "UOX3 Account Manager v0.3";
			this.grpLevel.ResumeLayout(false);
			this.grpLevel.PerformLayout();
			this.grpStatus.ResumeLayout(false);
			this.grpStatus.PerformLayout();
			this.grpAccountSettings.ResumeLayout(false);
			this.grpAccountSettings.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listAccounts;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblDirectory;
		private System.Windows.Forms.TextBox txtAccountsDir;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Label lblProgress;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.CheckBox cbPublic;
		private System.Windows.Forms.GroupBox grpLevel;
		private System.Windows.Forms.RadioButton rdGM;
		private System.Windows.Forms.RadioButton rdCns;
		private System.Windows.Forms.RadioButton rdSeer;
		private System.Windows.Forms.RadioButton rdPlayer;
		private System.Windows.Forms.GroupBox grpStatus;
		private System.Windows.Forms.RadioButton rdBanned;
		private System.Windows.Forms.RadioButton rdSuspended;
		private System.Windows.Forms.Label lblContact;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.TextBox txtContact;
		private System.Windows.Forms.Label lblTimeban;
		private System.Windows.Forms.Button btnEditChar;
		private System.Windows.Forms.GroupBox grpAccountSettings;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.TextBox txtTimeban;
		private System.Windows.Forms.TextBox txtAccountStats;
		private System.Windows.Forms.TextBox txtBanStats;
		private System.Windows.Forms.TextBox txtPlayerStats;
		private System.Windows.Forms.Button btnRenumber;

		protected List<AccountObject> accountList;
		protected CharacterEditor myForm;
		protected int nextAcct;
		protected int numAccts;
		protected int numBans;
		protected int numPlayers;
	}
}


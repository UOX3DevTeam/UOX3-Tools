namespace AccountManager
{
	partial class CharacterEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterEditor));
			this.grpCharSettings = new System.Windows.Forms.GroupBox();
			this.txtCharName = new System.Windows.Forms.TextBox();
			this.lblCharName = new System.Windows.Forms.Label();
			this.cbBlockSlot = new System.Windows.Forms.CheckBox();
			this.txtCharSer = new System.Windows.Forms.TextBox();
			this.lblCharSer = new System.Windows.Forms.Label();
			this.lblCharSlots = new System.Windows.Forms.Label();
			this.listCharacters = new System.Windows.Forms.ListBox();
			this.btnCharHide = new System.Windows.Forms.Button();
			this.grpCharSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpCharSettings
			// 
			this.grpCharSettings.Controls.Add(this.txtCharName);
			this.grpCharSettings.Controls.Add(this.lblCharName);
			this.grpCharSettings.Controls.Add(this.cbBlockSlot);
			this.grpCharSettings.Controls.Add(this.txtCharSer);
			this.grpCharSettings.Controls.Add(this.lblCharSer);
			this.grpCharSettings.Location = new System.Drawing.Point(130, 13);
			this.grpCharSettings.Name = "grpCharSettings";
			this.grpCharSettings.Size = new System.Drawing.Size(236, 101);
			this.grpCharSettings.TabIndex = 45;
			this.grpCharSettings.TabStop = false;
			this.grpCharSettings.Text = "Character Settings";
			// 
			// txtCharName
			// 
			this.txtCharName.Location = new System.Drawing.Point(48, 19);
			this.txtCharName.MaxLength = 256;
			this.txtCharName.Name = "txtCharName";
			this.txtCharName.ReadOnly = true;
			this.txtCharName.Size = new System.Drawing.Size(179, 20);
			this.txtCharName.TabIndex = 2;
			// 
			// lblCharName
			// 
			this.lblCharName.AutoSize = true;
			this.lblCharName.Location = new System.Drawing.Point(6, 22);
			this.lblCharName.Name = "lblCharName";
			this.lblCharName.Size = new System.Drawing.Size(38, 13);
			this.lblCharName.TabIndex = 39;
			this.lblCharName.Text = "Name:";
			// 
			// cbBlockSlot
			// 
			this.cbBlockSlot.AutoSize = true;
			this.cbBlockSlot.Location = new System.Drawing.Point(48, 78);
			this.cbBlockSlot.Name = "cbBlockSlot";
			this.cbBlockSlot.Size = new System.Drawing.Size(102, 17);
			this.cbBlockSlot.TabIndex = 4;
			this.cbBlockSlot.Text = "Block Character";
			this.cbBlockSlot.UseVisualStyleBackColor = true;
			this.cbBlockSlot.CheckedChanged += new System.EventHandler(this.cbBlockSlot_CheckedChanged);
			// 
			// txtCharSer
			// 
			this.txtCharSer.Location = new System.Drawing.Point(48, 45);
			this.txtCharSer.MaxLength = 10;
			this.txtCharSer.Name = "txtCharSer";
			this.txtCharSer.Size = new System.Drawing.Size(179, 20);
			this.txtCharSer.TabIndex = 3;
			this.txtCharSer.TextChanged += new System.EventHandler(this.txtCharSer_TextChanged);
			// 
			// lblCharSer
			// 
			this.lblCharSer.AutoSize = true;
			this.lblCharSer.Location = new System.Drawing.Point(6, 48);
			this.lblCharSer.Name = "lblCharSer";
			this.lblCharSer.Size = new System.Drawing.Size(36, 13);
			this.lblCharSer.TabIndex = 37;
			this.lblCharSer.Text = "Serial:";
			// 
			// lblCharSlots
			// 
			this.lblCharSlots.AutoSize = true;
			this.lblCharSlots.Location = new System.Drawing.Point(3, 3);
			this.lblCharSlots.Name = "lblCharSlots";
			this.lblCharSlots.Size = new System.Drawing.Size(82, 13);
			this.lblCharSlots.TabIndex = 44;
			this.lblCharSlots.Text = "Character Slots:";
			// 
			// listCharacters
			// 
			this.listCharacters.FormattingEnabled = true;
			this.listCharacters.HorizontalScrollbar = true;
			this.listCharacters.Location = new System.Drawing.Point(6, 19);
			this.listCharacters.Name = "listCharacters";
			this.listCharacters.Size = new System.Drawing.Size(117, 95);
			this.listCharacters.TabIndex = 1;
			this.listCharacters.SelectedIndexChanged += new System.EventHandler(this.listCharacters_SelectedIndexChanged);
			// 
			// btnCharHide
			// 
			this.btnCharHide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCharHide.Location = new System.Drawing.Point(289, 120);
			this.btnCharHide.Name = "btnCharHide";
			this.btnCharHide.Size = new System.Drawing.Size(77, 23);
			this.btnCharHide.TabIndex = 6;
			this.btnCharHide.Text = "Hide";
			this.btnCharHide.UseVisualStyleBackColor = true;
			this.btnCharHide.Click += new System.EventHandler(this.btnCharHide_Click);
			// 
			// CharacterEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCharHide;
			this.ClientSize = new System.Drawing.Size(372, 149);
			this.ControlBox = false;
			this.Controls.Add(this.btnCharHide);
			this.Controls.Add(this.grpCharSettings);
			this.Controls.Add(this.lblCharSlots);
			this.Controls.Add(this.listCharacters);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CharacterEditor";
			this.Text = "UOX3 Account Manager - Character Editor";
			this.grpCharSettings.ResumeLayout(false);
			this.grpCharSettings.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpCharSettings;
		private System.Windows.Forms.TextBox txtCharName;
		private System.Windows.Forms.Label lblCharName;
		private System.Windows.Forms.CheckBox cbBlockSlot;
		private System.Windows.Forms.TextBox txtCharSer;
		private System.Windows.Forms.Label lblCharSer;
		private System.Windows.Forms.Label lblCharSlots;
		private System.Windows.Forms.ListBox listCharacters;
		private System.Windows.Forms.Button btnCharHide;
	}
}
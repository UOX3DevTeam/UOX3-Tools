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
			this.grpActive = new System.Windows.Forms.GroupBox();
			this.txtCharName = new System.Windows.Forms.TextBox();
			this.cbBlockSlot = new System.Windows.Forms.CheckBox();
			this.txtCharSer = new System.Windows.Forms.TextBox();
			this.listCharacters = new System.Windows.Forms.ListBox();
			this.lblCharSer = new System.Windows.Forms.Label();
			this.btnCharHide = new System.Windows.Forms.Button();
			this.listOrphans = new System.Windows.Forms.ListBox();
			this.grpOrphans = new System.Windows.Forms.GroupBox();
			this.btnRestore = new System.Windows.Forms.Button();
			this.txtOrphName = new System.Windows.Forms.TextBox();
			this.txtOrphSerial = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grpActive.SuspendLayout();
			this.grpOrphans.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpActive
			// 
			this.grpActive.Controls.Add(this.txtCharName);
			this.grpActive.Controls.Add(this.cbBlockSlot);
			this.grpActive.Controls.Add(this.txtCharSer);
			this.grpActive.Controls.Add(this.listCharacters);
			this.grpActive.Controls.Add(this.lblCharSer);
			this.grpActive.Location = new System.Drawing.Point(6, 8);
			this.grpActive.Name = "grpActive";
			this.grpActive.Size = new System.Drawing.Size(163, 203);
			this.grpActive.TabIndex = 2;
			this.grpActive.TabStop = false;
			this.grpActive.Text = "Active Characters";
			// 
			// txtCharName
			// 
			this.txtCharName.Location = new System.Drawing.Point(12, 120);
			this.txtCharName.MaxLength = 256;
			this.txtCharName.Name = "txtCharName";
			this.txtCharName.ReadOnly = true;
			this.txtCharName.Size = new System.Drawing.Size(141, 20);
			this.txtCharName.TabIndex = 2;
			// 
			// cbBlockSlot
			// 
			this.cbBlockSlot.AutoSize = true;
			this.cbBlockSlot.Location = new System.Drawing.Point(51, 179);
			this.cbBlockSlot.Name = "cbBlockSlot";
			this.cbBlockSlot.Size = new System.Drawing.Size(102, 17);
			this.cbBlockSlot.TabIndex = 4;
			this.cbBlockSlot.Text = "Block Character";
			this.cbBlockSlot.UseVisualStyleBackColor = true;
			this.cbBlockSlot.CheckedChanged += new System.EventHandler(this.cbBlockSlot_CheckedChanged);
			// 
			// txtCharSer
			// 
			this.txtCharSer.Location = new System.Drawing.Point(51, 146);
			this.txtCharSer.MaxLength = 10;
			this.txtCharSer.Name = "txtCharSer";
			this.txtCharSer.Size = new System.Drawing.Size(102, 20);
			this.txtCharSer.TabIndex = 3;
			this.txtCharSer.TextChanged += new System.EventHandler(this.txtCharSer_TextChanged);
			// 
			// listCharacters
			// 
			this.listCharacters.FormattingEnabled = true;
			this.listCharacters.HorizontalScrollbar = true;
			this.listCharacters.Location = new System.Drawing.Point(9, 19);
			this.listCharacters.Name = "listCharacters";
			this.listCharacters.Size = new System.Drawing.Size(144, 95);
			this.listCharacters.TabIndex = 1;
			this.listCharacters.SelectedIndexChanged += new System.EventHandler(this.listCharacters_SelectedIndexChanged);
			// 
			// lblCharSer
			// 
			this.lblCharSer.AutoSize = true;
			this.lblCharSer.Location = new System.Drawing.Point(9, 149);
			this.lblCharSer.Name = "lblCharSer";
			this.lblCharSer.Size = new System.Drawing.Size(36, 13);
			this.lblCharSer.TabIndex = 37;
			this.lblCharSer.Text = "Serial:";
			// 
			// btnCharHide
			// 
			this.btnCharHide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCharHide.Location = new System.Drawing.Point(250, 217);
			this.btnCharHide.Name = "btnCharHide";
			this.btnCharHide.Size = new System.Drawing.Size(77, 23);
			this.btnCharHide.TabIndex = 6;
			this.btnCharHide.Text = "Hide";
			this.btnCharHide.UseVisualStyleBackColor = true;
			this.btnCharHide.Click += new System.EventHandler(this.btnCharHide_Click);
			// 
			// listOrphans
			// 
			this.listOrphans.FormattingEnabled = true;
			this.listOrphans.HorizontalScrollbar = true;
			this.listOrphans.Location = new System.Drawing.Point(10, 19);
			this.listOrphans.Name = "listOrphans";
			this.listOrphans.Size = new System.Drawing.Size(144, 95);
			this.listOrphans.TabIndex = 45;
			this.listOrphans.SelectedIndexChanged += new System.EventHandler(this.listOrphans_SelectedIndexChanged);
			// 
			// grpOrphans
			// 
			this.grpOrphans.Controls.Add(this.btnRestore);
			this.grpOrphans.Controls.Add(this.txtOrphName);
			this.grpOrphans.Controls.Add(this.listOrphans);
			this.grpOrphans.Controls.Add(this.txtOrphSerial);
			this.grpOrphans.Controls.Add(this.label2);
			this.grpOrphans.Location = new System.Drawing.Point(165, 8);
			this.grpOrphans.Name = "grpOrphans";
			this.grpOrphans.Size = new System.Drawing.Size(162, 203);
			this.grpOrphans.TabIndex = 40;
			this.grpOrphans.TabStop = false;
			this.grpOrphans.Text = "Orphan Characters";
			// 
			// btnRestore
			// 
			this.btnRestore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnRestore.Enabled = false;
			this.btnRestore.Location = new System.Drawing.Point(52, 172);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(77, 23);
			this.btnRestore.TabIndex = 41;
			this.btnRestore.Text = "Restore";
			this.btnRestore.UseVisualStyleBackColor = true;
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// txtOrphName
			// 
			this.txtOrphName.Location = new System.Drawing.Point(13, 120);
			this.txtOrphName.MaxLength = 256;
			this.txtOrphName.Name = "txtOrphName";
			this.txtOrphName.ReadOnly = true;
			this.txtOrphName.Size = new System.Drawing.Size(141, 20);
			this.txtOrphName.TabIndex = 2;
			// 
			// txtOrphSerial
			// 
			this.txtOrphSerial.Location = new System.Drawing.Point(52, 146);
			this.txtOrphSerial.MaxLength = 10;
			this.txtOrphSerial.Name = "txtOrphSerial";
			this.txtOrphSerial.ReadOnly = true;
			this.txtOrphSerial.Size = new System.Drawing.Size(102, 20);
			this.txtOrphSerial.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 37;
			this.label2.Text = "Serial:";
			// 
			// CharacterEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCharHide;
			this.ClientSize = new System.Drawing.Size(332, 246);
			this.ControlBox = false;
			this.Controls.Add(this.grpOrphans);
			this.Controls.Add(this.btnCharHide);
			this.Controls.Add(this.grpActive);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CharacterEditor";
			this.Text = "UOX3 Account Manager - Character Editor";
			this.grpActive.ResumeLayout(false);
			this.grpActive.PerformLayout();
			this.grpOrphans.ResumeLayout(false);
			this.grpOrphans.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpActive;
		private System.Windows.Forms.TextBox txtCharName;
		private System.Windows.Forms.CheckBox cbBlockSlot;
		private System.Windows.Forms.TextBox txtCharSer;
		private System.Windows.Forms.Label lblCharSer;
		private System.Windows.Forms.ListBox listCharacters;
		private System.Windows.Forms.Button btnCharHide;
		private System.Windows.Forms.ListBox listOrphans;
		private System.Windows.Forms.GroupBox grpOrphans;
		private System.Windows.Forms.TextBox txtOrphName;
		private System.Windows.Forms.TextBox txtOrphSerial;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRestore;
	}
}
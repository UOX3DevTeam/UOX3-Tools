using System.Collections;

namespace CharacterExporter
{
    partial class CharacterViewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterViewer));
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.comboCharList = new System.Windows.Forms.ListBox();
			this.comboItemList = new System.Windows.Forms.ListBox();
			this.ChooseWorldLabel = new System.Windows.Forms.Label();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.txtDirPath = new System.Windows.Forms.TextBox();
			this.fileBrowserDialog = new System.Windows.Forms.OpenFileDialog();
			this.radioAll = new System.Windows.Forms.RadioButton();
			this.radioNone = new System.Windows.Forms.RadioButton();
			this.radioWearables = new System.Windows.Forms.RadioButton();
			this.radioPack = new System.Windows.Forms.RadioButton();
			this.lblKeepItems = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(440, 8);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(61, 20);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(9, 35);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(84, 22);
			this.btnImport.TabIndex = 7;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(9, 63);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(84, 22);
			this.btnExport.TabIndex = 8;
			this.btnExport.Text = "Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(345, 266);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(426, 266);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// comboCharList
			// 
			this.comboCharList.FormattingEnabled = true;
			this.comboCharList.Location = new System.Drawing.Point(99, 35);
			this.comboCharList.Name = "comboCharList";
			this.comboCharList.Size = new System.Drawing.Size(143, 225);
			this.comboCharList.TabIndex = 14;
			this.comboCharList.SelectedIndexChanged += new System.EventHandler(this.comboCharList_SelectedIndexChanged);
			// 
			// comboItemList
			// 
			this.comboItemList.FormattingEnabled = true;
			this.comboItemList.Location = new System.Drawing.Point(248, 35);
			this.comboItemList.Name = "comboItemList";
			this.comboItemList.Size = new System.Drawing.Size(253, 225);
			this.comboItemList.TabIndex = 15;
			// 
			// ChooseWorldLabel
			// 
			this.ChooseWorldLabel.AutoSize = true;
			this.ChooseWorldLabel.Location = new System.Drawing.Point(6, 12);
			this.ChooseWorldLabel.Name = "ChooseWorldLabel";
			this.ChooseWorldLabel.Size = new System.Drawing.Size(90, 13);
			this.ChooseWorldLabel.TabIndex = 16;
			this.ChooseWorldLabel.Text = "Choose Worldfile:";
			// 
			// txtDirPath
			// 
			this.txtDirPath.Location = new System.Drawing.Point(99, 9);
			this.txtDirPath.Name = "txtDirPath";
			this.txtDirPath.Size = new System.Drawing.Size(335, 20);
			this.txtDirPath.TabIndex = 17;
			this.txtDirPath.TextChanged += new System.EventHandler(this.txtDirPath_TextChanged);
			// 
			// radioAll
			// 
			this.radioAll.AutoSize = true;
			this.radioAll.Location = new System.Drawing.Point(12, 117);
			this.radioAll.Name = "radioAll";
			this.radioAll.Size = new System.Drawing.Size(36, 17);
			this.radioAll.TabIndex = 18;
			this.radioAll.TabStop = true;
			this.radioAll.Text = "All";
			this.radioAll.UseVisualStyleBackColor = true;
			this.radioAll.CheckedChanged += new System.EventHandler(this.radioAll_CheckedChanged);
			// 
			// radioNone
			// 
			this.radioNone.AutoSize = true;
			this.radioNone.Location = new System.Drawing.Point(12, 140);
			this.radioNone.Name = "radioNone";
			this.radioNone.Size = new System.Drawing.Size(51, 17);
			this.radioNone.TabIndex = 19;
			this.radioNone.TabStop = true;
			this.radioNone.Text = "None";
			this.radioNone.UseVisualStyleBackColor = true;
			this.radioNone.CheckedChanged += new System.EventHandler(this.radioNone_CheckedChanged);
			// 
			// radioWearables
			// 
			this.radioWearables.AutoSize = true;
			this.radioWearables.Location = new System.Drawing.Point(12, 163);
			this.radioWearables.Name = "radioWearables";
			this.radioWearables.Size = new System.Drawing.Size(76, 17);
			this.radioWearables.TabIndex = 20;
			this.radioWearables.TabStop = true;
			this.radioWearables.Text = "Wearables";
			this.radioWearables.UseVisualStyleBackColor = true;
			this.radioWearables.CheckedChanged += new System.EventHandler(this.radioWearables_CheckedChanged);
			// 
			// radioPack
			// 
			this.radioPack.AutoSize = true;
			this.radioPack.Location = new System.Drawing.Point(12, 186);
			this.radioPack.Name = "radioPack";
			this.radioPack.Size = new System.Drawing.Size(78, 17);
			this.radioPack.TabIndex = 21;
			this.radioPack.TabStop = true;
			this.radioPack.Text = "Pack Items";
			this.radioPack.UseVisualStyleBackColor = true;
			this.radioPack.CheckedChanged += new System.EventHandler(this.radioPack_CheckedChanged);
			// 
			// lblKeepItems
			// 
			this.lblKeepItems.AutoSize = true;
			this.lblKeepItems.Location = new System.Drawing.Point(6, 101);
			this.lblKeepItems.Name = "lblKeepItems";
			this.lblKeepItems.Size = new System.Drawing.Size(65, 13);
			this.lblKeepItems.TabIndex = 22;
			this.lblKeepItems.Text = "Export Items";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(9, 237);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(84, 23);
			this.progressBar.TabIndex = 23;
			this.progressBar.UseWaitCursor = true;
			this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 221);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Progress";
			// 
			// CharacterViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 296);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.lblKeepItems);
			this.Controls.Add(this.radioPack);
			this.Controls.Add(this.radioWearables);
			this.Controls.Add(this.radioNone);
			this.Controls.Add(this.radioAll);
			this.Controls.Add(this.txtDirPath);
			this.Controls.Add(this.ChooseWorldLabel);
			this.Controls.Add(this.comboItemList);
			this.Controls.Add(this.comboCharList);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.btnBrowse);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CharacterViewer";
			this.Text = "UOX3 Character Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox comboCharList;
        private System.Windows.Forms.ListBox comboItemList;
        private System.Windows.Forms.Label ChooseWorldLabel;
        private System.Windows.Forms.TextBox txtDirPath;
		private System.Windows.Forms.RadioButton radioAll;
		private System.Windows.Forms.RadioButton radioNone;
		private System.Windows.Forms.RadioButton radioWearables;
		private System.Windows.Forms.RadioButton radioPack;
		private System.Windows.Forms.Label lblKeepItems;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.OpenFileDialog fileBrowserDialog;
		private System.Windows.Forms.ProgressBar progressBar;
		protected ArrayList worldFiles			= new ArrayList();
		protected ObjectHandler worldObjects	= new ObjectHandler();
		private KeepItemsState keepItemState;
		private System.Windows.Forms.Label label1;
    }
}


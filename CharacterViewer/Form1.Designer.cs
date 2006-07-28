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
			this.lblProgress = new System.Windows.Forms.Label();
			this.splitPanel = new System.Windows.Forms.SplitContainer();
			this.dataGridItems = new System.Windows.Forms.DataGridView();
			this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.splitPanel.Panel1.SuspendLayout();
			this.splitPanel.Panel2.SuspendLayout();
			this.splitPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
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
			this.btnImport.TabIndex = 3;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(9, 63);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(84, 22);
			this.btnExport.TabIndex = 4;
			this.btnExport.Text = "Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(345, 266);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(426, 266);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// comboCharList
			// 
			this.comboCharList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboCharList.FormattingEnabled = true;
			this.comboCharList.HorizontalScrollbar = true;
			this.comboCharList.Location = new System.Drawing.Point(0, 0);
			this.comboCharList.Name = "comboCharList";
			this.comboCharList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.comboCharList.Size = new System.Drawing.Size(159, 225);
			this.comboCharList.TabIndex = 10;
			this.comboCharList.SelectedIndexChanged += new System.EventHandler(this.comboCharList_SelectedIndexChanged);
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
			this.txtDirPath.TabIndex = 1;
			this.txtDirPath.TextChanged += new System.EventHandler(this.txtDirPath_TextChanged);
			// 
			// fileBrowserDialog
			// 
			this.fileBrowserDialog.Multiselect = true;
			// 
			// radioAll
			// 
			this.radioAll.AutoSize = true;
			this.radioAll.Checked = true;
			this.radioAll.Location = new System.Drawing.Point(12, 117);
			this.radioAll.Name = "radioAll";
			this.radioAll.Size = new System.Drawing.Size(36, 17);
			this.radioAll.TabIndex = 5;
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
			this.radioNone.TabIndex = 6;
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
			this.radioWearables.TabIndex = 7;
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
			this.radioPack.TabIndex = 8;
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
			this.progressBar.BackColor = System.Drawing.SystemColors.Control;
			this.progressBar.Location = new System.Drawing.Point(9, 237);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(84, 23);
			this.progressBar.TabIndex = 9;
			// 
			// lblProgress
			// 
			this.lblProgress.AutoSize = true;
			this.lblProgress.Location = new System.Drawing.Point(6, 221);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(48, 13);
			this.lblProgress.TabIndex = 24;
			this.lblProgress.Text = "Progress";
			// 
			// splitPanel
			// 
			this.splitPanel.Location = new System.Drawing.Point(99, 35);
			this.splitPanel.Name = "splitPanel";
			// 
			// splitPanel.Panel1
			// 
			this.splitPanel.Panel1.Controls.Add(this.comboCharList);
			this.splitPanel.Panel1MinSize = 50;
			// 
			// splitPanel.Panel2
			// 
			this.splitPanel.Panel2.Controls.Add(this.dataGridItems);
			this.splitPanel.Panel2MinSize = 50;
			this.splitPanel.Size = new System.Drawing.Size(402, 225);
			this.splitPanel.SplitterDistance = 159;
			this.splitPanel.TabIndex = 11;
			// 
			// dataGridItems
			// 
			this.dataGridItems.AllowUserToAddRows = false;
			this.dataGridItems.AllowUserToDeleteRows = false;
			this.dataGridItems.AllowUserToResizeRows = false;
			this.dataGridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridItems.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgName,
            this.dgID,
            this.dgSerial});
			this.dataGridItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridItems.Location = new System.Drawing.Point(0, 0);
			this.dataGridItems.Name = "dataGridItems";
			this.dataGridItems.ReadOnly = true;
			this.dataGridItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridItems.RowHeadersVisible = false;
			this.dataGridItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridItems.Size = new System.Drawing.Size(239, 225);
			this.dataGridItems.TabIndex = 13;
			// 
			// dgName
			// 
			this.dgName.HeaderText = "Name";
			this.dgName.Name = "dgName";
			this.dgName.ReadOnly = true;
			this.dgName.Width = 58;
			// 
			// dgID
			// 
			this.dgID.HeaderText = "ID";
			this.dgID.Name = "dgID";
			this.dgID.ReadOnly = true;
			this.dgID.Width = 41;
			// 
			// dgSerial
			// 
			this.dgSerial.HeaderText = "Serial";
			this.dgSerial.Name = "dgSerial";
			this.dgSerial.ReadOnly = true;
			this.dgSerial.Width = 56;
			// 
			// CharacterViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 296);
			this.Controls.Add(this.splitPanel);
			this.Controls.Add(this.lblProgress);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.lblKeepItems);
			this.Controls.Add(this.radioPack);
			this.Controls.Add(this.radioWearables);
			this.Controls.Add(this.radioNone);
			this.Controls.Add(this.radioAll);
			this.Controls.Add(this.txtDirPath);
			this.Controls.Add(this.ChooseWorldLabel);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.btnBrowse);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CharacterViewer";
			this.Text = "UOX3 Character Viewer v0.6";
			this.splitPanel.Panel1.ResumeLayout(false);
			this.splitPanel.Panel2.ResumeLayout(false);
			this.splitPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
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
        private System.Windows.Forms.Label ChooseWorldLabel;
        private System.Windows.Forms.TextBox txtDirPath;
		private System.Windows.Forms.RadioButton radioAll;
		private System.Windows.Forms.RadioButton radioNone;
		private System.Windows.Forms.RadioButton radioWearables;
		private System.Windows.Forms.RadioButton radioPack;
		private System.Windows.Forms.Label lblKeepItems;
		private System.Windows.Forms.Label lblProgress;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.OpenFileDialog fileBrowserDialog;
		private System.Windows.Forms.ProgressBar progressBar;
		protected ArrayList worldFiles;
		protected ObjectHandler worldObjects;
		private KeepItemsState keepItemState;
		private System.Windows.Forms.SplitContainer splitPanel;
		private System.Windows.Forms.DataGridView dataGridItems;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgSerial;
    }
}


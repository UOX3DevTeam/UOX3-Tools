using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace CharacterExporter
{
	public enum KeepItemsState
	{
		KEEP_ALL		= 0,
		KEEP_NONE		= 1,
		KEEP_WEARABLES	= 2,
		KEEP_PACKITEMS	= 3
	};

    public partial class CharacterViewer : Form
    {
        public CharacterViewer()
        {
            InitializeComponent();
			worldFiles			= new ArrayList();
			worldObjects		= new ObjectHandler();
			keepItemState		= KeepItemsState.KEEP_ALL;
			radioAll.Checked	= true;
			worldHasChanged		= false;
			totalItems			= 0;
			totalChars			= 0;
			exportAllToolStripMenuItem.Checked = true;
        }

        private void txtDirPath_TextChanged(object sender, EventArgs e)
        {
			folderBrowserDialog.SelectedPath	= txtDirPath.Text;
			fileBrowserDialog.InitialDirectory	= txtDirPath.Text;
        }

        private void comboCharList_SelectedIndexChanged(object sender, EventArgs e)
        {
			UpdateItemList();
		}

        private void btnImport_Click(object sender, EventArgs e)
        {
			ImportCharacters();
		}

        private void btnExport_Click(object sender, EventArgs e)
        {
			ExportCharacters();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			SaveWorld();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
			OpenBrowseWindow();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
			CloseButton();
        }

		private void radioAll_CheckedChanged(object sender, EventArgs e)
		{
			ChangeExportSetting( KeepItemsState.KEEP_ALL );
			exportAllToolStripMenuItem.Checked = true;

			exportNoneToolStripMenuItem.Checked = false;
			exportWearablesToolStripMenuItem.Checked = false;
			exportPackItemsToolStripMenuItem.Checked = false;
		}

		private void radioNone_CheckedChanged(object sender, EventArgs e)
		{
			ChangeExportSetting( KeepItemsState.KEEP_NONE );
			exportNoneToolStripMenuItem.Checked = true;

			exportAllToolStripMenuItem.Checked = false;
			exportWearablesToolStripMenuItem.Checked = false;
			exportPackItemsToolStripMenuItem.Checked = false;
		}

		private void radioWearables_CheckedChanged(object sender, EventArgs e)
		{
			ChangeExportSetting( KeepItemsState.KEEP_WEARABLES );
			exportWearablesToolStripMenuItem.Checked = true;

			exportAllToolStripMenuItem.Checked = false;
			exportNoneToolStripMenuItem.Checked = false;
			exportPackItemsToolStripMenuItem.Checked = false;
		}

		private void radioPack_CheckedChanged(object sender, EventArgs e)
		{
			ChangeExportSetting( KeepItemsState.KEEP_PACKITEMS );
			exportPackItemsToolStripMenuItem.Checked = true;

			exportAllToolStripMenuItem.Checked = false;
			exportNoneToolStripMenuItem.Checked = false;
			exportWearablesToolStripMenuItem.Checked = false;
		}

		private void openWorldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenBrowseWindow();
		}

		private void saveWorldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveWorld();
		}

		private void exportSelecToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExportCharacters();
		}

		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ImportCharacters();
		}

		private void exportAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			radioAll.Checked = true;
		}

		private void exportNoneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			radioNone.Checked = true;
		}

		private void exportWearablesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			radioWearables.Checked = true;
		}

		private void exportPackItemsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			radioPack.Checked = true;
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CloseButton();
		}

		private void ChangeExportSetting(KeepItemsState newVal)
		{
			if (keepItemState != newVal)
			{
				keepItemState = newVal;
				UpdateItemList();
			}
		}

		private void CheckItemsInCont(WorldObject mObj, bool cChange)
		{
			foreach (ItemObject mItem in mObj.ContainsList)
			{
				if (cChange)
				{
					mItem.Container = mObj.Serial;
					UOXData.Script.TagDataPair contTag = mItem.Section.GetDataPair("Cont");
					contTag.Data = new UOXData.Script.DataValue(mObj.SerString);
				}
				bool contChanged = false;
				if (mItem.Serial < worldObjects.NextItemSer)
				{
					contChanged = true;
					mItem.Serial = worldObjects.NextItemSer;
					mItem.SerString = UOXData.Conversion.ToHexString(mItem.Serial);
					UOXData.Script.TagDataPair serTag = mItem.Section.GetDataPair("Serial");
					serTag.Data = new UOXData.Script.DataValue(mItem.SerString);
					++worldObjects.NextItemSer;
				}
				CheckItemsInCont(mItem, contChanged);
				worldObjects.ItemList.Add(mItem);
			}
		}

		private void CloseButton()
		{
			if (!worldHasChanged || MessageBox.Show("All unsaved changes to your worldfile will be lost if you close, Continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Close();
			}
		}

		private void ExportCharacters()
		{
			if (comboCharList.Items.Count > 0 && comboCharList.SelectedIndices.Count > 0)
			{
				folderBrowserDialog.Description = "Select the Location to Export your character(s) to.";
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					progressBar.Value = 0;
					progressBar.Maximum = comboCharList.SelectedIndices.Count;
					foreach (int mSelection in comboCharList.SelectedIndices)
					{
						CharObject mChar = (CharObject)worldObjects.CharList[mSelection];
						if (mChar != null)
						{
							string fileName = mChar.Name + "_" + mChar.SerString + ".cef";
							string filePath = folderBrowserDialog.SelectedPath + "\\" + fileName;

							StreamWriter fileOut = File.CreateText(filePath);
							mChar.Section.Save(fileOut);
							if (keepItemState != KeepItemsState.KEEP_NONE)
								SaveItemsInCont(mChar, fileOut);
							fileOut.Close();
							progressBar.PerformStep();
						}
					}
				}
			}
		}

		private void ImportCharacters()
		{
			bool selectFirst = false;
			if (comboCharList.Items.Count == 0)
				selectFirst = true;

			fileBrowserDialog.Filter = "Character Export Files (*.cef)|*.cef|All Files (*.*)|*.*";
			if (fileBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				progressBar.Maximum = fileBrowserDialog.FileNames.Length;
				progressBar.Value = 0;

				foreach (string filePath in fileBrowserDialog.FileNames)
				{
					if (File.Exists(filePath))
					{
						UOXData.Script.WorldFile90 importWorld = new UOXData.Script.WorldFile90(filePath);
						if (importWorld.Sections.Count > 0)
						{
							LoadWorldFile(importWorld, true);
							worldFiles.Add(importWorld);
						}
					}
					progressBar.PerformStep();
				}

				if (worldObjects.ImportCharList.Count > 0)
				{
					worldHasChanged = true;
					UpdateTotalValues();

					progressBar.Maximum = worldObjects.ImportCharList.Count + worldObjects.ImportItemList.Count;
					progressBar.Value = 0;

					foreach (ItemObject mItem in worldObjects.ImportItemList)
					{
						WorldObject mObj = worldObjects.FindObjectBySerial(mItem.Container, true);
						if (mObj != null)
							mObj.ContainsList.Add(mItem);
						progressBar.PerformStep();
					}
					foreach (CharObject mChar in worldObjects.ImportCharList)
					{
						bool contChanged = false;
						if (mChar.Serial < worldObjects.NextCharSer)
						{
							contChanged = true;
							mChar.Serial = worldObjects.NextCharSer;
							mChar.SerString = UOXData.Conversion.ToHexString(mChar.Serial);
							UOXData.Script.TagDataPair serTag = mChar.Section.GetDataPair("Serial");
							serTag.Data = new UOXData.Script.DataValue(mChar.SerString);
							++worldObjects.NextCharSer;
						}
						CheckItemsInCont(mChar, contChanged);
						worldObjects.CharList.Add(mChar);
						comboCharList.Items.Add(mChar.Name + " (" + mChar.SerString + ")");
						progressBar.PerformStep();
					}
				}
				worldObjects.ImportCharList.Clear();
				worldObjects.ImportItemList.Clear();

				if (selectFirst)
				{
					if (comboCharList.Items.Count > 0)
						comboCharList.SelectedIndex = 0;
					else
					{
						dataGridItems.Rows.Clear();
						dataGridItems.Rows.Add("Character File Imported: No Characters to Display");
					}
				}
			}
		}

		private void ListItemsInCont(WorldObject mCont)
		{
			bool listAll = (mCont.ObjType == ObjectType.OT_ITEM);
			foreach (ItemObject mItem in mCont.ContainsList)
			{
				if (listAll || keepItemState != KeepItemsState.KEEP_PACKITEMS || mItem.ContainsList.Count > 0)
					dataGridItems.Rows.Add(mItem.Name, UOXData.Conversion.ToHexString(mItem.ID), mItem.SerString);
				if (listAll || keepItemState != KeepItemsState.KEEP_WEARABLES)
					ListItemsInCont(mItem);
			}
		}

		private void LoadWorldFile(UOXData.Script.WorldFile90 toAdd, bool doImport)
		{
			foreach (UOXData.Script.WorldSection mScript in toAdd.Sections)
			{
				if (mScript.SectionName == "CHARACTER")
				{
					uint charSerial = UOXData.Conversion.ToUInt32(mScript.FindTag("Serial"));
					if (charSerial > worldObjects.NextCharSer)
						worldObjects.NextCharSer = charSerial + 1;
					CharObject mChar = new CharObject(charSerial);
					mChar.SerString = UOXData.Conversion.ToHexString(charSerial);
					mChar.Name = mScript.FindTag("Name");
					mChar.ID = UOXData.Conversion.ToUInt16(mScript.FindTag("ID"));
					mChar.Section = mScript;
					if (doImport)
						worldObjects.ImportCharList.Add(mChar);
					else
						worldObjects.CharList.Add(mChar);
					++totalChars;
				}
				else
				{
					uint contSerial = UOXData.Conversion.ToUInt32(mScript.FindTag("Cont"));
					uint itemSerial = UOXData.Conversion.ToUInt32(mScript.FindTag("Serial"));
					if (itemSerial >= worldObjects.NextItemSer)
						worldObjects.NextItemSer = itemSerial + 1;
					if (contSerial != 0xFFFFFFFF)
					{
						ItemObject mItem = new ItemObject(itemSerial);
						mItem.Container = contSerial;
						mItem.SerString = UOXData.Conversion.ToHexString(itemSerial);
						mItem.Name = mScript.FindTag("Name");
						mItem.Section = mScript;
						mItem.ID = UOXData.Conversion.ToUInt16(mScript.FindTag("ID"));
						if (doImport)
							worldObjects.ImportItemList.Add(mItem);
						else
							worldObjects.ItemList.Add(mItem);
					}
					++totalItems;
				}
			}
		}

		private void UpdateTotalValues()
		{
			txtTotalChars.Text = "Characters: " + totalChars.ToString();
			txtTotalItems.Text = "Items: " + totalItems.ToString();

			txtTotalChars.Update();
			txtTotalItems.Update();
		}

		private void OpenBrowseWindow()
		{
			folderBrowserDialog.Description = "Please Select the UOX3 Save File Directory to Load.";
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				string dirPath = folderBrowserDialog.SelectedPath;
				worldFiles.Clear();
				worldObjects.Clear();
				comboCharList.Items.Clear();
				dataGridItems.Rows.Clear();
				totalItems = 0;
				totalChars = 0;
				txtDirPath.Text = dirPath;
				UpdateTotalValues();

				comboCharList.Update();
				dataGridItems.Update();
				txtDirPath.Update();

				string[] fileList = Directory.GetFiles(dirPath, "*.*.wsc");
				if (fileList.Length > 0)
				{
					progressBar.Value = 0;
					foreach (string mFile in fileList)
					{
						UOXData.Script.WorldFile90 toAdd = new UOXData.Script.WorldFile90(mFile);
						LoadWorldFile(toAdd, false);
						worldFiles.Add(toAdd);
					}
					UpdateTotalValues();

					progressBar.Maximum = worldObjects.CharList.Count + worldObjects.ItemList.Count;
					foreach (CharObject mChar in worldObjects.CharList)
					{
						comboCharList.Items.Add(mChar.Name + " (" + mChar.SerString + ")");
						progressBar.PerformStep();
					}
					foreach (ItemObject mItem in worldObjects.ItemList)
					{
						WorldObject mObj = worldObjects.FindObjectBySerial(mItem.Container, false);
						if (mObj != null)
							mObj.ContainsList.Add(mItem);
						progressBar.PerformStep();
					}

					if (comboCharList.Items.Count > 0)
						comboCharList.SelectedIndex = 0;
					else
						dataGridItems.Rows.Add("World Loaded: No Characters to Display");
				}
				else
					MessageBox.Show("No worldfile found, please select a valid directory", "File Not Found");
			}
		}

		private void SaveItemsInCont(WorldObject mCont, StreamWriter fileOut)
		{
			bool saveAll = (mCont.ObjType == ObjectType.OT_ITEM);
			foreach (ItemObject mItem in mCont.ContainsList)
			{
				if (saveAll || keepItemState != KeepItemsState.KEEP_PACKITEMS || mItem.ContainsList.Count > 0)
					mItem.Section.Save(fileOut);
				if (saveAll || keepItemState != KeepItemsState.KEEP_WEARABLES)
					SaveItemsInCont(mItem, fileOut);
			}
		}

		private void SaveWorld()
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = folderBrowserDialog.SelectedPath + "\\0.0.wsc";

				StreamWriter fileOut = File.CreateText(filePath);
				foreach (UOXData.Script.WorldFile90 mWorld in worldFiles)
				{
					mWorld.Save(fileOut);
				}
				fileOut.Close();
				MessageBox.Show("Successfully saved as 0.0.wsc", "Success");

				worldHasChanged = false;
			}
		}

		private void UpdateItemList()
		{
			if (comboCharList.Items.Count == 0)
				return;

			dataGridItems.Rows.Clear();

			if (keepItemState != KeepItemsState.KEEP_NONE)
			{
				foreach (int selSlot in comboCharList.SelectedIndices)
				{
					CharObject mChar = (CharObject)worldObjects.CharList[selSlot];
					if (mChar != null)
						ListItemsInCont(mChar);
				}
			}

			if (dataGridItems.Rows.Count == 0)
				dataGridItems.Rows.Add("No items will be exported with this character.");
		}
    }
}
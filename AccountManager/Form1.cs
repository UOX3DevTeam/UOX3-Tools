using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace AccountManager
{
	public partial class AccountManager : Form
	{
		private AccountObject selAcct;

		public AccountManager()
		{
			InitializeComponent();
			accountList = new List<AccountObject>();
			myForm		= new CharacterEditor();
			selAcct		= null;
			nextAcct	= 0;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnEditChar_Click(object sender, EventArgs e)
		{
			if( myForm.Visible )
				myForm.Activate();
			else
				myForm.Show();

			if( listAccounts.SelectedIndex > -1 )
			{
				myForm.UpdateList( accountList[listAccounts.SelectedIndex] );
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			folderBrowserDialog.Description = "Please Select the UOX3 Accounts Directory to Load.";
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				string dirPath = folderBrowserDialog.SelectedPath + "\\accounts.adm";
				accountList.Clear();
				listAccounts.Items.Clear();
				txtAccountsDir.Text = folderBrowserDialog.SelectedPath;
				listAccounts.Update();
				txtAccountsDir.Update();

				progressBar.Minimum = 0;
				if( File.Exists( dirPath ) )
				{
					progressBar.Value = 1;
					UOXData.Script.AccountScript mScript = new UOXData.Script.AccountScript( dirPath );
					progressBar.Maximum = mScript.Sections.Count;
					foreach (UOXData.Script.AccountSection mSect in mScript.Sections)
					{
						ushort acctNum = UOXData.Conversion.ToUInt16( mSect.SectionName );
						if( acctNum >= nextAcct )
							nextAcct = (ushort)(acctNum + 1);
						AccountObject toAdd = new AccountObject( acctNum );
						foreach( UOXData.Script.TagDataPair mPair in mSect.TagDataPairs )
						{
							string mTag		= mPair.Tag.ToUpper();
							string mData	= mPair.Data;

							switch( mTag )
							{
								case "NAME":
									toAdd.Name = mData;
									break;
								case "PASS":
									toAdd.Pass = mData;
									break;
								case "FLAGS":
									toAdd.Flags = UOXData.Conversion.ToUInt16( mData );
									break;
								case "PATH":
									toAdd.Path = mData;
									break;
								case "CONTACT":
									toAdd.Contact = mData;
									break;
								case "TIMEBAN":
									toAdd.TimeBan = UOXData.Conversion.ToUInt32( mData );
									break;
								case "CHARACTER-1":
								case "CHARACTER-2":
								case "CHARACTER-3":
								case "CHARACTER-4":
								case "CHARACTER-5":
								case "CHARACTER-6":
									string [] tagSplit	= mTag.Split( '-' );
									byte charNum		= (byte)(UOXData.Conversion.ToUInt08( tagSplit[1] ) - 1);
									SlotObject mSlot	= toAdd.CharSlots[charNum];

									string[] dataSplit	= mData.Split(' ');
									mSlot.Serial		= UOXData.Conversion.ToUInt32( dataSplit[0] );
									if( dataSplit[1].Length > 0 )
										mSlot.Name		= dataSplit[1].Substring( 1, dataSplit[1].Length - 2 );
									break;
								default:
									break;
							}
						}
						accountList.Add( toAdd );
						listAccounts.Items.Add( toAdd.Name + " (" + mSect.SectionName + ")" );
						progressBar.PerformStep();
					}

					if( listAccounts.Items.Count > 0 )
						listAccounts.SelectedIndex = 0;
					else
						listAccounts.Items.Add("No Accounts to Display");
				}
				else
					MessageBox.Show("Accounts.adm not found, please select a valid directory", "File Not Found");
			}
		}

		private void txtAccountsDir_TextChanged(object sender, EventArgs e)
		{
			folderBrowserDialog.SelectedPath = txtAccountsDir.Text;
		}

		private void listAccounts_SelectedIndexChanged(object sender, EventArgs e)
		{
			selAcct = null;
			cbPublic.Checked	= false;
			rdBanned.Checked	= false;
			rdSuspended.Checked = false;
			rdPlayer.Checked	= true;

			if( listAccounts.SelectedIndex == -1 )
			{
				txtName.Clear();
				txtPass.Clear();
				txtPath.Clear();
				txtContact.Clear();
				txtTimeban.Clear();
				return;
			}

			selAcct			= accountList[listAccounts.SelectedIndex];
			txtName.Text	= selAcct.Name;
			txtPass.Text	= selAcct.Pass;
			txtPath.Text	= selAcct.Path;
			txtContact.Text = selAcct.Contact;
			txtTimeban.Text = selAcct.TimeBan.ToString();
			if( selAcct.GetFlag( 0x0004 ) )
				cbPublic.Checked = true;

			if( selAcct.GetFlag( 0x8000 ) )
				rdGM.Checked = true;
			else if( selAcct.GetFlag( 0x4000 ) )
				rdCns.Checked = true;
			else if( selAcct.GetFlag( 0x2000 ) )
				rdSeer.Checked = true;

			if( selAcct.GetFlag( 0x0001 ) )
				rdBanned.Checked = true;
			else if( selAcct.GetFlag( 0x0002 ) )
				rdSuspended.Checked = true;

			if( myForm.Visible )
				myForm.UpdateList( selAcct );
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			if( selAcct != null && txtName.Text.Length > 0 )
				selAcct.Name = txtName.Text;
		}

		private void txtPass_TextChanged(object sender, EventArgs e)
		{
			if( selAcct != null && txtPass.Text.Length > 0 )
				selAcct.Pass = txtPass.Text;
		}

		private void txtPath_TextChanged(object sender, EventArgs e)
		{
			if( selAcct != null )
				selAcct.Path = txtPath.Text;
		}

		private void txtContact_TextChanged(object sender, EventArgs e)
		{
			if( selAcct != null )
				selAcct.Contact = txtContact.Text;
		}

		private void txtTimeban_TextChanged(object sender, EventArgs e)
		{
			if( selAcct != null )
				selAcct.TimeBan = UOXData.Conversion.ToUInt32( txtTimeban.Text );
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			accountList.Add( new AccountObject( nextAcct ) );
			listAccounts.Items.Add("NewAccount (" + nextAcct.ToString() + ")");
			listAccounts.SelectedIndex = listAccounts.Items.Count-1;
			++nextAcct;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if( selAcct != null )
			{
				if( selAcct.Number == (ushort)(nextAcct-1) )
					--nextAcct;
				int index = listAccounts.SelectedIndex;
				listAccounts.Items.RemoveAt( index );
				accountList.Remove( selAcct );

				if( index > 0 )
					listAccounts.SelectedIndex = index-1 ;
				else if( listAccounts.Items.Count > 0 )
					listAccounts.SelectedIndex = 0;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			folderBrowserDialog.Description = "Please Select the a Directory to Save the Accounts.adm file to.";
			if( folderBrowserDialog.ShowDialog() == DialogResult.OK )
			{
				string filePath		= folderBrowserDialog.SelectedPath + "\\accounts.adm";
				progressBar.Minimum = 0;
				progressBar.Value	= 1;
				progressBar.Maximum = accountList.Count;
				StreamWriter ioStream = new StreamWriter(filePath);
				foreach( AccountObject mAcct in accountList )
				{
					mAcct.Save( ioStream );
					progressBar.PerformStep();
				}
				ioStream.Close();
			}
		}

		private void rdGM_CheckedChanged(object sender, EventArgs e)
		{
			if( selAcct != null )
				selAcct.SetFlag( 0x8000, rdGM.Checked );
		}

		private void rdCns_CheckedChanged(object sender, EventArgs e)
		{
			if( selAcct != null )
				selAcct.SetFlag( 0x4000, rdCns.Checked );
		}

		private void rdSeer_CheckedChanged(object sender, EventArgs e)
		{
			if( selAcct != null )
				selAcct.SetFlag( 0x2000, rdSeer.Checked );
		}

		private void rdBanned_CheckedChanged(object sender, EventArgs e)
		{
			if( selAcct != null )
				selAcct.SetFlag( 0x0001, rdBanned.Checked );
		}

		private void rdSuspended_CheckedChanged(object sender, EventArgs e)
		{
			if( selAcct != null )
				selAcct.SetFlag( 0x0002, rdSuspended.Checked );
		}

		private void cbPublic_CheckedChanged(object sender, EventArgs e)
		{
			if( selAcct != null )
				selAcct.SetFlag( 0x0004, cbPublic.Checked );
		}
	}
}
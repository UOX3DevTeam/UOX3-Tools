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
			accountList = new Dictionary< string, AccountObject>();
			myForm		= new CharacterEditor();
			selAcct		= null;
			nextAcct	= 0;
			numAccts	= 0;
			numPlayers	= 0;
			numBans		= 0;
			UpdateStats();
		}

		private void UpdateStats()
		{
			txtAccountStats.Text	= "Accounts: " + numAccts.ToString();
			txtBanStats.Text		= "Bans: " + numBans.ToString();
			txtPlayerStats.Text		= "Players: " + numPlayers.ToString();
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
				myForm.UpdateList(accountList[listAccounts.SelectedItem.ToString().Split(' ')[0]]);
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			fldrAccounts.Description = "Please Select the UOX3 Accounts Directory to Load.";
			if (fldrAccounts.ShowDialog() == DialogResult.OK)
			{
				string dirPath = fldrAccounts.SelectedPath + "\\accounts.adm";
				accountList.Clear();
				listAccounts.Items.Clear();
				if( myForm.Visible )
					myForm.Clear();
				txtAccountsDir.Text = fldrAccounts.SelectedPath;
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
							nextAcct = acctNum + 1;
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

									if( mSlot.Serial != 0xFFFFFFFF )
										++numPlayers;
									break;
								default:
									break;
							}
						}
						if( toAdd.GetFlag( 0x0001 ) )
							++numBans;
						accountList.Add( toAdd.Name, toAdd );
						++numAccts;
						listAccounts.Items.Add( toAdd.Name + " (" + mSect.SectionName + ")" );
						progressBar.PerformStep();
					}

					LoadOrphans();

					UpdateStats();

					if (listAccounts.Items.Count > 0)
						listAccounts.SelectedIndex = 0;
					else
						listAccounts.Items.Add("No Accounts to Display");
				}
				else
					MessageBox.Show("Accounts.adm not found, please select a valid directory", "File Not Found");
			}
		}

		private void LoadOrphans()
		{
			string orphPath = fldrAccounts.SelectedPath + "\\orphans.adm";
			if( File.Exists( orphPath ) )
			{
				AccountObject tmpAccount;
				FileStream toRead		= File.OpenRead( orphPath );
				StreamReader ioStream	= new StreamReader( toRead );
				string curLine			= "";
				while( curLine != null )
				{
					curLine = ioStream.ReadLine();
					if( curLine != null && curLine != "" )
					{
						if( curLine != "" && !curLine.StartsWith( "//" ) )
						{
							string [] split	= curLine.Split( '=' );
							string tag		= split[0];
							if( tag.Length > 0 && accountList.ContainsKey( tag ) )
							{
								tmpAccount = accountList[tag];
								string data		= "";
								for( int i = 1; i < split.Length; ++i )
								{
									if( i > 1 )
										data += " ";
										data += split[i];
								}
								data = UOXData.Conversion.TrimCommentAndWhitespace( data );
								string [] dSplit = data.Split( ',' );
								if( dSplit.Length > 4 )
									tmpAccount.OrphanChars.Add(new OrphanObject(dSplit[1], UOXData.Conversion.ToUInt32(dSplit[0]), UOXData.Conversion.ToUInt16( dSplit[2] ), UOXData.Conversion.ToUInt16( dSplit[3] ), UOXData.Conversion.ToInt08( dSplit[4] )));
							}
						}
					}
				}
				toRead.Close();
			}
		}

		private void txtAccountsDir_TextChanged(object sender, EventArgs e)
		{
			fldrAccounts.SelectedPath = txtAccountsDir.Text;
		}

		private void listAccounts_SelectedIndexChanged(object sender, EventArgs e)
		{
			selAcct				= null;
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
				if( myForm.Visible )
					myForm.Clear();
				return;
			}

			AccountObject tmpAcct	= accountList[listAccounts.SelectedItem.ToString().Split( ' ' )[0]];
			txtName.Text			= tmpAcct.Name;
			txtPass.Text			= tmpAcct.Pass;
			txtPath.Text			= tmpAcct.Path;
			txtContact.Text			= tmpAcct.Contact;
			txtTimeban.Text			= tmpAcct.TimeBan.ToString();
			if( tmpAcct.GetFlag( 0x0004 ) )
				cbPublic.Checked = true;

			if( tmpAcct.GetFlag( 0x8000 ) )
				rdGM.Checked = true;
			else if( tmpAcct.GetFlag( 0x4000 ) )
				rdCns.Checked = true;
			else if( tmpAcct.GetFlag( 0x2000 ) )
				rdSeer.Checked = true;

			if( tmpAcct.GetFlag( 0x0001 ) )
				rdBanned.Checked = true;
			else if( tmpAcct.GetFlag( 0x0002 ) )
				rdSuspended.Checked = true;

			if( myForm.Visible )
				myForm.UpdateList( tmpAcct );

			selAcct = tmpAcct;
		}

		private void txtName_LostFocus( object sender, EventArgs e )
		{
			if( selAcct != null && txtName.Text.Length > 0 )
				listAccounts.Items[listAccounts.SelectedIndex] = txtName.Text + " (" + selAcct.Number + ")";
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
			if( nextAcct >= 0xFFFF )
			{
				MessageBox.Show("Error: UOX3 Only Supports Accounts with numbers 0-65534!", "Failure");
				return;
			}

			AccountObject newAcct = new AccountObject( nextAcct );
			string name = "guest" + nextAcct.ToString();
			if( nextAcct == 0 )
			{
				name = "admin";
				newAcct.SetFlag( 0x8000, true );
			}

			newAcct.Name = name;
			newAcct.Pass = name;
			accountList.Add( name, newAcct );
			listAccounts.Items.Add( name + " (" + nextAcct.ToString() + ")" );
			listAccounts.SelectedIndex = listAccounts.Items.Count-1;
			++nextAcct;
			++numAccts;

			UpdateStats();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if( selAcct != null )
			{
				if( selAcct.GetFlag( 0x0001 ) )
					--numBans;
				foreach( SlotObject mSlot in selAcct.CharSlots )
				{
					if( mSlot.Serial != 0xFFFFFFFF )
						--numPlayers;
				}
				--numAccts;

				if( selAcct.Number == (nextAcct - 1) )
					--nextAcct;
				int index = listAccounts.SelectedIndex;
				accountList.Remove( selAcct.Name );
				listAccounts.Items.RemoveAt( index );

				if( index > 0 )
					listAccounts.SelectedIndex = index-1 ;
				else if( listAccounts.Items.Count > 0 )
					listAccounts.SelectedIndex = 0;


				UpdateStats();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if( accountList.Count == 0 )
			{
				MessageBox.Show( "Error: Unable to save Accounts.adm, there are no accounts to save!", "Failure" );
				return;
			}
			fldrAccounts.Description = "Please Select the a Directory to Save the Accounts.adm file to.";
			if( fldrAccounts.ShowDialog() == DialogResult.OK )
			{
				Dictionary<string, List<OrphanObject>> tmpOrphans = new Dictionary<string, List<OrphanObject>>();
				int invalidCount	= 0;
				string filePath		= fldrAccounts.SelectedPath + "\\accounts.adm";
				progressBar.Minimum = 0;
				progressBar.Value	= 1;
				progressBar.Maximum = accountList.Count;
				StreamWriter ioStream = new StreamWriter(filePath);
				foreach( AccountObject mAcct in accountList.Values )
				{
					if( !mAcct.Save( ioStream ) )
						++invalidCount;
					else
						tmpOrphans.Add( mAcct.Name, mAcct.OrphanChars );

					progressBar.PerformStep();
				}
				ioStream.Close();

				SaveOrphans( tmpOrphans );

				if( invalidCount > 0 )
					MessageBox.Show( "Unable to save " + invalidCount.ToString() + " invalid accounts, check that all accounts have a name and password entry and are numbered below 65535.", "Warning" );
			}
		}

		private void SaveOrphans(Dictionary<string, List<OrphanObject>> tmpOrphans)
		{
			string filePath		= fldrAccounts.SelectedPath + "\\orphans.adm";
			StreamWriter ioStream = new StreamWriter( filePath );
			foreach (KeyValuePair<string, List<OrphanObject>> mKey in tmpOrphans)
			{
				foreach (OrphanObject mSlot in mKey.Value)
				{
					ioStream.WriteLine(mKey.Key + "=" + mSlot.Name + "," + UOXData.Conversion.ToHexString(mSlot.Serial) + "," + mSlot.X.ToString() + "," + mSlot.Y.ToString() + "," + mSlot.Z.ToString());
				}
			}
			ioStream.WriteLine();
			ioStream.Flush();
			ioStream.Close();
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
			{
				selAcct.SetFlag( 0x0001, rdBanned.Checked );
				if( rdBanned.Checked )
					++numBans;
				else
					--numBans;
			}

			UpdateStats();
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

		private void btnRenumber_Click(object sender, EventArgs e)
		{
			if( accountList.Count == 0 )
			{
				MessageBox.Show("Error: There are no accounts to re-number!", "Failure");
				return;
			}
			if( MessageBox.Show( "Do you really want to re-number all of your accounts sequentially?", "Confirmation", MessageBoxButtons.YesNo ) == DialogResult.Yes )
			{
				listAccounts.Items.Clear();
				progressBar.Value	= 1;
				progressBar.Maximum = accountList.Count;
				int i				= 1;
				foreach( AccountObject mAcct in accountList.Values )
				{
					if( mAcct.Number != 0 )
					{
						mAcct.Number = i;
						++i;
					}
					string name;
					if( mAcct.Name.Length > 0 )
						name = mAcct.Name;
					else
					{
						if( mAcct.Number == 0 )
							name = "AdminAccount";
						else
							name = "NewAccount";
					}
					listAccounts.Items.Add( name + " (" + mAcct.Number.ToString() + ")" );
					progressBar.PerformStep();
				}

				if( listAccounts.Items.Count > 0 )
					listAccounts.SelectedIndex = 0;

				nextAcct = i;
			}
		}

		private void btnPath_Click(object sender, EventArgs e)
		{
			if( txtPath.Text.Length > 0 )
				fldrPath.SelectedPath = Path.GetFullPath( txtPath.Text );
			fldrPath.Description = "Please Select the Subfolder for this Account.";
			if (fldrPath.ShowDialog() == DialogResult.OK)
			{
				txtPath.Text = fldrPath.SelectedPath.Replace( "\\", "/" )+ "/";
			}
		}
	}
}
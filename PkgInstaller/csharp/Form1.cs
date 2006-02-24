using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using ICSCZL = ICSharpCode.SharpZipLib;

namespace PkgInstaller
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmPkgInstaller : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listDFNCategories;
		private System.Windows.Forms.Label lblUOX3Ini;
		private System.Windows.Forms.OpenFileDialog opnFileDialog;
		private System.Windows.Forms.TextBox txtUOX3Ini;
		private System.Windows.Forms.Button cmdUOX3IniFind;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.ListBox listDirectories;
		private System.Windows.Forms.Label lblPackageDetails;
		private System.Windows.Forms.Label lblPackageFiles;
		private System.Windows.Forms.ListBox listPackageFiles;
		private System.Windows.Forms.Button cmdSelectPackage;
		private System.Windows.Forms.TextBox txtPackageDetails;
		private System.Windows.Forms.ProgressBar progressReading;
		private System.Windows.Forms.Button cmdInstallPackage;
		protected UOXData.Script.Script iniScript	= null;
		protected UOXData.Script.Script setupInfo	= null;
		protected ICSCZL.Zip.ZipFile zipFile		= null;
		protected string dfnPath					= "";
		protected string currentZip					= "";
		protected SetupInfo pkgConfig				= null;
		protected Package mPackage					= null;

		public frmPkgInstaller()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listDFNCategories = new System.Windows.Forms.ListBox();
			this.lblUOX3Ini = new System.Windows.Forms.Label();
			this.opnFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.txtUOX3Ini = new System.Windows.Forms.TextBox();
			this.cmdUOX3IniFind = new System.Windows.Forms.Button();
			this.listDirectories = new System.Windows.Forms.ListBox();
			this.cmdSelectPackage = new System.Windows.Forms.Button();
			this.lblPackageDetails = new System.Windows.Forms.Label();
			this.txtPackageDetails = new System.Windows.Forms.TextBox();
			this.lblPackageFiles = new System.Windows.Forms.Label();
			this.listPackageFiles = new System.Windows.Forms.ListBox();
			this.progressReading = new System.Windows.Forms.ProgressBar();
			this.cmdInstallPackage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listDFNCategories
			// 
			this.listDFNCategories.Location = new System.Drawing.Point(8, 8);
			this.listDFNCategories.Name = "listDFNCategories";
			this.listDFNCategories.Size = new System.Drawing.Size(160, 108);
			this.listDFNCategories.TabIndex = 0;
			this.listDFNCategories.SelectedIndexChanged += new System.EventHandler(this.listDFNCategories_SelectedIndexChanged);
			// 
			// lblUOX3Ini
			// 
			this.lblUOX3Ini.Location = new System.Drawing.Point(8, 416);
			this.lblUOX3Ini.Name = "lblUOX3Ini";
			this.lblUOX3Ini.Size = new System.Drawing.Size(64, 16);
			this.lblUOX3Ini.TabIndex = 1;
			this.lblUOX3Ini.Text = "UOX.Ini";
			// 
			// txtUOX3Ini
			// 
			this.txtUOX3Ini.Location = new System.Drawing.Point(80, 416);
			this.txtUOX3Ini.Name = "txtUOX3Ini";
			this.txtUOX3Ini.Size = new System.Drawing.Size(464, 20);
			this.txtUOX3Ini.TabIndex = 2;
			this.txtUOX3Ini.Text = "";
			// 
			// cmdUOX3IniFind
			// 
			this.cmdUOX3IniFind.Location = new System.Drawing.Point(552, 416);
			this.cmdUOX3IniFind.Name = "cmdUOX3IniFind";
			this.cmdUOX3IniFind.TabIndex = 3;
			this.cmdUOX3IniFind.Text = "Find";
			this.cmdUOX3IniFind.Click += new System.EventHandler(this.cmdUOX3IniFind_Click);
			// 
			// listDirectories
			// 
			this.listDirectories.Location = new System.Drawing.Point(8, 128);
			this.listDirectories.Name = "listDirectories";
			this.listDirectories.Size = new System.Drawing.Size(160, 121);
			this.listDirectories.TabIndex = 4;
			// 
			// cmdSelectPackage
			// 
			this.cmdSelectPackage.Location = new System.Drawing.Point(552, 8);
			this.cmdSelectPackage.Name = "cmdSelectPackage";
			this.cmdSelectPackage.Size = new System.Drawing.Size(75, 40);
			this.cmdSelectPackage.TabIndex = 5;
			this.cmdSelectPackage.Text = "Select Package";
			this.cmdSelectPackage.Click += new System.EventHandler(this.cmdSelectPackage_Click);
			// 
			// lblPackageDetails
			// 
			this.lblPackageDetails.Location = new System.Drawing.Point(176, 8);
			this.lblPackageDetails.Name = "lblPackageDetails";
			this.lblPackageDetails.Size = new System.Drawing.Size(100, 16);
			this.lblPackageDetails.TabIndex = 6;
			this.lblPackageDetails.Text = "Package Details";
			// 
			// txtPackageDetails
			// 
			this.txtPackageDetails.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPackageDetails.Location = new System.Drawing.Point(176, 32);
			this.txtPackageDetails.Multiline = true;
			this.txtPackageDetails.Name = "txtPackageDetails";
			this.txtPackageDetails.Size = new System.Drawing.Size(368, 216);
			this.txtPackageDetails.TabIndex = 7;
			this.txtPackageDetails.Text = "";
			// 
			// lblPackageFiles
			// 
			this.lblPackageFiles.Location = new System.Drawing.Point(176, 256);
			this.lblPackageFiles.Name = "lblPackageFiles";
			this.lblPackageFiles.TabIndex = 8;
			this.lblPackageFiles.Text = "Package Files";
			// 
			// listPackageFiles
			// 
			this.listPackageFiles.Location = new System.Drawing.Point(176, 280);
			this.listPackageFiles.Name = "listPackageFiles";
			this.listPackageFiles.Size = new System.Drawing.Size(368, 121);
			this.listPackageFiles.TabIndex = 9;
			this.listPackageFiles.SelectedIndexChanged += new System.EventHandler(this.listPackageFiles_SelectedIndexChanged);
			// 
			// progressReading
			// 
			this.progressReading.Location = new System.Drawing.Point(8, 280);
			this.progressReading.Name = "progressReading";
			this.progressReading.Size = new System.Drawing.Size(160, 16);
			this.progressReading.TabIndex = 10;
			// 
			// cmdInstallPackage
			// 
			this.cmdInstallPackage.Location = new System.Drawing.Point(552, 56);
			this.cmdInstallPackage.Name = "cmdInstallPackage";
			this.cmdInstallPackage.Size = new System.Drawing.Size(75, 40);
			this.cmdInstallPackage.TabIndex = 11;
			this.cmdInstallPackage.Text = "Install Package";
			this.cmdInstallPackage.Click += new System.EventHandler(this.cmdInstallPackage_Click);
			// 
			// frmPkgInstaller
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 446);
			this.Controls.Add(this.cmdInstallPackage);
			this.Controls.Add(this.progressReading);
			this.Controls.Add(this.listPackageFiles);
			this.Controls.Add(this.lblPackageFiles);
			this.Controls.Add(this.txtPackageDetails);
			this.Controls.Add(this.lblPackageDetails);
			this.Controls.Add(this.cmdSelectPackage);
			this.Controls.Add(this.listDirectories);
			this.Controls.Add(this.cmdUOX3IniFind);
			this.Controls.Add(this.txtUOX3Ini);
			this.Controls.Add(this.lblUOX3Ini);
			this.Controls.Add(this.listDFNCategories);
			this.Name = "frmPkgInstaller";
			this.Text = "PkgInstaller";
			this.Load += new System.EventHandler(this.frmPkgInstaller_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmPkgInstaller());
		}

		private void frmPkgInstaller_Load(object sender, System.EventArgs e)
		{
			for( int i = (int)UOXData.Script.DFN_Categories.FIRST_DEF; i < (int)UOXData.Script.DFN_Categories.NUM_DEFS; ++i )
			{
				this.listDFNCategories.Items.Add( ((UOXData.Script.DFN_Categories)i).ToString() );
			}
		}

		private void cmdUOX3IniFind_Click(object sender, System.EventArgs e)
		{
			opnFileDialog.Filter = "INI files (*.ini)|*.ini|All files (*.*)|*.*" ;
			if( opnFileDialog.ShowDialog() == DialogResult.OK )
			{
				txtUOX3Ini.Text	= opnFileDialog.FileName;
				iniScript		= new UOXData.Script.Script( txtUOX3Ini.Text );

				UOXData.Script.ScriptSection dirSect = iniScript.FindSection( "directories" );
				if( dirSect != null )
					dfnPath = dirSect.FindTag( "DEFSDIRECTORY" );
				else
					dfnPath = "";
			}
			else
				txtUOX3Ini.Text = "";
		}

		private void ProcessDirectory( string basePath, string dir )
		{
			if( basePath != dir )
			{
				this.listDirectories.Items.Add( dir.Substring( basePath.Length ) );
			}
			string [] subdirEntries = Directory.GetDirectories( dir );
			foreach( string subdir in subdirEntries )
			{
				// Do not iterate through reparse points
				if( (File.GetAttributes( subdir ) & FileAttributes.ReparsePoint) != FileAttributes.ReparsePoint)
				{
					ProcessDirectory( basePath, subdir );
				}
			}
		}
		private void listDFNCategories_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if( iniScript != null && dfnPath.Length > 0 )
			{	// INI loaded and path found
				string basePath = dfnPath + ((UOXData.Script.DFN_Categories)this.listDFNCategories.SelectedIndex).ToString() + "/";
				this.listDirectories.Items.Clear();
				this.listDirectories.Items.Add( "./" );

				ProcessDirectory( basePath, basePath );
			}
		}

		private void cmdSelectPackage_Click(object sender, System.EventArgs e)
		{
			opnFileDialog.Filter = "Package files (*.zip)|*.zip|All files (*.*)|*.*" ;
			if( opnFileDialog.ShowDialog() == DialogResult.OK )
			{
				listPackageFiles.Items.Clear();
				setupInfo							= null;
				txtPackageDetails.Text				= "";
				currentZip							= opnFileDialog.FileName;
				zipFile								= new ICSCZL.Zip.ZipFile( currentZip );
				System.Collections.IEnumerator blah	= zipFile.GetEnumerator();

				while( blah.MoveNext() )
				{
					this.listPackageFiles.Items.Add( blah.Current );
					ICSCZL.Zip.ZipEntry theEntry = (ICSCZL.Zip.ZipEntry)blah.Current;
					if( theEntry.Name == "readme.txt" )
					{
						int size			= 2048;
						byte[] toDisp		= new byte[2048];
						System.IO.Stream s	= zipFile.GetInputStream( theEntry );
						while( true )
						{
							size = s.Read( toDisp, 0, toDisp.Length );
							if( size > 0 )
							{
								for( int i = 0; i < size; ++i )
									this.txtPackageDetails.Text += (char)toDisp[i];
							}
							else
								break;
						}
					}
					else if( theEntry.Name == "setup.info" )
					{
						System.IO.Stream s	= zipFile.GetInputStream( theEntry );
						setupInfo			= new UOXData.Script.Script( s );
						pkgConfig			= new SetupInfo( iniScript );
						pkgConfig.Parse( setupInfo );
					}
				}
				mPackage = new Package( zipFile, pkgConfig );
				if( setupInfo == null )
				{
					System.Windows.Forms.MessageBox.Show( "Zip file does not contain a setup.info!  Likely an invalid package" );
				}
			}
			else
			{
				currentZip	= "";
				if( zipFile != null )
					zipFile	= null;
				setupInfo	= null;
			}
		}

		private void listPackageFiles_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if( zipFile != null )
			{	// the zip file exists
				ICSCZL.Zip.ZipEntry theEntry	= (ICSCZL.Zip.ZipEntry)this.listPackageFiles.SelectedItem;
				txtPackageDetails.Text			= "";
				int size						= 2048;
				byte[] toDisp					= new byte[2048];
				System.IO.Stream s				= zipFile.GetInputStream( theEntry );
				txtPackageDetails.Visible		= false;
				string building					= "";
				progressReading.Value			= 0;
				progressReading.Maximum			= (int)System.Math.Round(( (float)theEntry.Size / 2048.0f ) + 1.0f);
				while( true )
				{
					size = s.Read( toDisp, 0, toDisp.Length );
					if( size > 0 )
					{
						building = "";
						for( int i = 0; i < size; ++i )
							building += (char)toDisp[i];
						txtPackageDetails.Text += building;
						progressReading.Value++;
					}
					else
						break;
				}
				progressReading.Value		= progressReading.Maximum;
				txtPackageDetails.Visible	= true;
			}
		}

		private void cmdInstallPackage_Click(object sender, System.EventArgs e)
		{
			if( zipFile != null && iniScript != null )
			{	// okay, we have a zip, time to do our install.  Isn't this just grand?
				mPackage.Process();
			}
		}
	}

	public class Package
	{
		protected ICSCZL.Zip.ZipFile zipFile		= null;
		protected SetupInfo pkgConfig				= null;

		protected Hashtable	dfnFiles				= null;
		protected Hashtable	jsFiles					= null;

		private string GetPath( string fullPath )
		{
			int lastIdx = fullPath.LastIndexOf( "\\" );
			if( lastIdx == -1 )
				lastIdx = fullPath.LastIndexOf( "/" );
			if( lastIdx == -1 )
				return "";
			else
				return fullPath.Substring( 0, lastIdx );
		}

		private string GetFile( string fullPath )
		{
			int lastIdx = fullPath.LastIndexOf( "\\" );
			if( lastIdx == -1 )
				lastIdx = fullPath.LastIndexOf( "/" );
			if( lastIdx == -1 )
				return fullPath;
			else
				return fullPath.Substring( lastIdx );
		}

		public Package( ICSCZL.Zip.ZipFile zFile, SetupInfo pkgConfg )
		{
			zipFile		=	zFile;
			pkgConfig	=	pkgConfg;
			dfnFiles	=	new Hashtable();
			jsFiles		=	new Hashtable();
			Parse();
		}

		protected void Parse()
		{
			System.Collections.IEnumerator blah	= zipFile.GetEnumerator();

			while( blah.MoveNext() )
			{
				ICSCZL.Zip.ZipEntry theEntry = (ICSCZL.Zip.ZipEntry)blah.Current;

				if( theEntry.IsFile )
				{	// if it's a file
					string extension = theEntry.Name.Substring( theEntry.Name.LastIndexOf( "." ) );
					if( extension == ".dfn" )
					{	// if it's a definition, let's do something with it
						dfnFiles.Add( theEntry.Name, new UOXData.Script.Script( zipFile.GetInputStream( theEntry ) ) );
					}
					else if( extension == ".js" )
					{	// if it's a JS, time to copy over
						jsFiles.Add( theEntry.Name, ReadString( zipFile.GetInputStream( theEntry ), theEntry.Size ) );
					}
				}
			}
		}
		protected byte[] ReadString( System.IO.Stream s, long mSize )
		{
			byte[] retVal	= new byte[mSize];
			int offset		= 0;
			int readSize	= Math.Min( (int)mSize, 2048 );
			while( true )
			{
				int size = s.Read( retVal, offset, readSize );
				if( size > 0 )
					offset += size;
				else
					break;
			}
			return retVal;
		}
		public void Process()
		{
			pkgConfig.WriteConfigs();

			IDictionaryEnumerator myEnumerator = dfnFiles.GetEnumerator();
			while( myEnumerator.MoveNext() )
			{
				ProcessDFNFile( (UOXData.Script.Script)myEnumerator.Value, (string)myEnumerator.Key );
			}

			myEnumerator = jsFiles.GetEnumerator();
			while( myEnumerator.MoveNext() )
			{
				ProcessJSFile( (byte[])myEnumerator.Value, (string)myEnumerator.Key );
			}
		}

		private void ProcessDFNFile( UOXData.Script.Script myFile, string sName )
		{
			// In each section, check for any SCRIPT tags
			// If we find any, and they're of the format [[x]], replace the x
			// with the valid script number found in the earlier lookup
			foreach( UOXData.Script.ScriptSection mSect in myFile.Sections )
			{
				UOXData.Script.TagDataPair mPair = mSect.GetDataPair( "SCRIPT" );
				if( mPair != null )
				{
					if( mPair.Data.Value.Trim().StartsWith( "[[" ) )
					{	// we have to do the lookup/replacement here ... what fun!
						string mValue		= mPair.Data.Value;
						int startIdx		= mValue.LastIndexOf( "[" );
						int endIdx			= mValue.IndexOf( "]" );
						int toLookup		= UOXData.Conversion.ToInt32( mValue.Substring( startIdx + 1, endIdx - (startIdx + 1) ) );
						mPair.Data.Value	= pkgConfig.GetTranslatedNumber( toLookup ).ToString();
					}
				}
			}
			// OK, we've updated our scripts, isn't this wonderful?
			// Create a new text file with the appropriate name
			// and then pass the stream to myFile.Save()

			string dfnPath		= pkgConfig.DFNPath + pkgConfig.GetDFNSection( sName.Replace( "\\", "/" ) ) + pkgConfig.DirPath;
			string filePath		= GetPath( sName.Replace( "\\", "/" ) );
			string [] paths		= filePath.Split( '/' );
			string buildingPath	= dfnPath;
			if( !Directory.Exists( dfnPath ) )
				Directory.CreateDirectory( dfnPath );
			if( paths.Length > 1 )
			{
				for( int i = 0; i < paths.Length; ++i )
				{
					buildingPath += "/" + paths[i];
					if( !Directory.Exists( buildingPath ) )
						Directory.CreateDirectory( buildingPath );
				}
			}
			System.IO.StreamWriter ioStream = File.CreateText( buildingPath + GetFile( sName ) );
			myFile.Save( ioStream );
			ioStream.Flush();
			ioStream.Close();
		}

		private void ProcessJSFile( byte[] toWrite, string sName )
		{
			// Essentially, this is just a straight copy, no changes need to be made
			string dfnPath		= pkgConfig.JSPath + pkgConfig.GetDFNSection( sName.Replace( "\\", "/" ) ) + pkgConfig.DirPath;
			string filePath		= GetPath( sName.Replace( "\\", "/" ) );
			string [] paths		= filePath.Split( '/' );
			string buildingPath	= dfnPath;
			if( !Directory.Exists( dfnPath ) )
				Directory.CreateDirectory( dfnPath );
			if( paths.Length > 1 )
			{
				for( int i = 0; i < paths.Length; ++i )
				{
					buildingPath += "/" + paths[i];
					if( !Directory.Exists( buildingPath ) )
						Directory.CreateDirectory( buildingPath );
				}
			}
			System.IO.FileStream ioStream = File.Create( buildingPath + GetFile( sName ) );
			ioStream.Write( toWrite, 0, toWrite.Length );
			ioStream.Flush();
			ioStream.Close();
		}
	}

	public class SetupInfo
	{
		protected System.Collections.Hashtable		jsFiles;
		protected System.Collections.ArrayList[]	generalSetup;
		protected System.Collections.ArrayList[]	dfnFiles;
		protected UOXData.Script.Script[]			configScripts;
		protected UOXData.Script.Script				iniFile;
		protected UOXData.Script.ScriptSection		inUse;
		protected string							dfnPath;
		protected string							jsPath;
		protected string							dirPath;

		public string DFNPath	{	get	{ return dfnPath;	}	}
		public string JSPath	{	get { return jsPath;	}	}
		public string DirPath	{	get	{ return dirPath;	}	}

		public void WriteConfigs()
		{
			string [] mLocations = new string[3] { "/jse_fileassociations.scp", "/jse_objectassociations.scp", "/jse_typeassociations.scp" };
			for( int i = 0; i < 3; ++i )
			{
				System.IO.StreamWriter myWriter = File.CreateText( jsPath + mLocations[i] );
				configScripts[i].Save( myWriter );
				myWriter.Close();
			}
		}
		public SetupInfo( UOXData.Script.Script iniScript )
		{
			iniFile	= iniScript;
			dfnPath	= "";
			jsPath	= "";
			UOXData.Script.ScriptSection dirSect = iniScript.FindSection( "directories" );
			if( dirSect != null )
			{
				dfnPath = dirSect.FindTag( "DEFSDIRECTORY" ).Replace( "\\", "/" );
				jsPath	= dirSect.FindTag( "SCRIPTSDIRECTORY" ).Replace( "\\", "/" );
			}
			else
			{
				System.Windows.Forms.MessageBox.Show( "No definitions directory found!" );
				return;
			}

			configScripts		= new UOXData.Script.Script[3];
			configScripts[0]	= new UOXData.Script.Script( jsPath + "/jse_fileassociations.scp" );
			configScripts[1]	= new UOXData.Script.Script( jsPath + "/jse_objectassociations.scp" );
			configScripts[2]	= new UOXData.Script.Script( jsPath + "/jse_typeassociations.scp" );
			jsFiles				= new System.Collections.Hashtable();
			generalSetup		= new System.Collections.ArrayList[6];
			for( int i = 0; i < 6; ++i )
				generalSetup[i] = new System.Collections.ArrayList();

			dfnFiles			= new System.Collections.ArrayList[(int)UOXData.Script.DFN_Categories.NUM_DEFS];
			for( int i = (int)UOXData.Script.DFN_Categories.FIRST_DEF; i < (int)UOXData.Script.DFN_Categories.NUM_DEFS; ++i )
				dfnFiles[i]	= new System.Collections.ArrayList();

			inUse				= new UOXData.Script.ScriptSection();

		}

		public int GetTranslatedNumber( int sourceNum )
		{
			int retVal = -1;
			if( jsFiles.ContainsKey( sourceNum.ToString() ) )
				retVal = (int)jsFiles[sourceNum.ToString()];
			return retVal;
		}

		protected int FindFreeNumber( UOXData.Script.ScriptSection alreadyUsed )
		{
			// This function basically finds a free slot in the list to use
			// Don't want to use potentially reserved areas, so only looking at numbers
			// 6000 and above
			int retVal	= -1;

			UOXData.Script.ScriptSection[] mSection = new UOXData.Script.ScriptSection[7];

			mSection[0] = configScripts[0].FindSection( "COMMAND_SCRIPTS" );
			mSection[1] = configScripts[0].FindSection( "MAGIC_SCRIPTS" );
			mSection[2] = configScripts[0].FindSection( "CONSOLE_SCRIPTS" );
			mSection[3] = configScripts[0].FindSection( "PACKET_SCRIPTS" );
			mSection[4] = configScripts[0].FindSection( "SKILLUSE_SCRIPTS" );
			mSection[5] = configScripts[0].FindSection( "SCRIPT_LIST" );
			mSection[6] = alreadyUsed;

			for( int i = 6000; i < 65535; ++i )
			{
				bool scriptExists = false;
				for( int j = 0; j < 7; ++j )
				{
					if( mSection[j] != null )
					{
						UOXData.Script.TagDataPair t = mSection[j].GetDataPair( i.ToString() );
						if( t != null )
						{
							scriptExists = true;
							break;
						}
					}
				}
				if( !scriptExists )
				{
					retVal = i;
					break;
				}
			}
			return retVal;
		}

		public string GetDFNSection( string fileName )
		{
			for( int i = (int)UOXData.Script.DFN_Categories.FIRST_DEF; i < (int)UOXData.Script.DFN_Categories.NUM_DEFS; ++i )
			{
				System.Collections.ArrayList mList = dfnFiles[i];
				for( int j = 0; j < mList.Count; ++j )
				{
					if( ((UOXData.Script.DataValue)mList[j]).Value == fileName )
					{
						return ((UOXData.Script.DFN_Categories)i).ToString() + "/";
					}
				}
			}
			return "";
		}

		public void Parse( UOXData.Script.Script stpInfo )
		{
			UOXData.Script.ScriptSection mSection	= null;

			mSection = stpInfo.FindSection( "DESCRIPTION" );
			if( mSection != null )
			{
				UOXData.Script.TagDataPair t = mSection.GetDataPair( "DIRECTORY" );
				if( t != null )
				{
					dirPath = t.Data.Value.Replace( "\\", "/" );
					if( dirPath[dirPath.Length - 1] != '/' )
						dirPath += "/";
				}
				else
					dirPath = "custom/";
			}
			else
			{
				dirPath = "custom/";
			}
			// parse the individual DFN sections now and store what goes where
			for( int i = (int)UOXData.Script.DFN_Categories.FIRST_DEF; i < (int)UOXData.Script.DFN_Categories.NUM_DEFS; ++i )
			{
				mSection = stpInfo.FindSection( ((UOXData.Script.DFN_Categories)i).ToString() );
				if( mSection != null )
				{
					foreach( UOXData.Script.TagDataPair t in mSection.TagDataPairs )
					{
						dfnFiles[i].Add( t.Data );
					}
				}
			}
			// Now let's grab the JS file request stuff, and find some free mappings 
			// so that we can update the config files
			mSection = stpInfo.FindSection( "JS_FILES" );
			if( mSection != null )
			{
				foreach( UOXData.Script.TagDataPair t in mSection.TagDataPairs )
				{
					int freeNumber = FindFreeNumber( inUse );
					if( freeNumber != -1 )
					{
						jsFiles.Add( t.Tag, freeNumber );
						inUse.Add( freeNumber.ToString(), t.Data.Value );
					}
				}
			}

			// OK, we've built up our list of free numbers
			// Now let's update the relevant config files
			// with the newly acquired data
			UOXData.Script.ScriptSection tSection	= null;
			string [] sectTypes						= new string[6];
			sectTypes[0]							= "COMMAND";
			sectTypes[1]							= "MAGIC";
			sectTypes[2]							= "CONSOLE";
			sectTypes[3]							= "PACKET";
			sectTypes[4]							= "SKILLUSE";
			sectTypes[5]							= "GENERIC";
			mSection								= stpInfo.FindSection( "CONFIGURE" );
			if( mSection != null )
			{
				for( int i = 0; i < 6; ++i )
				{
					UOXData.Script.TagDataPair t = mSection.GetDataPair( sectTypes[i] );
					if( t != null )
					{
						if( i != 5 )
							tSection = configScripts[0].FindSection( sectTypes + "_SCRIPTS" );
						else
							tSection = configScripts[0].FindSection( "SCRIPT_LIST" );

						string[] values = t.Data.Value.Split( ',' );
						for( int j = 0; j < values.Length; ++j )
						{
							bool containsKey = jsFiles.ContainsKey( values[j].Trim() );
							if( containsKey )
							{
								string tag	= ((int)jsFiles[values[j].Trim()]).ToString();
								string data	= dirPath + inUse.GetDataPair( tag ).Data.Value;
								tSection.Add( tag, data );
							}
						}
					}
				}
			}
			// OK, the file associations config file has been updated
			// Let's do envoke now



			// Let's do type now


		}
	}
}

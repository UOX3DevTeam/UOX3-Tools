// created on 12/02/2003 at 7:16 PM
using System;
using System.IO;
using System.Collections;

namespace UOXData.Script
{

	public enum DFN_Categories
	{
		items		=	0,
		FIRST_DEF	=	0,
		npc			=	1,
		create		=	2,
		regions		=	3,
		misc		=	4,
		skills		=	5,
		location	=	6,
		menus		=	7,
		spells		=	8,
		newbie		=	9,
		titles		=	10,
		advance		=	11,
		house		=	12,
		colors		=	13,
		spawn		=	14,
		html		=	15,
		race		=	16,
		weather		=	17,
		harditems	=	18,
		command		=	19,
		msgboard	=	20,
		carve		=	21,
		creatures	=	22,
		maps		=	23,
		NUM_DEFS	=	24
	};
	public interface ScriptSectionLoadable
	{
		void Load( ScriptSection toLoad );
	}

	public abstract class HasDFNLookup
	{
		protected DefinitionTree dfnTree;
		public HasDFNLookup( DefinitionTree dTree )
		{
			dfnTree = dTree;
		}
	}

	#region "BaseScript"
	public abstract class BaseScript
	{
		protected ArrayList	sectionCollection;
		protected virtual void InternalReset()
		{
		}
		public BaseScript( string targFile )
		{
			sectionCollection = new ArrayList();
			InternalReset();
			Retrieve( targFile );
		}
		public BaseScript( System.IO.Stream toRead )
		{
			sectionCollection = new ArrayList();
			InternalReset();
			Retrieve( toRead );
		}
		public BaseScript()
		{
			sectionCollection = new ArrayList();
			InternalReset();
		}
		public abstract void Retrieve( string targFile );
		public abstract void Retrieve( System.IO.Stream toRead );
		public abstract void Save( StreamWriter ioStream );
		public ArrayList Sections
		{
			get	{	return sectionCollection;	}
		}
		public virtual Section FindSection( string sectionName )
		{
			foreach( Section s in sectionCollection )
			{
				if( s.SectionName == sectionName )
					return s;
			}
			return null;
		}
		public void AddSection( Section toAdd )
		{
			sectionCollection.Add( toAdd );
		}
	}
	#endregion "BaseScript"
	#region "Script"
	public class Script : BaseScript
	{
		protected DFN_Categories	category;
		public Script( string targFile, DFN_Categories mCat ) : base( targFile )
		{
			category = mCat;
		}
		public Script( System.IO.Stream targFile, DFN_Categories mCat ) : base( targFile )
		{
			category = mCat;
		}
		public Script( string targFile ) : base( targFile )
		{
			category = DFN_Categories.NUM_DEFS;
		}
		public Script( System.IO.Stream targFile ) : base( targFile )
		{
			category = DFN_Categories.NUM_DEFS;
		}
		public Script() : base()
		{
			category = DFN_Categories.NUM_DEFS;
		}
		public override void Retrieve( System.IO.Stream toRead )
		{
			StreamReader ioStream	= new StreamReader( toRead );
			string curLine			= "";
			while( curLine != null )
			{
				curLine = ioStream.ReadLine();
				if( curLine != null && curLine != "" )
				{
					if( curLine[0] == '[' )
					{
						int brackPos		= curLine.IndexOf( ']' );
						if( brackPos != -1 )
						{
							string sectionName	= curLine.Remove( brackPos, curLine.Length - brackPos ).Substring( 1 );
							ScriptSection toAdd	= new ScriptSection( sectionName, ioStream );
							sectionCollection.Add( toAdd );
						}
						else
							System.Windows.Forms.MessageBox.Show( "Error!  Invalid section format (missing closing bracket), in " + ((System.IO.FileStream)toRead).Name + " line: " + curLine );
					}
				}
			}
		}
		public override void Save( StreamWriter ioStream )
		{
			foreach( ScriptSection s in Sections )
			{
				s.Save( ioStream );
				ioStream.Flush();
			}
		}

		public override void Retrieve( string targFile )
		{
			FileStream ourIO		= File.OpenRead( targFile );
			Retrieve( ourIO );
			ourIO.Close();
		}
		public new ScriptSection FindSection( string sectionName )
		{
			return (ScriptSection)base.FindSection( sectionName );
		}

		public DFN_Categories Category
		{
			get	{	return category;	}
			set	{	category = value;	}
		}
	}
	#endregion "Script"
	#region "WorldFile90"
	public class WorldFile90 : BaseScript
	{
		public WorldFile90( string targFile ) : base( targFile )
		{
		}
		public WorldFile90( System.IO.Stream targFile ) : base( targFile )
		{
		}
		public WorldFile90() : base()
		{
		}
		public override void Retrieve( System.IO.Stream toRead )
		{
			StreamReader ioStream	= new StreamReader( toRead );
			string curLine			= "";
			while( curLine != null )
			{
				curLine = ioStream.ReadLine();
				if( curLine != null && curLine != "" )
				{
					if( curLine[0] == '[' )
					{
						int brackPos		= curLine.IndexOf( ']' );
						string sectionName	= curLine.Remove( brackPos, curLine.Length - brackPos ).Substring( 1 );
						WorldSection toAdd	= new WorldSection( sectionName, ioStream );
						sectionCollection.Add( toAdd );
					}
				}
			}
		}

		public override void Retrieve( string targFile )
		{
			FileStream ourIO		= File.OpenRead( targFile );
			Retrieve( ourIO );
			ourIO.Close();
		}
		public override void Save( StreamWriter ioStream )
		{
			foreach( WorldSection s in Sections )
			{
				s.Save( ioStream );
				ioStream.WriteLine();
			}
		}
	}
	#endregion "WorldFile90"
	#region "AccountScript"
	public class AccountScript : BaseScript
	{
		public AccountScript( string targFile ) : base( targFile )
		{
		}
		public AccountScript( System.IO.Stream targFile ) : base( targFile )
		{
		}
		public AccountScript() : base()
		{
		}
		public override void Retrieve( System.IO.Stream toRead )
		{
			StreamReader ioStream	= new StreamReader( toRead );
			string curLine			= "";
			while( curLine != null )
			{
				curLine = ioStream.ReadLine();
				if( curLine != null && curLine != "" )
				{
					if( curLine.StartsWith( "SECTION ACCOUNT" ) )
					{
						string sectionName		= curLine.Substring( "SECTION ACCOUNT ".Length );
						AccountSection toAdd	= new AccountSection( sectionName, ioStream );
						sectionCollection.Add( toAdd );
					}
				}
			}
		}
		public override void Save( StreamWriter ioStream )
		{
			foreach( AccountSection s in Sections )
			{
				s.Save( ioStream );
				ioStream.Flush();
			}
		}

		public override void Retrieve( string targFile )
		{
			FileStream ourIO = File.OpenRead( targFile );
			Retrieve( ourIO );
			ourIO.Close();
		}
		public new AccountSection FindSection( string sectionName )
		{
			return (AccountSection)base.FindSection( sectionName );
		}

	}
	#endregion "AccountScript"
	public class DictionaryScript : Script
	{
	}
	public class UOXIni : Script
	{
	}
	#region "ClassicBookScript"
	public class ClassicBookScript : BaseScript
	{
		protected uint		bookSerial;
		protected string	title;
		protected string	author;
		protected short		numPages;

		protected override void InternalReset()
		{
			bookSerial	= 0xFFFFFFFF;
			title		= "";
			author		= "";
			numPages	= 0;
		}
		protected void SerialFromFileName( string fileName )
		{
			string realFile		= fileName.Replace( "\\", "/" );
			string [] fileParts	= realFile.Split( '/' );
			string justFile		= fileParts[fileParts.Length - 1];
			string [] nameParts	= justFile.Split( '.' );
			string namePart		= "";
			for( int i = 0; i < (nameParts.Length - 1); ++i )
			{
				if( i > 0 )
					namePart += ".";
				namePart += nameParts[i];
			}
			bookSerial = Conversion.ToUInt32( "0x" + namePart );
		}
		public ClassicBookScript( string targFile, uint bSerial ) : base( targFile )
		{
			bookSerial = bSerial;
		}
		public ClassicBookScript( System.IO.Stream targFile, uint bSerial ) : base( targFile )
		{
			bookSerial = bSerial;
		}
		public ClassicBookScript( string targFile ) : base( targFile )
		{
			SerialFromFileName( targFile );
		}
		public ClassicBookScript( System.IO.Stream targFile ) : base( targFile )
		{
		}
		public ClassicBookScript() : base()
		{
		}
		public override void Retrieve( System.IO.Stream toRead )
		{
			byte [] bTitle	= new byte[62];
			byte [] bAuthor	= new byte[32];
			byte [] nPages	= new byte[2];

			toRead.Read( bTitle,  0, 62 );
			toRead.Read( bAuthor, 0, 32 );
			toRead.Read( nPages,  0, 2  );

			title		= Conversion.ToString( bTitle );
			author		= Conversion.ToString( bAuthor );
			numPages	= (short)(nPages[0] * 256 + nPages[1]);

			StreamReader ioStream	= new StreamReader( toRead );
			for( int i = 0; i < numPages; ++i )
			{
				ClassicBookSection mySection = new ClassicBookSection( "PAGE " + numPages.ToString(), ioStream );
				sectionCollection.Add( mySection );
			}
		}
		public override void Save( StreamWriter ioStream )
		{
			byte[] toWrite = Conversion.ToByteArray( title, 62 );
			ioStream.BaseStream.Write( toWrite, 0, 62 );

			toWrite			= Conversion.ToByteArray( author, 32 );
			ioStream.BaseStream.Write( toWrite, 0, 32 );

			toWrite			= Conversion.ToByteArray( numPages );
			ioStream.BaseStream.Write( toWrite, 0, toWrite.Length );

			for( int i = 0; i < numPages; ++i )
			{
				this[i].Save( ioStream );
			}

			ioStream.Flush();
		}

		public override void Retrieve( string targFile )
		{
			FileStream ourIO		= File.OpenRead( targFile );
			Retrieve( ourIO );
			ourIO.Close();
		}
		private new ClassicBookSection FindSection( string sectionName )
		{
			return null;
		}

		public string Title		{	get	{	return title;	}		set	{	title		= value;	}	}
		public string Author	{	get	{	return author;	}		set	{	author		= value;	}	}
		public int NumPages		{	get {	return numPages;	}										}
		public uint Serial		{	get {	return bookSerial;	}	set {	bookSerial	= value;	}	}
		protected new ArrayList Sections	{	get { return null;				} }
		public ArrayList Pages				{	get { return sectionCollection;	} }

		// Another way of retrieving the pages
		public ClassicBookSection this[int index]
		{
			get
			{
				if( index >= 0 && index < numPages )
					return (ClassicBookSection)sectionCollection[index];
				else
					return null;
			}
		}
	}
	#endregion "ClassicBookScript"
	public class MessageBoardScript : BaseScript
	{
		protected uint serial;
		public uint Serial { get { return serial; } set { serial = value; } }

		protected void SerialFromFileName( string fileName )
		{
			string realFile		= fileName.Replace( "\\", "/" );
			string [] fileParts	= realFile.Split( '/' );
			string justFile		= fileParts[fileParts.Length - 1];
			string [] nameParts	= justFile.Split( '.' );
			string namePart		= "";
			for( int i = 0; i < (nameParts.Length - 1); ++i )
			{
				if( i > 0 )
					namePart += ".";
				namePart += nameParts[i];
			}
			serial = Conversion.ToUInt32( "0x" + namePart );
		}
		public MessageBoardScript( string targFile ) : base( targFile )
		{
			SerialFromFileName( targFile );
		}
		public MessageBoardScript( System.IO.Stream targFile ) : base( targFile )
		{
		}
		public MessageBoardScript() : base()
		{
		}
		public override void Retrieve( System.IO.Stream toRead )
		{
			StreamReader ioStream	= new StreamReader( toRead );
			while( ioStream.BaseStream.Position < ioStream.BaseStream.Length )
			{
				MessageBoardSection toAdd	= new MessageBoardSection( ioStream );
				sectionCollection.Add( toAdd );
			}
		}

		public override void Retrieve( string targFile )
		{
			FileStream ourIO		= File.OpenRead( targFile );
			Retrieve( ourIO );
			ourIO.Close();
		}
		public override void Save( StreamWriter ioStream )
		{
			foreach( MessageBoardSection s in Posts )
			{
				s.Save( ioStream );
				ioStream.Flush();
			}
		}
		protected new ArrayList Sections	{	get { return null;				} }
		public ArrayList Posts				{	get { return sectionCollection; } }
	}

}

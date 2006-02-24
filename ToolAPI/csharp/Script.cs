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

	public abstract class BaseScript
	{
		protected ArrayList	sectionCollection;
		public BaseScript( string targFile )
		{
			sectionCollection = new ArrayList();
			Retrieve( targFile );
		}
		public BaseScript( System.IO.Stream toRead )
		{
			sectionCollection = new ArrayList();
			Retrieve( toRead );
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
	}
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

	public class WorldFile90 : BaseScript
	{
		public WorldFile90( string targFile ) : base( targFile )
		{
		}
		public WorldFile90( System.IO.Stream targFile ) : base( targFile )
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
}

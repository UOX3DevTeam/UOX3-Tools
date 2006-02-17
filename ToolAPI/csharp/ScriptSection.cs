// created on 12/02/2003 at 6:56 PM
using System.IO;
using System.Collections;

namespace UOXData.Script
{
	public class DataValue
	{
		protected string actualValue;
		public DataValue( string val )
		{
			actualValue = val;
		}
		public string Value
		{
			get { return actualValue;	}
			set { actualValue = value;	}
		}
		public override string ToString()
		{
			return actualValue;
		}
		public static implicit operator string( DataValue m) 
		{
			// code to convert from MyType to int
			return m.actualValue;
		}
		public string[] Split( params char[] mValue )
		{
			return actualValue.Split( mValue );
		}

		#region "Conversion functions"
		public byte ToUInt08()
		{
			return Conversion.ToUInt08( actualValue );
		}
		public sbyte ToInt8()
		{
			return Conversion.ToInt08( actualValue );
		}
		public ushort ToUInt16()
		{
			return Conversion.ToUInt16( actualValue );
		}
		public short ToInt16()
		{
			return Conversion.ToInt16( actualValue );
		}
		public uint ToUInt32()
		{
			return Conversion.ToUInt32( actualValue );
		}
		public int ToInt32()
		{
			return Conversion.ToInt32( actualValue );
		}
		#endregion "Conversion functions"
	}

	public class TagDataPair
	{
		protected string tag;
		protected DataValue data;
		public TagDataPair( string t, string d )
		{
			tag			= t;
			data		= new DataValue( d );
//			data.Value	= d;
		}
		public string Tag
		{
			get {	return tag;		}
			set {	tag = value;	}
		}
		public DataValue Data
		{
			get {	return data;	}
			set {	data = value;	}
		}
	}
	
	public abstract class Section
	{
		protected string	sectionName;
		protected ArrayList	tagDataPairs;
		
		public Section()
		{ 
			tagDataPairs = new ArrayList();
		}
		public Section( string sectName, StreamReader ioStream )
		{
			tagDataPairs	= new ArrayList();
			SectionName		= sectName;	
			Retrieve( ioStream );
		}
		
		public void Add( string tag, string data )
		{
			TagDataPair toAdd = new TagDataPair( tag, data );
			tagDataPairs.Add( toAdd );
		}

		public string FindTag( string tagName )
		{
			foreach( TagDataPair t in tagDataPairs )
			{
				if( t.Tag == tagName )
					return t.Data.Value;
			}
			return "";
		}

		public TagDataPair GetDataPair( string tagName )
		{
			foreach( TagDataPair t in tagDataPairs )
			{
				if( t.Tag == tagName )
					return t;
			}
			return null;
		}
		
		public abstract void Retrieve( StreamReader ioStream );
		public abstract void Save( StreamWriter ioStream );
		
		/// Section name property, indicating the section that this object represents
		public string SectionName
		{
			get	{	return sectionName;		}
			set	{	sectionName = value;	}
		}
		
		public ArrayList TagDataPairs
		{
			get	{	return tagDataPairs;	}
		}
	}
	public class ScriptSection : Section
	{
		public ScriptSection() : base()
		{ 
		}
		public ScriptSection( string sectName, StreamReader ioStream ) : base( sectName, ioStream )
		{
		}
		
		public new TagDataPair GetDataPair( string tagName )
		{
			foreach( TagDataPair t in tagDataPairs )
			{
				if( t.Tag.ToUpper() == tagName.ToUpper() )
					return t;
			}
			return null;
//			return base.GetDataPair( tagName.ToUpper() );
		}
		
		public new void Add( string tag, string data )
		{
			base.Add( tag, data );
//			base.Add( tag.ToUpper(), data );
		}
		public override void Retrieve( StreamReader ioStream )
		{
			string curLine = "";
			while( curLine != null )
			{
				if( curLine != "" && curLine[0] == '}' )
					break;
				curLine = ioStream.ReadLine();
				if( curLine != null && curLine != "" )
				{
					if( curLine[0] != '}' && curLine[0] != '{' && curLine != "" && !curLine.StartsWith( "//" ) )
					{
						string [] split	= curLine.Split( '=' );
						string tag		= split[0];
						string data		= "";
						for( int i = 1; i < split.Length; i++ )
							data += split[i];
						data = Conversion.TrimCommentAndWhitespace( data );
						Add( tag, data );
					}
				}
			}
		}
		public override void Save( StreamWriter ioStream )
		{
			ioStream.WriteLine( "[" + SectionName + "]" );
			ioStream.WriteLine( "{" );
			foreach( TagDataPair t in TagDataPairs )
			{
				ioStream.WriteLine( t.Tag + "=" + t.Data );
			}
			ioStream.WriteLine( "}" );
			ioStream.WriteLine();
			ioStream.Flush();
		}
		
	}

	public class WorldSection : Section
	{
		public WorldSection() : base()
		{ 
		}
		public WorldSection( string sectName, StreamReader ioStream ) : base( sectName, ioStream )
		{
		}
		public override void Retrieve( StreamReader ioStream )
		{
			string curLine = "";
			while( curLine != null )
			{
				if( curLine != "" && curLine == "o---o" )
					break;
				curLine = ioStream.ReadLine();
				if( curLine != null && curLine != "" )
				{
					if( curLine != "o---o" && curLine[0] != '{' && curLine != "" && !curLine.StartsWith( "//" ) )
					{
						string [] split	= curLine.Split( '=' );
						string tag		= split[0];
						string data		= "";
						for( int i = 1; i < split.Length; i++ )
							data += split[i];
						Add( tag, data );
					}
				}
			}
		}
		public override void Save( StreamWriter ioStream )
		{
			ioStream.WriteLine( "[" + SectionName + "]" );
			foreach( TagDataPair t in TagDataPairs )
			{
				ioStream.WriteLine( t.Tag + "=" + t.Data );
			}
			ioStream.WriteLine();
			ioStream.WriteLine( "o---o" );
		}
	}
}

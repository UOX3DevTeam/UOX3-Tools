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
		public sbyte ToInt08()
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
		
		protected virtual void InternalReset()
		{
		}

		public Section()
		{ 
			tagDataPairs = new ArrayList();
			InternalReset();
		}
		public Section( string sectName )
		{
			tagDataPairs	= new ArrayList();
			sectionName		= sectName;
			InternalReset();
		}
		public Section( string sectName, StreamReader ioStream )
		{
			tagDataPairs	= new ArrayList();
			sectionName		= sectName;	
			InternalReset();
			Retrieve( ioStream );
		}

		public Section( StreamReader ioStream )
		{
			tagDataPairs	= new ArrayList();
			InternalReset();
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
		protected DFN_Categories	sectCategory;
		public ScriptSection() : base()
		{
			sectCategory	= DFN_Categories.NUM_DEFS;
		}
		public ScriptSection( string sectName ) : base( sectName )
		{
			sectCategory	= DFN_Categories.NUM_DEFS;
		}
		public ScriptSection( string sectName, StreamReader ioStream ) : base( sectName, ioStream )
		{
			sectCategory	= DFN_Categories.NUM_DEFS;
		}
		public ScriptSection( DFN_Categories mValue ) : base()
		{
			sectCategory	= mValue;
		}
		public ScriptSection( string sectName, DFN_Categories mValue ) : base( sectName )
		{
			sectCategory	= mValue;
		}
		public ScriptSection( string sectName, StreamReader ioStream, DFN_Categories mValue ) : base( sectName, ioStream )
		{
			sectCategory	= mValue;
		}

		public DFN_Categories	Category { get { return sectCategory; } set { sectCategory = value; } }

		public new TagDataPair GetDataPair( string tagName )
		{
			foreach( TagDataPair t in tagDataPairs )
			{
				if( t.Tag.ToUpper() == tagName.ToUpper() )
					return t;
			}
			return null;
		}
		
		public new void Add( string tag, string data )
		{
			base.Add( tag, data );
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
						{
							if( i > 1 )
								data += "=";
							data += split[i];
						}
						tag		= Conversion.TrimCommentAndWhitespace( tag );
						data	= Conversion.TrimCommentAndWhitespace( data );
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
		public WorldSection( string sectName ) : base( sectName )
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
						{
							if( i > 1 )
								data += "=";
							data += split[i];
						}
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

	public class AccountSection : Section
	{
		public AccountSection() : base()
		{ 
		}
		public AccountSection( string sectName ) : base( sectName )
		{
		}
		public AccountSection( string sectName, StreamReader ioStream ) : base( sectName, ioStream )
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
		}
		
		public new void Add( string tag, string data )
		{
			base.Add( tag, data );
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
						string [] split	= curLine.Split( ' ' );
						string tag		= split[0];
						string data		= "";
						for( int i = 1; i < split.Length; i++ )
						{
							if( i > 1 )
								data += " ";
							data += split[i];
						}
						data = Conversion.TrimCommentAndWhitespace( data );
						Add( tag, data );
					}
				}
			}
		}
		public override void Save( StreamWriter ioStream )
		{
			ioStream.WriteLine( "SECTION ACCOUNT " + sectionName );
			ioStream.WriteLine( "{" );
			foreach( TagDataPair t in TagDataPairs )
			{
				ioStream.WriteLine( t.Tag + " " + t.Data );
			}
			ioStream.WriteLine( "}" );
			ioStream.WriteLine();
			ioStream.Flush();
		}
		
	}

	public class ClassicBookSection : Section
	{
		protected override void InternalReset()
		{
			for( int i = 0; i < 8; i++ )
				tagDataPairs.Add( "" );
		}
		public ClassicBookSection() : base()
		{ 
		}
		public ClassicBookSection( string sectName ) : base( sectName )
		{
		}
		public ClassicBookSection( string sectName, StreamReader ioStream ) : base( sectName, ioStream )
		{
		}
		
		private new TagDataPair GetDataPair( string tagName )
		{
			return null;
		}
		
		private new void Add( string tag, string data )
		{
		}
		public override void Retrieve( StreamReader ioStream )
		{
			char [] lineBytes	= new char[34];
			for( int i = 0; i < 8; ++i )
			{
				ioStream.Read( lineBytes, 0, 34 );
				tagDataPairs[i] = Conversion.ToString( lineBytes );
			}
		}
		public override void Save( StreamWriter ioStream )
		{
			for( int i = 0; i < 8; ++i )
			{
				byte[] toWrite = Conversion.ToByteArray( ((string)tagDataPairs[i]), 34 );
				ioStream.BaseStream.Write( toWrite, 0, 34 );
			}
		}
		public string this[int index]
		{
			get
			{
				if( index >= 0 && index < 8 )
					return (string)tagDataPairs[index];
				else
					return null;
			}
			set
			{
				if( index >= 0 && index < 8 )
					tagDataPairs[index] = value;
			}
		}
	}
	public class MessageBoardSection : Section
	{
		public enum PostType
		{
			Global	= 0x01000000,
			Region	= 0x02000000,
			Local	= 0x03000000
		}
		protected byte		toggle;
		protected uint		associatedID;
		protected string	poster;
		protected string	subject;
		protected string	time;
		protected byte		numLines;
		protected ArrayList	lines;
		protected uint		messageID;

		public byte Toggle			{ get { return toggle;			} set { toggle			= value; } }
		public uint AssociatedID	{ get { return AssociatedID;	} set { AssociatedID	= value; } }
		public string Poster		{ get { return poster;			} set { poster			= value; } }
		public string Subject		{ get { return subject;			} set { subject			= value; } }
		public string Time			{ get { return time;			} set { time			= value; } }
		public byte NumLines		{ get { return numLines;		} set { numLines		= value; } }
		public ArrayList Lines		{ get { return lines;			} set { lines			= value; } }
		public uint MessageID		{ get { return messageID;		} set { messageID		= value; } }
		public bool IsGlobal		{ get { long value = (long)(messageID) - (long)PostType.Global;	return ( value >= 0 && value < 0x01000000 ); } }
		public bool IsRegion		{ get { long value = (long)(messageID) - (long)PostType.Region;	return ( value >= 0 && value < 0x01000000 ); } }
		public bool IsLocal			{ get { long value = (long)(messageID) - (long)PostType.Local;	return ( value >= 0 && value < 0x01000000 ); } }
		public PostType PostLocation
		{
			get
			{
				if( messageID >= (uint)PostType.Local ) 
					return PostType.Local;
				else if( messageID >= (uint)PostType.Region )
					return PostType.Region;
				else
					return PostType.Global;
			}
		}
		protected override void InternalReset()
		{
			lines = new ArrayList();
		}
		public MessageBoardSection() : base()
		{ 
		}
		public MessageBoardSection( string sectName ) : base( sectName )
		{
		}
		public MessageBoardSection( string sectName, StreamReader ioStream ) : base( sectName, ioStream )
		{
		}
		public MessageBoardSection( StreamReader ioStream ) : base( ioStream )
		{
		}
		
		private new TagDataPair GetDataPair( string tagName )
		{
			return null;
		}
		
		private new void Add( string tag, string data )
		{
		}
		public override void Retrieve( StreamReader ioStream )
		{
//For each post: 
//   BYTE[2]      Length 
//   BYTE      Toggle 
//   BYTE[4]      AssociatedID (Replied to post / NPC Escort) 
//   BYTE      posterLen 
//   BYTE[posterLen]   Poster (null terminated string) 
//   BYTE      subjectLen 
//   BYTE[subjectLen]Subject (null terminated string) 
//   BYTE      timeLen 
//   BYTE[timeLen]   Time (null terminated string, "Day 1 @ 1:00") 
//   BYTE      numLines 
//   For each Line 
//      BYTE      lineLen 
//      BYTE[lineLen]   Body (null terminated) 
//   BYTE[4]      MessageID 
			byte [] pLength		=	new byte[2];
			ioStream.BaseStream.Read( pLength, 0, 2 );
			ushort postLength	=	(ushort)(pLength[0] * 256 + pLength[1]);
			byte [] rawData		=	new byte[postLength - 2];
			ioStream.BaseStream.Read( rawData, 0, postLength - 2 );
			int offset			=	0;
			toggle				=	rawData[offset++];
			associatedID		=	Conversion.ToUInt32( rawData, offset );
			offset				+=	4;
			byte lenByte		=	rawData[offset++];
			for( int i = 0; i < lenByte; ++i )
				poster += (char)rawData[offset+i];
			if( poster.EndsWith( "\0" ) )
				poster = poster.Substring( 0, poster.Length - 1 );
			offset				+=	lenByte;

			lenByte				=	rawData[offset++];
			for( int i = 0; i < lenByte; ++i )
				subject += (char)rawData[offset+i];
			offset				+=	lenByte;
			if( subject.EndsWith( "\0" ) )
				subject = subject.Substring( 0, subject.Length - 1 );

			lenByte				=	rawData[offset++];
			for( int i = 0; i < lenByte; ++i )
				time += (char)rawData[offset+i];
			offset				+=	lenByte;
			if( time.EndsWith( "\0" ) )
				time = time.Substring( 0, time.Length - 1 );

			lenByte				=	rawData[offset++];
			numLines			=	lenByte;
			for( int i = 0; i < lenByte; ++i )
			{
				byte lineLen	=	rawData[offset++];
				string line		=	"";
				for( int j = 0; j < lineLen; ++j )
				{
					if( rawData[offset+i] == 0 )
						break;
					line += (char)rawData[offset+j];
					if( line.EndsWith( "\0" ) )
						line = line.Substring( 0, line.Length - 1 );
				}
				offset			+=	lineLen;
				lines.Add( line );
			}
			messageID			=	Conversion.ToUInt32( rawData, offset );
		}
		public override void Save( StreamWriter ioStream )
		{
			// 2 + 1 + 4 + 1 + 1 + 1 + 1 + 4 + variable
			//   3       5       2       5
			//       8               7
			//				 15
			// variable = poster Length + subject Length + time Length + lineVariable
			// time/subj/poster lengths + 3 (nulls)
			// lineVariable = for each line -> 1 + lineLength

			ushort lengthToWrite = (ushort)(18 + poster.Length + subject.Length + time.Length + lines.Count);
			for( int i = 0; i < lines.Count; ++i )
			{
				lengthToWrite += (ushort)(((string)(lines[i])).Length + 1);
			}

			ioStream.BaseStream.Write( Conversion.ToByteArray( lengthToWrite ), 0, 2 );
			ioStream.BaseStream.WriteByte( toggle );
			ioStream.BaseStream.Write( Conversion.ToByteArray( associatedID ), 0, 4 );

			int postLen = poster.Length + 1;
			ioStream.BaseStream.WriteByte( (byte)(postLen) );
			ioStream.BaseStream.Write( Conversion.ToByteArray( poster, postLen ), 0, postLen );

			int subjLen = subject.Length + 1;
			ioStream.BaseStream.WriteByte( (byte)(subjLen) );
			ioStream.BaseStream.Write( Conversion.ToByteArray( subject, subjLen ), 0, subjLen );

			int timeLen = time.Length + 1;
			ioStream.BaseStream.WriteByte( (byte)(timeLen) );
			ioStream.BaseStream.Write( Conversion.ToByteArray( time, timeLen ), 0, timeLen );

			ioStream.BaseStream.WriteByte( numLines );

			for( int i = 0; i < lines.Count; ++i )
			{
				string line = ((string)lines[i]);
				int lineLen = line.Length + 1;
				ioStream.BaseStream.WriteByte( (byte)(lineLen) );
				ioStream.BaseStream.Write( Conversion.ToByteArray( line, lineLen ), 0, lineLen );
			}

			ioStream.BaseStream.Write( Conversion.ToByteArray( messageID ), 0, 4 );
			//For each post: 
			//   BYTE[2]      Length 
			//   BYTE      Toggle 
			//   BYTE[4]      AssociatedID (Replied to post / NPC Escort) 
			//   BYTE      posterLen 
			//   BYTE[posterLen]   Poster (null terminated string) 
			//   BYTE      subjectLen 
			//   BYTE[subjectLen]Subject (null terminated string) 
			//   BYTE      timeLen 
			//   BYTE[timeLen]   Time (null terminated string, "Day 1 @ 1:00") 
			//   BYTE      numLines 
			//   For each Line 
			//      BYTE      lineLen 
			//      BYTE[lineLen]   Body (null terminated) 
			//   BYTE[4]      MessageID 
			//			for( int i = 0; i < 8; ++i )
//			{
//				byte[] toWrite = Conversion.ToByteArray( ((string)tagDataPairs[i]), 34 );
//				ioStream.BaseStream.Write( toWrite, 0, 34 );
//			}
		}
		public string this[int index]
		{
			get
			{
				if( index >= 0 && index < numLines )
					return (string)lines[index];
				else
					return null;
			}
		}
		public void Add( string lineToAdd )
		{
			numLines++;
			lines.Add( lineToAdd );
		}
	}
}

using System.Collections.Generic;
using System.IO;

namespace AccountManager
{
	public class AccountObject
	{
		public AccountObject( int acctNum )
		{
			num			= acctNum;
			name		= "";
			pass		= "";
			contact		= "n/a";
			path		= "";
			flags		= 0x0000;
			timeban		= 0;
			orphanChars = new List<OrphanObject>();
			charSlots	= new List<SlotObject>();
			for( byte i = 0; i < 6; ++i )
				charSlots.Add( new SlotObject() );
		}

		#region "Protected Data"
		protected int				num;
		protected string			name;
		protected string			pass;
		protected string			contact;
		protected string			path;
		protected ushort			flags;
		protected uint				timeban;
		protected List<SlotObject>	charSlots;
		protected List<OrphanObject> orphanChars;
		#endregion

		#region "Public Properties"
		public int				Number			{ get { return num;			}	set { num = value;		}	}
		public string			Name			{ get { return name;		}	set { name = value;		}	}
		public string			Pass			{ get { return pass;		}	set { pass = value;		}	}
		public string			Contact			{ get { return contact;		}	set { contact = value;	}	}
		public string			Path			{ get { return path;		}	set { path = value;		}	}
		public ushort			Flags			{ get { return flags;		}	set { flags = value;	}	}
		public uint				TimeBan			{ get { return timeban;		}	set { timeban = value;	}	}
		public List<SlotObject> CharSlots		{ get { return charSlots;	}								}
		public List<OrphanObject> OrphanChars { get { return orphanChars; } }
		#endregion

		public void DeleteOrphan( OrphanObject toDelete )
		{
			if( orphanChars.Contains( toDelete ) )
			{
				orphanChars.Remove( toDelete );
			}
		}

		public bool Save( StreamWriter ioStream )
		{
			if( name.Length == 0 || pass.Length == 0 || num >= 0xFFFF )
				return false;

			ioStream.WriteLine( "SECTION ACCOUNT " + num.ToString() );
			ioStream.WriteLine( "{" );
			ioStream.WriteLine( "NAME " + name );
			ioStream.WriteLine( "PASS " + pass );
			ioStream.WriteLine( "FLAGS " + UOXData.Conversion.ToHexString( flags ) );
			ioStream.WriteLine( "PATH " + path );
			ioStream.WriteLine( "TIMEBAN " + timeban.ToString() );
			ioStream.WriteLine( "CONTACT " + contact );
			byte i = 0;
			foreach( SlotObject mSlot in charSlots )
			{
				++i;
				ioStream.WriteLine( "CHARACTER-" + i.ToString() + " " + UOXData.Conversion.ToHexString( mSlot.Serial ) + " [" + mSlot.Name + "]" );
			}
			ioStream.WriteLine("}");
			ioStream.WriteLine();
			ioStream.Flush();
			return true;
		}

		public void SetFlag( ushort toSet, bool newVal )
		{
			if( newVal )
				flags |= toSet;
			else
				flags &= (ushort)(~toSet);
		}

		public bool GetFlag( ushort toGet )
		{
			if( (flags & toGet) == toGet )
				return true;
			return false;
		}
	}

	public class SlotObject
	{
		public SlotObject()
		{
			name	= "UNKNOWN";
			serial	= 0xFFFFFFFF;
		}
		public SlotObject( string nName, uint nSer )
		{
			name = nName;
			serial = nSer;
		}

		#region "Protected Data"
		protected string name;
		protected uint serial;
		#endregion

		#region "Public Properties"
		public string Name			{ get { return name;	}	set { name = value;		} }
		public uint Serial			{ get { return serial;	}	set { serial = value;	} }
		#endregion
	}

	public class OrphanObject : SlotObject
	{
		public OrphanObject() : base()
		{
			x = 0;
			y = 0;
			z = 0;
		}

		public OrphanObject( string nName, uint nSer, ushort nX, ushort nY, sbyte nZ ) : base( nName, nSer )
		{
			x = nX;
			y = nY;
			z = nZ;
		}

		#region "Protected Data"
		protected ushort x;
		protected ushort y;
		protected sbyte z;
		#endregion

		#region "Public Properties"
		public ushort	X { get { return x; } set { x = value; } }
		public ushort	Y { get { return y; } set { y = value; } }
		public sbyte	Z { get { return z; } set { z = value; } }
		#endregion
	}
}

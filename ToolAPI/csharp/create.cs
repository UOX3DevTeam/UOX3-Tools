// created on 15/02/2003 at 6:19 PM
using System.IO;
using System.Collections;

namespace UOXData 
{
	public class ResAmountPair
	{
		protected ushort	itemID;
		protected byte		amountNeeded;
		protected ushort	colour;
		public ResAmountPair()
		{
			itemID			= 0;
			amountNeeded	= 1;
			colour 			= 0;
		}
		
		public ushort ItemID
		{
			get { return itemID;		}
			set { itemID = value;		}
		}
		
		public ushort Colour
		{
			get { return colour;		}
			set { colour = value;		}
		}
		
		public byte AmountNeeded
		{
			get { return amountNeeded;	}
			set { amountNeeded = value;	}
		}
	}
	public class ResSkillReq
	{
		protected Skills	skillNumber;
		protected ushort	minSkill;
		protected ushort	maxSkill;
		public ResSkillReq()
		{
			skillNumber = Skills.ALCHEMY;
			minSkill	= 0;
			maxSkill	= 0;
		}
		
		public Skills SkillNumber
		{
			get { return skillNumber;	}
			set { skillNumber = value;	}
		}
		
		public ushort MinSkill
		{
			get { return minSkill;		}
			set { minSkill = value;		}
		}
		
		public ushort MaxSkill
		{
			get { return maxSkill;		}
			set { maxSkill = value;		}
		}
	}
	public abstract class CreateEntry
	{
		protected ushort	targID;
		protected ushort	colour;
		protected string	name;
		protected ushort	parentMenu;
		protected ushort	menuID;
		
		public CreateEntry()
		{
			colour		= 0;
			name		= "";
			targID		= 0;
			parentMenu	= 0;
			menuID		= 0;
		}
		public ushort Colour
		{
			get { return colour;		}
			set { colour = value;		}
		}
		public ushort TargID
		{
			get { return targID;		}
			set { targID = value;		}
		}
		public string Name
		{
			get { return name;			}
			set { name = value;			}
		}
		public ushort ParentMenu
		{
			get { return parentMenu;	}
			set { parentMenu = value;	}
		}
		public ushort MenuID
		{
			get { return menuID;		}
			set { menuID = value;		}
		}
		
		public abstract void Retrieve( Script.Section toScanFrom );
		public abstract void Save( StreamWriter toWrite );
	}
	public class CreateMenuEntry : CreateEntry
	{
		protected ArrayList			itemEntries;
		protected ArrayList			menuEntries;
		protected static ArrayList	missingMenus;
		protected static ArrayList	missingItems;
		protected bool				isRoot;
		
		static CreateMenuEntry()
		{
			missingMenus = new ArrayList();
			missingItems = new ArrayList();
		}
		
		public static bool HasValidSectionHeader( string toCompare )
		{
			return toCompare.StartsWith( "MENUENTRY " );
		}
		protected static void ParseSubMenu( Script.Section i, CreateMenuEntry parent, Script.BaseScript tObj )
		{
			foreach( Script.TagDataPair t in i.TagDataPairs )
			{
				if( t.Tag == "MENU" )
				{
					// do menu parsing here
					string mToFind		= "MENUENTRY " + t.Data;
					Script.Section k	= tObj.FindSection( mToFind );
					if( k != null )
					{
						CreateMenuEntry cmeMade = new CreateMenuEntry( k );
						parent.AddSubmenu( cmeMade );
						Script.Section l		= tObj.FindSection( "SUBMENU " + t.Data );
						if( l != null )
						{
							ParseSubMenu( l, cmeMade, tObj );
						}
					}
					else
						missingMenus.Add( t.Tag + " " + t.Data );
				}
				else if( t.Tag == "ITEM" )
				{
					// do item parsing here
					string iToFind		= "ITEM " + t.Data;
					Script.Section j	= tObj.FindSection( iToFind );
					if( j != null )
					{
						CreateItemEntry cieMade = new CreateItemEntry( j );
						parent.AddItem( cieMade );
					}
					else
						missingItems.Add( t.Tag + " " + t.Data );
				}
			}
		}
		public static ArrayList CreateStructureFromScript( Script.BaseScript tObj )
		{
			ArrayList retVal = new ArrayList();
			foreach( Script.ScriptSection i in tObj.Sections )
			{
				if( i.SectionName.StartsWith( "SUBMENU " ) )
				{
					string toFind		= "MENUENTRY " + i.SectionName.Remove( 0, 8 );
					Script.Section j	= tObj.FindSection( toFind );
					if( j == null )
					{
						CreateMenuEntry rootMenu = new CreateMenuEntry( i );
						rootMenu.IsRoot = true;
						retVal.Add( rootMenu );
						ParseSubMenu( i, rootMenu, tObj );
					}
				}
			}

			return retVal;
		}
		public CreateMenuEntry() : base()
		{
			isRoot 		= false;
			menuID	 	= 0;
			itemEntries	= new ArrayList();
			menuEntries = new ArrayList();
		}
		public CreateMenuEntry( Script.Section toScanFrom ) : base()
		{
			isRoot 		= false;
			itemEntries	= new ArrayList();
			menuEntries = new ArrayList();
			menuID 		= Conversion.ToUInt16( toScanFrom.SectionName.Remove( 0, 8 ) );
			Retrieve( toScanFrom );
		}
		
		public override void Retrieve( Script.Section toScanFrom )
		{
			foreach( Script.TagDataPair t in toScanFrom.TagDataPairs )
			{
				switch( t.Tag )
				{
				case "COLOUR":	colour	= t.Data.ToUInt16();	break;
				case "ID":		targID	= t.Data.ToUInt16();	break;
				case "NAME":	name	= t.Data;				break;
				case "SUBMENU":	menuID	= t.Data.ToUInt16();	break;
				default:		break;
				}
			}
		}
		
		public override void Save( StreamWriter ioStream )
		{
			// first part, the SUBMENU
			Script.ScriptSection weWrite	= new Script.ScriptSection();
			weWrite.SectionName				= "SUBMENU " + MenuID;
			
			foreach( CreateItemEntry cie in SubItems )
				weWrite.Add( "ITEM", cie.MenuID.ToString() );

			foreach( CreateMenuEntry cme in SubMenus )
				weWrite.Add( "MENU", cme.MenuID.ToString() );
			
			weWrite.Save( ioStream );
			
			// second part, the MENUENTRY
			if( !isRoot )
			{
				Script.ScriptSection menuEntry	= new Script.ScriptSection();
				menuEntry.SectionName			= "MENUENTRY " + MenuID;
				
				menuEntry.Add( "NAME", 		name );
				menuEntry.Add( "ID", 		Conversion.ToHexString( targID ) );
				menuEntry.Add( "COLOUR",	Conversion.ToHexString( colour ) );
				menuEntry.Add( "SUBMENU",	MenuID.ToString() );
				
				menuEntry.Save( ioStream );
			}
				
			foreach( CreateItemEntry cie2 in SubItems )
				cie2.Save( ioStream );
			
			foreach( CreateMenuEntry cme2 in SubMenus )
				cme2.Save( ioStream );
		}
		public CreateMenuEntry AddSubmenu( Script.Section nSubMenu )
		{
			throw new System.Exception();
//			CreateMenuEntry toAdd = new CreateMenuEntry( nSubMenu );
//			AddSubmenu( toAdd );
//			return toAdd;
		}
		public void AddSubmenu( CreateMenuEntry nSubMenu )
		{
			nSubMenu.ParentMenu = menuID;
			menuEntries.Add( nSubMenu );
		}
		public CreateItemEntry AddItem( Script.Section nItem )
		{
			throw new System.Exception();
//			CreateItemEntry toAdd = new CreateItemEntry( nItem );
//			AddItem( toAdd );
//			return toAdd;
		}
		public void AddItem( CreateItemEntry nItem )
		{
			nItem.ParentMenu = menuID;
			itemEntries.Add( nItem );
		}
		public CreateItemEntry FindItem( ushort menuNumber )
		{
			if( itemEntries != null )
			{
				foreach( CreateItemEntry cie in itemEntries )
				{
					if( cie.MenuID == menuNumber )
						return cie;
				}
				if( menuEntries != null )
				{
					foreach( CreateMenuEntry cme in menuEntries )
					{
						CreateItemEntry tmp = cme.FindItem( menuNumber );
						if( tmp != null )
						{
							if( tmp.MenuID == menuNumber )
								return tmp;
						}
					}
				}
			}
			return null;
		}
		public CreateMenuEntry FindMenu( ushort menuNumber )
		{
			if( menuEntries != null )
			{
				foreach( CreateMenuEntry cme in menuEntries )
				{
					if( cme.MenuID == menuNumber )
						return cme;
				}
				foreach( CreateMenuEntry cmeSub in menuEntries )
				{
					CreateMenuEntry tmp = cmeSub.FindMenu( menuNumber );
					if( tmp != null )
						return tmp;
				}
			}
			return null;
		}
		public ArrayList SubMenus
		{
			get { return menuEntries;	}
		}
		public ArrayList SubItems
		{
			get { return itemEntries;	}
		}
		public static ArrayList MissingMenus
		{
			get { return missingMenus;	}
		}
		public static ArrayList MissingItems
		{
			get { return missingItems;	}
		}
		public bool	IsRoot
		{
			get { return isRoot;		}
			set { isRoot = value;		}
		}
	}
	public class CreateItemEntry : CreateEntry
	{
		protected string	sectName;
		protected ushort	soundPlayed;
		protected byte		minRank;
		protected byte		maxRank;
		protected string	addItem;
		protected short		delay;
		protected ushort	spell;
		protected ArrayList	resourceNeeded;
		protected ArrayList	skillReqs;
		
		public static bool HasValidSectionHeader( string toCompare )
		{
			return toCompare.StartsWith( "ITEM " );
		}
		public CreateItemEntry() : base()
		{
			soundPlayed		= 0;
			minRank			= 1;
			maxRank			= 10;
			addItem			= "";
			delay			= 0;
			sectName		= "";
			resourceNeeded	= new ArrayList();
			skillReqs		= new ArrayList();
		}
		public CreateItemEntry( Script.Section toScanFrom ) : base()
		{
			soundPlayed		= 0;
			minRank			= 1;
			maxRank			= 10;
			addItem			= "";
			delay			= 0;
			sectName		= toScanFrom.SectionName;
			resourceNeeded	= new ArrayList();
			skillReqs		= new ArrayList();
			menuID 			= Conversion.ToUInt16( toScanFrom.SectionName.Remove( 0, 5 ) );
			Retrieve( toScanFrom );
		}
		public override void Save( StreamWriter ioStream )
		{
			// first part, the SUBMENU
			Script.ScriptSection weWrite	= new Script.ScriptSection();
			weWrite.SectionName				= "ITEM " + MenuID;
			
			weWrite.Add( "NAME", 	name );
			weWrite.Add( "ID", 		Conversion.ToHexString( targID ) );
			weWrite.Add( "COLOUR",	Conversion.ToHexString( colour ) );
			weWrite.Add( "MINRANK",	minRank.ToString() );
			weWrite.Add( "MAXRANK",	maxRank.ToString() );
			weWrite.Add( "SOUND", 	Conversion.ToHexString( soundPlayed ) );
			weWrite.Add( "ADDITEM",	addItem );
			weWrite.Add( "DELAY",	delay.ToString() );
			weWrite.Add( "SPELL", 	spell.ToString() );
			
			foreach( ResSkillReq rsr in SkillReqs )
			{
				weWrite.Add( "SKILL", ((int)rsr.SkillNumber).ToString() + " " + rsr.MinSkill + " " + rsr.MaxSkill );
			}

			foreach( ResAmountPair rap in ResourceNeeded )
			{
				weWrite.Add( "RESOURCE", Conversion.ToHexString( rap.ItemID ) + " " + rap.AmountNeeded.ToString() + " " + rap.Colour.ToString() );
			}

			weWrite.Save( ioStream );
		}
		public override void Retrieve( Script.Section toScanFrom )
		{
			foreach( Script.TagDataPair t in toScanFrom.TagDataPairs )
			{
				switch( t.Tag )
				{
				default:		break;
				case "COLOUR":	colour		= t.Data.ToUInt16();	break;
				case "ID":		targID		= t.Data.ToUInt16();	break;
				case "MINRANK":	minRank 	= t.Data.ToUInt08();	break;
				case "MAXRANK":	maxRank 	= t.Data.ToUInt08();	break;
				case "NAME":	name		= t.Data;				break;
				case "SOUND":	soundPlayed = t.Data.ToUInt16();	break;
				case "ADDITEM":	addItem		= t.Data;				break;
				case "DELAY":	delay		= t.Data.ToInt16();		break;
				case "SPELL":	spell		= t.Data.ToUInt16();	break;
				case "SKILL":
					ResSkillReq rsrToAdd = new ResSkillReq();
					string [] skSplit = t.Data.Split( ' ' );
					if( skSplit.Length < 3 )
						rsrToAdd.MaxSkill = 1000;
					else
						rsrToAdd.MaxSkill = Conversion.ToUInt16( skSplit[2] );
					if( skSplit.Length < 2 )
						rsrToAdd.MinSkill = 1000;
					else
						rsrToAdd.MinSkill = Conversion.ToUInt16( skSplit[1] );
					rsrToAdd.SkillNumber = (Skills)Conversion.ToUInt08( skSplit[0] );
					skillReqs.Add( rsrToAdd );
					break;
				case "RESOURCE":
					ResAmountPair rapToAdd = new ResAmountPair();
					string [] resSplit = t.Data.Split( ' ' );
					if( resSplit.Length < 3 )
						rapToAdd.Colour = 0;
					else
						rapToAdd.Colour = Conversion.ToUInt16( resSplit[2] );
					if( resSplit.Length < 2 )
						rapToAdd.AmountNeeded = 1;
					else
						rapToAdd.AmountNeeded = Conversion.ToUInt08( resSplit[1] );
					rapToAdd.ItemID = Conversion.ToUInt16( resSplit[0] );
					resourceNeeded.Add( rapToAdd );
					break;
				}
			}
		}
		public float AverageMinSkill
		{
			get
			{
				float sum	= 0;
				int iCount	= 0;
				foreach( ResSkillReq r in skillReqs )
				{
					sum += r.MinSkill;
					iCount++;
				}
				return ( sum / iCount );
			}
		}
		public float AverageMaxSkill
		{
			get
			{
				float sum	= 0;
				int iCount	= 0;
				foreach( ResSkillReq r in skillReqs )
				{
					sum += r.MaxSkill;
					iCount++;
				}
				return ( sum / iCount );
			}
		}
		public string SectionName
		{
			get { return sectName;		}
			set { sectName = value;		}
		}
		public ushort SoundPlayed
		{
			get { return soundPlayed;	}
			set { soundPlayed = value;	}
		}
		public byte MinRank
		{
			get { return minRank;		}
			set { minRank = value;		}
		}
		public byte MaxRank
		{
			get { return maxRank;		}
			set { maxRank = value;		}
		}
		public string AddItem
		{
			get { return addItem;		}
			set { addItem = value;		}
		}
		public short Delay
		{
			get { return delay;			}
			set { delay = value;		}
		}
		public ushort Spell
		{
			get	{ return spell;			}
			set	{ spell = value;		}
		}
		public ArrayList ResourceNeeded
		{
			get { return resourceNeeded;	}
		}
		public ArrayList SkillReqs
		{
			get { return skillReqs;			}
		}
		public byte SpellCircle
		{
			get { return (byte)(spell/10);	}
		}
		public byte SpellWithinCircle
		{
			get { return (byte)(spell%10);	}
		}
	}


}

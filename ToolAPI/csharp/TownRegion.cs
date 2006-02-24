using System;
using System.Collections;
using System.Collections.Specialized;

namespace UOXData.Region
{
	public class MiningData
	{
		#region "Protected Data"
		protected ushort	colour;
		protected ushort	minSkill;
		protected string	name;
		protected bool		foreign;
		protected int		makeMenu;
		protected byte		minAmount;
		#endregion "Protected Data"
		#region "Public Properties"
		public ushort	Colour		{	get {	return colour;		}	set {	colour = value;		}	}
		public ushort	MinSkill	{	get {	return minSkill;	}	set {	minSkill = value;	}	}
		public string	Name		{	get {	return name;		}	set {	name = value;		}	}
		public bool		Foreign		{	get {	return foreign;		}	set {	foreign = value;	}	}
		public int		MakeMenu	{	get {	return makeMenu;	}	set {	makeMenu = value;	}	}
		public byte		MinAmount	{	get {	return minAmount;	}	set {	minAmount = value;	}	}
		#endregion "Public Properties"
		public MiningData()
		{
			colour		= 0;
			minSkill	= 0;
			name		= "";
			foreign		= false;
			makeMenu	= 0;
			minAmount	= 0;
		}
	}

	public class OrePreference
	{
		#region "Protected Data"
		protected MiningData	oreIndex;
		protected byte			percentChance;
		#endregion "Protected Data"
		#region "Public Properties"
		public MiningData	OreData			{	get {	return oreIndex;		}	set {	oreIndex = value;		}	}
		public byte			PercentChance	{	get {	return percentChance;	}	set {	percentChance = value;	}	}
		#endregion "Public Properties"
		public OrePreference()
		{
			oreIndex		= new MiningData();
			percentChance	= 0;
		}
	}

	public enum WorldType
	{
		Spring = 0,
		Summer,
		Autumn,
		Winter,
		Desolation,
		Unknown,
		Count
	}

	public class GoodData
	{
		#region "Protected Data"
		protected int	sellVal;
		protected int	buyVal;
		protected int	rand1;
		protected int	rand2;
		#endregion "Protected Data"
		#region "Public Properties"
		public int	SellValue	{	get {	return sellVal;	}	set {	sellVal = value;	}	}
		public int	BuyValue	{	get {	return buyVal;	}	set {	buyVal = value;		}	}
		public int	Rand1		{	get {	return rand1;	}	set {	rand1 = value;		}	}
		public int	Rand2		{	get {	return rand2;	}	set {	rand2 = value;		}	}
		#endregion "Public Properties"
		public GoodData()
		{
			sellVal	= 0;
			buyVal	= 0;
			rand1	= 0;
			rand2	= 0;
		}
	}

	public struct Box
	{
		short	x1;
		short	x2;
		short	y1;
		short	y2;

		public Box( short xv1, short xv2, short yv1, short yv2 )
		{
			x1	= xv1;
			x2	= xv2;
			y1	= yv1;
			y2	= yv2;
		}
	}

	public class TownPerson
	{
		#region "Protected Data"
		protected uint	townMember;		// SERIAL
		protected uint	targVote;		// SERIAL
		protected uint	playerBank;		// SERIAL
		#endregion "Protected Data"
		#region "Public Properties"
		public uint	TownMember		{	get	{	return townMember;	}	set	{	townMember = value;	}	}
		public uint	TargVote		{	get	{	return townMember;	}	set	{	townMember = value;	}	}
		public uint	PlayerBank		{	get	{	return townMember;	}	set	{	townMember = value;	}	}
		#endregion "Public Properties"
		public TownPerson()
		{
			playerBank	= 0xFFFFFFFF;
			targVote	= 0xFFFFFFFF;
			townMember	= 0xFFFFFFFF;
		}
		public TownPerson( uint tVote, uint tMember )
		{
			targVote	= tVote;
			townMember	= tMember;
			playerBank	= 0xFFFFFFFF;
		}
	}
	/// <summary>
	/// Summary description for TownRegion.
	/// </summary>
	public class TownRegion : Script.ScriptSectionLoadable
	{
		#region "Protected Data"
		protected byte			regionNum;
		protected string		name;
		protected ushort		midiList;
		protected byte			worldNumber;
		protected BitVector32	priv;

		protected string		guardowner;
		protected ArrayList		guards;				// array of strings			(string)
		protected ArrayList		orePreferences;		// array of orePref			(OrePreference)
		protected ArrayList		townMember;			// array of townPers
		protected ArrayList		alliedTowns;		// array of byte			(byte)
		protected ArrayList		locations;			// array of locations		(Box)
		protected Hashtable		goodList;			// map of SI32, GoodData_st	(GoodData)
		protected string		guardList;
		protected ushort		numGuards;
		protected uint			mayorSerial;
		protected ushort		race;
		protected byte			weather;
		protected int			goldReserved;

		protected long			timeSinceGuardsPaid;
		protected long			timeSinceTaxedMembers;
		protected long			timeToElectionClose;
		protected long			timeToNextPoll;

		protected short			guardsPurchased;
		protected int			resourceCollected;
		protected ushort		taxedResource;
		protected ushort		taxedAmount;
		protected WorldType		visualAppearance;
		protected short			health;
		protected byte			chanceFindBigOre;
		protected ushort		jsScript;
		#endregion "Protected Data"
		#region "Public Properties"
		public byte RegionNum						{ get { return regionNum;				}	set {	regionNum = value;				}	}
		public string		Name					{ get { return name;					}	set {	name = value;					}	}
		public ushort		MidiList				{ get { return midiList;				}	set {	midiList = value;				}	}
		public byte			WorldNumber				{ get { return worldNumber;				}	set {	worldNumber = value;			}	}
		protected BitVector32	Priv				{ get { return priv;					}	set {	priv = value;					}	}

		public string		GuardOwner				{ get { return guardowner;				}	set {	guardowner = value;				}	}
		public ArrayList	Guards					{ get { return guards;					}	set {	guards = value;					}	}
		public ArrayList	OrePreferences			{ get { return orePreferences;			}	set {	orePreferences = value;			}	}
		public ArrayList	TownMember				{ get { return townMember;				}	set {	townMember = value;				}	}
		public ArrayList	AlliedTowns				{ get { return alliedTowns;				}	set {	alliedTowns = value;			}	}
		public ArrayList	Locations				{ get { return locations;				}	set {	locations = value;				}	}
		public Hashtable	GoodList				{ get { return goodList;				}	set {	goodList = value;				}	}
		public string		GuardList				{ get { return guardList;				}	set {	guardList = value;				}	}
		public ushort		NumGuards				{ get { return numGuards;				}	set {	numGuards = value;				}	}
		public uint			MayorSerial				{ get { return mayorSerial;				}	set {	mayorSerial = value;			}	}
		public ushort		Race					{ get { return race;					}	set {	race = value;					}	}
		public byte			Weather					{ get { return weather;					}	set {	weather = value;				}	}
		public int			GoldReserved			{ get { return goldReserved;			}	set {	goldReserved = value;			}	}

		public long			TimeSinceGuardsPaid		{ get { return timeSinceGuardsPaid;		}	set {	timeSinceGuardsPaid = value;	}	}
		public long			TimeSinceTaxedMembers	{ get { return timeSinceTaxedMembers;	}	set {	timeSinceTaxedMembers = value;	}	}
		public long			TimeToElectionClose		{ get { return timeToElectionClose;		}	set {	timeToElectionClose = value;	}	}
		public long			TimeToNextPoll			{ get { return timeToNextPoll;			}	set {	timeToNextPoll = value;			}	}

		public short		GuardsPurchased			{ get { return guardsPurchased;			}	set {	guardsPurchased = value;		}	}
		public int			ResourceCollected		{ get { return resourceCollected;		}	set {	resourceCollected = value;		}	}
		public ushort		TaxedResource			{ get { return taxedResource;			}	set {	taxedResource = value;			}	}
		public ushort		TaxedAmount				{ get { return taxedAmount;				}	set {	taxedAmount = value;			}	}
		public WorldType	VisualAppearance		{ get { return visualAppearance;		}	set {	visualAppearance = value;		}	}
		public short		Health					{ get { return health;					}	set {	health = value;					}	}
		public byte			ChanceFindBigOre		{ get { return chanceFindBigOre;		}	set {	chanceFindBigOre = value;		}	}
		public ushort		JSScript				{ get { return jsScript;				}	set {	jsScript = value;				}	}

		public bool			IsGuarded				{ get { return priv[bitMasks[0]];		}	set {	priv[bitMasks[0]] = value;		}	}	//	0 -- 0x01
		public bool			CanMark					{ get { return priv[bitMasks[1]];		}	set {	priv[bitMasks[1]] = value;		}	}	//	1 -- 0x02
		public bool			CanGate					{ get { return priv[bitMasks[2]];		}	set {	priv[bitMasks[2]] = value;		}	}	//	2 -- 0x04
		public bool			CanRecall				{ get { return priv[bitMasks[3]];		}	set {	priv[bitMasks[3]] = value;		}	}	//	3 -- 0x08
		//	4 -- 0x10
		//	5 -- 0x20
		public bool			CanCastAggressive		{ get { return priv[bitMasks[6]];		}	set {	priv[bitMasks[6]] = value;		}	}	//	6 -- 0x40
		public bool			IsDungeon				{ get { return priv[bitMasks[7]];		}	set {	priv[bitMasks[7]] = value;		}	}	//	7 -- 0x80

		#endregion "Public Properties"
		private int[]			bitMasks = new int[8];

		public TownRegion()
		{
			//
			// TODO: Add constructor logic here
			//
			race					= 0;
			weather					= 255;
			midiList				= 0;
			mayorSerial				= 0xFFFFFFFF;
			taxedResource			= 0x0EED;
			taxedAmount				= 0;
			goldReserved			= 0;
			guardsPurchased			= 0;
			resourceCollected		= 0;
			visualAppearance		= WorldType.Spring;
			health					= 30000;
			timeToElectionClose		= 0;
			timeToNextPoll			= 0;
			timeSinceGuardsPaid		= 0;
			timeSinceTaxedMembers	= 0;
			worldNumber				= 0;
			jsScript				= 0xFFFF;
			chanceFindBigOre		= 0;
			numGuards				= 10;

			priv					= new System.Collections.Specialized.BitVector32( 0 );
			bitMasks[0]				= BitVector32.CreateMask();
			for( int i = 1; i < 8; ++i )
				bitMasks[i]			= BitVector32.CreateMask( bitMasks[i-1] );

			guards					= new ArrayList();;		// array of strings
			orePreferences			= new ArrayList();;		// array of orePref
			townMember				= new ArrayList();		// array of townPers
			alliedTowns				= new ArrayList();		// array of byte
			locations				= new ArrayList();		// array of locations
			goodList				= new Hashtable();		// map of SI32, GoodData_st

			name					= "the Wilderness";
			guardList				= "guard";
			guardowner				= "the Gods themselves";
		}

		public void Load( Script.ScriptSection toParse )
		{
			int actgood		= -1;
			short x1		= -1;
			short x2		= -1;
			short y1		= -1;
			short y2		= -1;
			foreach( Script.TagDataPair t in toParse.TagDataPairs )
			{
				string UTag	= t.Tag.ToUpper();
				switch( t.Tag[0] )
				{
					case 'A':
						if( UTag == "ABWEATH" )
							weather = t.Data.ToUInt08();
						else if( UTag == "APPEARANCE" )
						{
							visualAppearance = WorldType.Count;
							for( WorldType wt = WorldType.Spring; wt < WorldType.Count; wt++ )
							{
								if( t.Data.Value.ToUpper() == wt.ToString().ToUpper() )
								{
									visualAppearance = wt;
									break;
								}
							}
							if( visualAppearance == WorldType.Count )
								visualAppearance = WorldType.Unknown;
						}
						break;
					case 'b':
					case 'B':
						if( UTag == "BUYABLE" )
						{
							if( actgood > -1 )
								((GoodData)goodList[actgood]).BuyValue = t.Data.ToInt32();
//							else
//								Console.Error( 2, "regions dfn -> You must write BUYABLE after GOOD <num>!" );
						}
						break;
					case 'c':
					case 'C':
						if( UTag == "COLOURMINSKILL" )
							break;
						else if( UTag == "CHANCEFORBIGORE" )
							chanceFindBigOre = t.Data.ToUInt08();
						else if( UTag == "CHANCEFORCOLOUR" )
							break;
						break;
					case 'd':
					case 'D':
						if( UTag == "DUNGEON" )
							IsDungeon = (t.Data.ToInt32() == 1);
						break;
					case 'E':
						if( UTag == "ESCORTS" ) 
						{
							// Load the region number in the global array of valid escortable regions
//							if( t.Data.ToInt32() == 1 )
//								cwmWorldState->escortRegions.push_back( regionNum );
						} // End - Dupois
						break;
					case 'G':
						if( UTag == "GUARDOWNER" )
							guardowner = t.Data;
						else if( UTag == "GUARDNUM" )
							break;
						else if( UTag == "GUARDLIST" )
							guardList = t.Data;
						else if( UTag == "GUARDED" )
							IsGuarded = (t.Data.ToInt32() == 1);
						else if( UTag == "GATE" )
							CanGate = (t.Data.ToInt32() == 1);
						else if( UTag == "GOOD" )
							actgood = t.Data.ToInt32();
						break;
					case 'M':
						if( UTag == "MIDILIST" )
							midiList = t.Data.ToUInt16();
						else if( UTag == "MAGICDAMAGE" )
							CanCastAggressive = (t.Data.ToInt32() == 1);
						else if( UTag == "MARK" )
							CanMark = (t.Data.ToInt32() == 1);
						break;
					case 'N':
						if( UTag == "NAME" )
							name = t.Data.Value;	// was Substring( 0, 49 )
						else if( UTag == "NUMGUARDS" )
							numGuards = t.Data.ToUInt16();
						break;
					case 'o':
					case 'O':
						if( UTag == "OREPREF" )
						{
//							string numPart;
							string oreName;
							OrePreference toPush = new OrePreference();
							t.Data.Value		= t.Data.Value.Trim();
							oreName				= t.Data.Value.Split( ' ' )[0];
							toPush.OreData.Name	= oreName;
//							toPush.oreIndex = Skills->FindOre( oreName );
//							if( toPush.oreIndex != NULL )
//							{
//								if( t.Data.sectionCount( " " ) == 0 )
//									toPush.percentChance = 100 / Skills->GetNumberOfOres();
//								else
//									toPush.percentChance = t.Data.section( " ", 1, 1 ).toByte();
								orePreferences.Add( toPush );
//								orePreferences.push_back( toPush );
//								orePrefLoaded = true;
//							}
//							else
//								Console.Error( 2, "Invalid ore preference in region %i as %s", regionNum, oreName.c_str() );
						}
						break;
					case 'R':
						if( UTag == "RACE" )
							race = t.Data.ToUInt16();
						else if( UTag == "RECALL" )
							CanRecall = (t.Data.ToInt32() == 1);
						else if( UTag == "RANDOMVALUE" )
						{
							if( actgood > -1 )
							{
								GoodData workWith = ((GoodData)goodList[actgood]);
								string [] tSplit = t.Data.Value.Split( ' ' );
								if( tSplit.Length != 1 )
								{
									workWith.Rand1 = Conversion.ToInt32( tSplit[0] );
									workWith.Rand2 = Conversion.ToInt32( tSplit[1] );
								}
								else
								{
									workWith.Rand1 = t.Data.ToInt32();
									workWith.Rand2 = workWith.Rand1;
								}
								if( workWith.Rand2 < workWith.Rand1 )
								{
//									Console.Error( 2, " regions dfn -> You must write RANDOMVALUE NUM2[%i] greater than NUM1[%i].", goodList[actgood].rand2, goodList[actgood].rand1 );
									workWith.Rand2 = workWith.Rand1 = 0;
								}
							}
//							else
//								Console.Error( 2, " regions dfn -> You must write RANDOMVALUE after GOOD <num>!" );
						}
						break;
					case 's':
					case 'S':
						if( UTag == "SELLABLE" )
						{
							if( actgood > -1 )
								((GoodData)goodList[actgood]).SellValue = t.Data.ToInt32();
//							else
//								Console.Error( 2, " regions dfn -> You must write SELLABLE after GOOD <num>!" );
						}
						else if( UTag == "SPAWN" )
						{
//							UString sect = "PREDEFINED_SPAWN " + t.Data;
//							ScriptSection *predefSpawn = FileLookup->FindEntry( sect, spawn_def );
//							if( predefSpawn == NULL )
//								Console.Warning( 2, "Undefined region spawn %s, check your regions.scp and spawn.scp files", t.Data.c_str() );
//							else
//							{
//								for( UI16 i = 0xFFFF; i > 0; --i )
//								{
//									if( cwmWorldState->spawnRegions.find( i ) != cwmWorldState->spawnRegions.end() )
//									{
//										CSpawnRegion *spawnReg			= new CSpawnRegion( i );
//										cwmWorldState->spawnRegions[i]	= spawnReg;
//										if( spawnReg != NULL )
//										{
//											spawnReg->SetX1( locations[locations.size() - 1].x1 );
//											spawnReg->SetY1( locations[locations.size() - 1].y1 );
//											spawnReg->SetX2( locations[locations.size() - 1].x2 );
//											spawnReg->SetY2( locations[locations.size() - 1].y2 );
//											spawnReg->Load( predefSpawn );
//										}
//										break;
//									}
//								}
//							}
						}
						else if( UTag == "SCRIPT" )
							jsScript = t.Data.ToUInt16();
						break;
					case 'W':
						if( UTag == "WORLD" )
							worldNumber = t.Data.ToUInt08();
						break;
					case 'x':
					case 'X':
						if( UTag == "X1" )
							x1 = t.Data.ToInt16();
						else if( UTag == "X2" )
							x2 = t.Data.ToInt16();
						break;
					case 'y':
					case 'Y':
						if( UTag == "Y1" )
							y1 = t.Data.ToInt16();
						else if( UTag == "Y2" )
						{
							y2 = t.Data.ToInt16();
							locations.Add( new Box( x1, x2, y1, y2 ) );
						}
						break;
				}
			}
		}
		public void Load( Script.WorldSection toParse )
		{
			int location	= -1;
			foreach( Script.TagDataPair t in toParse.TagDataPairs )
			{
				string UTag	= t.Tag.ToUpper();
				switch( t.Tag[0] )
				{
					case 'A':
						if( UTag == "ALLYTOWN" )
							alliedTowns.Add( t.Data.ToUInt08() );
						break;
					case 'E':
						if( UTag == "ELECTIONTIME" )
							timeToElectionClose = t.Data.ToInt32();
						break;
					case 'G':
						if( UTag == "GUARDOWNER" )
							guardowner = t.Data;
						else if( UTag == "GUARD" )	// load our purchased guard
							++numGuards;
						else if( UTag == "GUARDSBOUGHT" ) // num guards bought
							guardsPurchased = t.Data.ToInt16();
						break;
					case 'H':
						if( UTag == "HEALTH" )
							health = t.Data.ToInt16();
						break;
					case 'M':
						if( UTag == "MEMBER" )
						{
							location	= townMember.Count;
							townMember.Add( new TownPerson( 0xFFFFFFFF, t.Data.ToUInt32() ) );
						}
						else if( UTag == "MAYOR" )
							mayorSerial = t.Data.ToUInt32();
						break;
					case 'N':
						if( UTag == "NAME" )
							name = t.Data.Value;	// was Substring( 0, 49 )
						else if( UTag == "NUMGUARDS" )
							numGuards = t.Data.ToUInt16();
						break;
					case 'P':
						if( UTag == "PRIV" )
						{
							byte tempData	= t.Data.ToUInt08();
							int multVal		= 1;
							for( int i = 0; i < 8; i++ )
							{
								if( (tempData&multVal) == multVal )
									priv[i] = true;
								multVal *= 2;
							}
						}
						else if( UTag == "POLLTIME" )
							timeToNextPoll = t.Data.ToInt32();
						break;
					case 'R':
						if( UTag == "RACE" )
							race = t.Data.ToUInt16();
						else if( UTag == "RESOURCEAMOUNT" )
							goldReserved = t.Data.ToInt32();
						else if( UTag == "RESOURCECOLLECTED" )
							resourceCollected = t.Data.ToInt32();
						break;
					case 'T':
						if( UTag == "TAXEDID" )
							taxedResource = t.Data.ToUInt16();
						else if( UTag == "TAXEDAMOUNT" )
							taxedAmount = t.Data.ToUInt16();
						else if( UTag == "TIMET" )
							timeSinceTaxedMembers = t.Data.ToInt32();
						else if( UTag == "TIMEG" )
							timeSinceGuardsPaid = t.Data.ToInt32();
						break;
					case 'V':
						if( UTag == "VOTE" && location != -1 )
							((TownPerson)townMember[location]).TargVote = t.Data.ToUInt32();
						break;
					case 'W':
						if( UTag == "WORLD" )
							worldNumber = t.Data.ToUInt08();
						break;
				}
			}
		}
	}
}

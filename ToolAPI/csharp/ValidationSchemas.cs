// created on 12/02/2003 at 6:56 PM
using System;
using System.IO;
using System.Collections;
using System.Globalization;
using System.Reflection;

namespace UOXData.Script.Validation
{
	public enum ValueTypes
	{
		String	= 0,
		UppercaseString,
		Numeric,
		NumericFloat,
		DoubleNumeric,
		DoubleNumericFloat,
		Location,
		NoData,
		Boolean,
		Tokens,
		Unknown,
		Count
	}

	#region "Valid Value classes"
	public abstract class BaseValidValue
	{
		protected ValueTypes	vType;
		public BaseValidValue()
		{
			vType = ValueTypes.Count;
		}
		public abstract bool Valid( string toValidate );
		public ValueTypes ValueType { get { return vType; } }
	}

	public class ValidValueNoData : BaseValidValue
	{
		public ValidValueNoData() : base()
		{
			vType	= ValueTypes.NoData;
		}
		public bool Valid( object toValidate )
		{
			return true;
		}
		public override bool Valid( string toValidate )
		{
			return true;
		}
	}
	public class ValidValueUnknown : BaseValidValue
	{
		public ValidValueUnknown() : base()
		{
			vType	= ValueTypes.Unknown;
		}
		public bool Valid( object toValidate )
		{
			return false;
		}
		public override bool Valid( string toValidate )
		{
			return false;
		}
	}
	public class ValidValueString : BaseValidValue
	{
		protected ArrayList	validStrings;
		public ValidValueString() : base()
		{
			vType			= ValueTypes.String;
			validStrings	= new ArrayList();
		}
		public ValidValueString( string[] vStrings ) : base()
		{
			vType			= ValueTypes.String;
			validStrings	= new ArrayList();
			for( int i = 0; i < vStrings.Length; ++i )
				validStrings.Add( vStrings[i] );
		}
		public override bool Valid( string toValidate )
		{
			if( validStrings.Count == 0 )
				return true;
			bool retVal = false;
			foreach( string s in validStrings )
			{
				if( toValidate == s )
				{
					retVal = true;
					break;
				}
			}
			return retVal;
		}
	}
	public class ValidValueUppercaseString : BaseValidValue
	{
		protected ArrayList	validStrings;
		public ValidValueUppercaseString() : base()
		{
			vType			= ValueTypes.UppercaseString;
			validStrings	= new ArrayList();
		}
		public ValidValueUppercaseString( string[] vStrings ) : base()
		{
			vType			= ValueTypes.String;
			validStrings	= new ArrayList();
			for( int i = 0; i < vStrings.Length; ++i )
				validStrings.Add( vStrings[i].ToUpper() );
		}
		public override bool Valid( string toValidate )
		{
			if( validStrings.Count == 0 )
			{
				return ( toValidate == toValidate.ToUpper() );
			}
			bool retVal = false;
			foreach( string s in validStrings )
			{
				if( toValidate == s )
				{
					retVal = true;
					break;
				}
			}
			return retVal;
		}
	}
	public class ValidValueNumeric : BaseValidValue
	{
		protected long	minValue;
		protected long	maxValue;
		public ValidValueNumeric() : base()
		{
			vType		= ValueTypes.Numeric;
			minValue	= long.MinValue;
			maxValue	= long.MaxValue;
		}
		public ValidValueNumeric( System.Type toEval ) : base()
		{
			FieldInfo mProp;
			vType		= ValueTypes.Numeric;
			mProp		= toEval.GetField( "MinValue" );
			minValue	= System.Convert.ToInt64( mProp.GetValue( null ) );
			mProp		= toEval.GetField( "MaxValue" );
			maxValue	= System.Convert.ToInt64( mProp.GetValue( null ) );
		}
		public ValidValueNumeric( long mnVal, long mxVal ) : base()
		{
			vType		= ValueTypes.Numeric;
			minValue	= mnVal;
			maxValue	= mxVal;
		}
		public bool Valid( long toValidate )
		{
			return (toValidate >= minValue && toValidate <= maxValue);
		}
		public override bool Valid( string toValidate )
		{
			long convertedValue	= 0;
			bool isHex			= toValidate.StartsWith( "0x" ) || toValidate.StartsWith( "0X" );
			string testing		= toValidate;
			try
			{
				if( isHex )
					convertedValue = long.Parse( toValidate.Substring(2), NumberStyles.HexNumber );
				else
					convertedValue = System.Convert.ToInt64( testing );
			}
			catch( Exception )
			{
				return false;
			}
			return Valid( convertedValue );
		}
	}
	public class ValidValueDoubleNumeric : BaseValidValue
	{
		ValidValueTokens	internalHiding;
		protected void InternalReset()
		{
			internalHiding				= new ValidValueTokens();
			internalHiding.MustMatch	= false;
			vType						= ValueTypes.DoubleNumeric;
		}
		protected void AddInternal( System.Type toEval )
		{
			internalHiding.Add( new ValidValueNumeric( toEval ) );
			internalHiding.Add( new ValidValueNumeric( toEval ) );
		}
		protected void AddInternal( System.Type type1, System.Type type2 )
		{
			internalHiding.Add( new ValidValueNumeric( type1 ) );
			internalHiding.Add( new ValidValueNumeric( type2 ) );
		}
		public ValidValueDoubleNumeric() : base()
		{
			InternalReset();
			AddInternal( typeof( long ) );
		}
		public ValidValueDoubleNumeric( System.Type toEval ) : base()
		{
			InternalReset();
			AddInternal( toEval );
		}
		public ValidValueDoubleNumeric( System.Type type1, System.Type type2 ) : base()
		{
			InternalReset();
			AddInternal( type1, type2 );
		}
		public ValidValueDoubleNumeric( string delimiter ) : base()
		{
			InternalReset();
			AddInternal( typeof( long ) );
			internalHiding.Delimiter = delimiter;
		}
		public ValidValueDoubleNumeric( System.Type toEval, string delimiter ) : base()
		{
			InternalReset();
			AddInternal( toEval );
			internalHiding.Delimiter = delimiter;
		}
		public ValidValueDoubleNumeric( System.Type type1, System.Type type2, string delimiter ) : base()
		{
			InternalReset();
			AddInternal( type1, type2 );
			internalHiding.Delimiter = delimiter;
		}
		public override bool Valid( string toValidate )
		{
			return internalHiding.Valid( toValidate );
		}
	}
	public class ValidValueNumericFloat : BaseValidValue
	{
		protected double	minValue;
		protected double	maxValue;
		public ValidValueNumericFloat() : base()
		{
			vType		= ValueTypes.NumericFloat;
			minValue	= double.MinValue;
			maxValue	= double.MaxValue;
		}
		public ValidValueNumericFloat( double mnVal, double mxVal ) : base()
		{
			vType		= ValueTypes.NumericFloat;
			minValue	= mnVal;
			maxValue	= mxVal;
		}
		public bool Valid( double toValidate )
		{
			return (toValidate >= minValue && toValidate <= maxValue);
		}
		public override bool Valid( string toValidate )
		{
			double convertedValue	= 0;
			string testing		= toValidate;
			try
			{
				convertedValue = System.Convert.ToDouble( testing );
			}
			catch( Exception )
			{
				return false;
			}
			return Valid( convertedValue );
		}
	}
	public class ValidValueDoubleNumericFloat : BaseValidValue
	{
		protected double[]	minValue = new double[2];
		protected double[]	maxValue = new double[2];
		public ValidValueDoubleNumericFloat() : base()
		{
			vType		= ValueTypes.DoubleNumericFloat;
			minValue[0]	= minValue[1] = double.MinValue;
			maxValue[0]	= maxValue[1] = double.MaxValue;
		}
		public ValidValueDoubleNumericFloat( double mnVal, double mxVal ) : base()
		{
			vType		= ValueTypes.DoubleNumericFloat;
			minValue[0]	= minValue[1] = mnVal;
			maxValue[0]	= maxValue[1] = mxVal;
		}
		public bool Valid( double valid1, double valid2 )
		{
			return ( ( valid1 >= minValue[0] && valid1 <= maxValue[0] ) && ( valid2 >= minValue[1] && valid2 <= maxValue[1] ) );
		}
		public override bool Valid( string toValidate )
		{
			bool has2Numbers			= false;
			double [] convertedValue	= new double[2];
			string [] splitNumbers		= toValidate.Split( ' ' );
			if( splitNumbers.Length != 1 && splitNumbers.Length != 2 )
				return false;
			has2Numbers				= (splitNumbers.Length == 2);

			for( int i = 0; i < 2; ++i )
			{
				if( i == 1 && !has2Numbers)
				{
					convertedValue[1] = convertedValue[0];
					break;
				}
				string testing		= splitNumbers[i];
				try
				{
					convertedValue[i] = System.Convert.ToDouble( testing );
				}
				catch( Exception )
				{
					return false;
				}
			}
			return Valid( convertedValue[0], convertedValue[1] );
		}
	}
	public class ValidValueLocation : BaseValidValue
	{
		public ValidValueLocation() : base()
		{
			vType		= ValueTypes.Location;
		}
		public override bool Valid( string toValidate )
		{
			string [] splitNumbers	= toValidate.Split( ',' );
			if( splitNumbers.Length < 2 || splitNumbers.Length > 4 )
				return false;
			for( int i = 0; i < splitNumbers.Length; ++i )
			{
				long tempVal		= -1;
				bool isHex			= splitNumbers[i].StartsWith( "0x" ) || splitNumbers[i].StartsWith( "0X" );
				string testing		= splitNumbers[i];
				try
				{
					if( isHex )
						tempVal = long.Parse( splitNumbers[i].Substring(2), NumberStyles.HexNumber );
					else
						tempVal = System.Convert.ToInt64( testing );
				}
				catch( Exception )
				{
					return false;
				}
				switch( i )
				{	// x, y, z, worldNumber
					case 0:	
						if( tempVal < short.MinValue || tempVal > short.MaxValue )
							return false;
						break;
					case 1:
						if( tempVal < short.MinValue || tempVal > short.MaxValue )
							return false;
						break;
					case 2:
						if( tempVal < sbyte.MinValue || tempVal > sbyte.MaxValue )
							return false;
						break;
					case 3:
						if( tempVal < byte.MinValue || tempVal > byte.MaxValue )
							return false;
						break;
				}
			}
			return true;
		}
	}
	public class ValidValueBoolean : BaseValidValue
	{
		public ValidValueBoolean() : base()
		{
			vType			= ValueTypes.Boolean;
		}
		public override bool Valid( string toValidate )
		{
			bool retVal		= false;
			string trimmed	= toValidate.Trim().ToUpper();
			retVal = ( trimmed == "YES" || trimmed == "NO" || trimmed == "TRUE" || trimmed == "FALSE" );
			if( !retVal )
			{
				bool isHex			= trimmed.StartsWith( "0x" ) || trimmed.StartsWith( "0X" );
				string testing		= trimmed;
				try
				{
					long convertedValue;
					if( isHex )
						convertedValue = long.Parse( testing.Substring(2), NumberStyles.HexNumber );
					else
						convertedValue = System.Convert.ToInt64( testing );
					retVal = true;
				}
				catch( Exception )
				{
					retVal = false;
				}
			}
			return retVal;
		}
	}
	public class ValidValueTokens : BaseValidValue
	{
		protected ArrayList tokens;
		protected string	delimiter;
		protected bool		mustMatch;

		public string	Delimiter { get { return delimiter; } set { delimiter = value; } }
		public bool		MustMatch { get { return mustMatch; } set { mustMatch = value; } }

		public void Add( BaseValidValue toAdd )
		{
			tokens.Add( toAdd );
		}
		protected void InternalReset()
		{
			vType			= ValueTypes.Tokens;
			tokens			= new ArrayList();
			delimiter		= " ";
			mustMatch		= true;
		}
		public ValidValueTokens() : base()
		{
			InternalReset();
		}
		public  ValidValueTokens( BaseValidValue [] toAdd ) : base()
		{
			InternalReset();
			for( int i = 0; i < toAdd.Length; ++i )
				tokens.Add( toAdd[i] );
		}
		public  ValidValueTokens( BaseValidValue [] toAdd, string del ) : base()
		{
			InternalReset();
			for( int i = 0; i < toAdd.Length; ++i )
				tokens.Add( toAdd[i] );
			delimiter = del;
		}
		public ValidValueTokens( bool mMatch ) : base()
		{
			InternalReset();
			mustMatch = mMatch;
		}
		public  ValidValueTokens( BaseValidValue [] toAdd, bool mMatch ) : base()
		{
			InternalReset();
			for( int i = 0; i < toAdd.Length; ++i )
				tokens.Add( toAdd[i] );
			mustMatch = mMatch;
		}
		public  ValidValueTokens( BaseValidValue [] toAdd, string del, bool mMatch ) : base()
		{
			InternalReset();
			for( int i = 0; i < toAdd.Length; ++i )
				tokens.Add( toAdd[i] );
			delimiter = del;
			mustMatch = mMatch;
		}
		public override bool Valid( string toValidate )
		{
			if( tokens.Count == 0 )
				return true;
			string [] splitString = toValidate.Split( delimiter.ToCharArray() );
			if( splitString.Length != tokens.Count && mustMatch )
				return false;
			for( int i = 0; i < Math.Min( splitString.Length, tokens.Count ); ++i )
			{
				if( !((BaseValidValue)tokens[i]).Valid( splitString[i] ) )
					return false;
			}
			return true;
		}
	}
	#endregion "Valid Value classes"
	public class ValidateError
	{
		protected string		tagName;
		protected ValueTypes	expectedType;
		protected string		tagValue;
		protected string		errorMsg;
		public ValidateError()
		{
			tagName			= "";
			expectedType	= ValueTypes.Count;
			tagValue		= "";
			errorMsg		= "";
		}
		public ValidateError( string tName, ValueTypes eType, string val )
		{
			tagName			= tName;
			expectedType	= eType;
			tagValue		= val;
			errorMsg		= "";
		}
		public ValidateError( string tName, ValueTypes eType, string val, string eMsg )
		{
			tagName			= tName;
			expectedType	= eType;
			tagValue		= val;
			errorMsg		= eMsg;
		}
		public string		Tag				{ get { return tagName;			} }
		public ValueTypes	ExpectedType	{ get { return expectedType;	} }
		public string		Value			{ get { return tagValue;		} }
		public string		ErrorMessage	{ get { return errorMsg;		} }
	}

	namespace Schemas
	{
		public abstract class BaseSchema
		{
			protected Hashtable tagValueCompare;

			public BaseSchema()
			{
				tagValueCompare = new Hashtable();
				InternalReset();
				BuildSchema();
			}

			protected virtual void InternalReset()
			{
			}

			protected virtual void BuildSchema()
			{
			}

			protected virtual bool ValidatePair( TagDataPair t, ArrayList errorLog )
			{
				bool retVal = false;
				if( tagValueCompare.ContainsKey( t.Tag ) )
				{
					BaseValidValue mValue = (BaseValidValue)tagValueCompare[t.Tag];
					if( !mValue.Valid( t.Data.Value ) )
						errorLog.Add( new ValidateError( t.Tag, mValue.ValueType, t.Data.Value, "Failed validation test" ) );
					else
						retVal = true;
				}
				else
					errorLog.Add( new ValidateError( t.Tag, ValueTypes.Unknown, t.Data.Value, "Tag does not exist in schema" ) );
				return retVal;
			}
			public bool ValidateSection( Section toValidate, ArrayList errorLog )
			{
				if( toValidate != null )
				{
					errorLog.Clear();
					foreach( TagDataPair t in toValidate.TagDataPairs )
					{
						ValidatePair( t, errorLog );
					}
					return ( errorLog.Count != 0 );
				}
				else
					return false;
			}
			public virtual ScriptSection SanitiseSection( Section toValidate, ArrayList errorLog )
			{
				ScriptSection toReturn = new ScriptSection();
				if( toValidate != null )
				{
					foreach( TagDataPair t in toValidate.TagDataPairs )
					{
						if( ValidatePair( t, errorLog ) )
							toReturn.Add( t.Tag, t.Data.Value );
					}
				}
				return toReturn;
			}
		}

		public class RaceSchema : BaseSchema
		{
			public RaceSchema() : base()
			{
			}
			protected override void BuildSchema()
			{
				tagValueCompare.Add( "ARMORREST",		new ValidValueNumeric( typeof( byte   ) )			);
				tagValueCompare.Add( "BEARDMIN",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "BEARDMAX",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "BEARD",			new ValidValueDoubleNumeric( typeof( ushort ) )	);

				tagValueCompare.Add( "COLDAFFECT",		new ValidValueNoData()								);
				tagValueCompare.Add( "COLDLEVEL",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "COLDDAMAGE",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "COLDSECS",		new ValidValueNumeric( typeof( ushort ) )			);

				tagValueCompare.Add( "DEXCAP",			new ValidValueNumeric( typeof( ushort ) )			);

				tagValueCompare.Add( "GENDER",			new ValidValueString( new string[2] { "MALE", "FEMALE" } )	);

				tagValueCompare.Add( "HAIRMIN",			new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "HAIRMAX",			new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "HAIR",			new ValidValueDoubleNumeric( typeof( ushort ) )		);
				tagValueCompare.Add( "HEATAFFECT",		new ValidValueNoData()								);
				tagValueCompare.Add( "HEATLEVEL",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "HEATDAMAGE",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "HEATSECS",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "HUNGER",			new ValidValueDoubleNumeric( typeof( ushort ), typeof( short ) )	);

				tagValueCompare.Add( "INTCAP",			new ValidValueNumeric( typeof( ushort ) )			);

				tagValueCompare.Add( "LIGHTAFFECT",		new ValidValueNoData()								);
				tagValueCompare.Add( "LIGHTLEVEL",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "LIGHTDAMAGE",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "LIGHTSECS",		new ValidValueNumeric( typeof( ushort ) )			);

				tagValueCompare.Add( "LIGHTNINGAFFECT",	new ValidValueNoData()								);
				tagValueCompare.Add( "LIGHTNINGLEVEL",	new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "LIGHTNINGCHANCE",	new ValidValueNumeric( typeof( ushort ) )			);

				tagValueCompare.Add( "LANGUAGEMIN",		new ValidValueNumeric( typeof( ushort ) )			);

				tagValueCompare.Add( "MAGICRESISTANCE",	new ValidValueNumericFloat()						);
				tagValueCompare.Add( "MANAMOD",			new ValidValueNumeric( typeof( short  ) )			);

				tagValueCompare.Add( "NAME",			new ValidValueString()								);
				tagValueCompare.Add( "NOBEARD",			new ValidValueNoData()								);
				tagValueCompare.Add( "NIGHTVIS",		new ValidValueNumeric( typeof( byte   ) )			);

				tagValueCompare.Add( "PLAYERRACE",		new ValidValueNumeric( typeof( byte   ) )			);
				tagValueCompare.Add( "POISONRESISTANCE",	new ValidValueNumericFloat()					);
				tagValueCompare.Add( "PARENTRACE",		new ValidValueNumeric( typeof( ushort ) )			);

				tagValueCompare.Add( "REQUIREBEARD",	new ValidValueNoData()								);
				tagValueCompare.Add( "RAINAFFECT",		new ValidValueNoData()								);
				tagValueCompare.Add( "RAINDAMAGE",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "RAINSECS",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "RACERELATION",	new ValidValueDoubleNumeric( typeof( sbyte ), typeof( ushort ) )	);
				tagValueCompare.Add( "RACIALENEMY",		new ValidValueNumeric( typeof( int    ) )			);
				tagValueCompare.Add( "RACIALAID",		new ValidValueNumeric( typeof( int    ) )			);

				tagValueCompare.Add( "STRCAP",			new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "SKINMIN",			new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "SKINMAX",			new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "SKIN",			new ValidValueDoubleNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "SNOWAFFECT",		new ValidValueNoData()								);
				tagValueCompare.Add( "SNOWDAMAGE",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "SNOWSECS",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "STORMAFFECT",		new ValidValueNoData()								);
				tagValueCompare.Add( "STORMDAMAGE",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "STORMSECS",		new ValidValueNumeric( typeof( ushort ) )			);
				tagValueCompare.Add( "STAMMOD",			new ValidValueNumeric( typeof( short  ) )			);
				tagValueCompare.Add( "VISRANGE",		new ValidValueNumeric( typeof( sbyte  ) )			);

				for( Skills v = Skills.ALCHEMY; v < Skills.ALLSKILLS; ++v )
				{
					tagValueCompare.Add( v.ToString() + "G", new ValidValueNumeric( typeof( ushort ) ) );
					tagValueCompare.Add( v.ToString() + "L", new ValidValueNumeric( typeof( ushort ) ) );
				}
			}

		}
		public class SpawnRegionSchema : BaseSchema
		{
			public SpawnRegionSchema() : base()
			{
			}
			protected override void BuildSchema()
			{
				tagValueCompare.Add( "CALL",			new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "ITEM",			new ValidValueString()						);
				tagValueCompare.Add( "ITEMLIST",		new ValidValueString()						);
				tagValueCompare.Add( "MAXITEMS",		new ValidValueNumeric( typeof( uint  ) )	);
				tagValueCompare.Add( "MAXNPCS",			new ValidValueNumeric( typeof( uint  ) )	);
				tagValueCompare.Add( "MAXTIME",			new ValidValueNumeric( typeof( byte  ) )	);
				tagValueCompare.Add( "MINTIME",			new ValidValueNumeric( typeof( byte  ) )	);
				tagValueCompare.Add( "NAME",			new ValidValueString()						);
				tagValueCompare.Add( "NPC",				new ValidValueString()						);
				tagValueCompare.Add( "NPCLIST",			new ValidValueString()						);
				tagValueCompare.Add( "VALIDLANDPOS",	new ValidValueLocation()					);
				tagValueCompare.Add( "VALIDWATERPOS",	new ValidValueLocation()					);
				tagValueCompare.Add( "WORLD",			new ValidValueNumeric( typeof( byte   ) )	);
				tagValueCompare.Add( "X1",				new ValidValueNumeric( typeof( short ) )	);
				tagValueCompare.Add( "X2",				new ValidValueNumeric( typeof( short ) )	);
				tagValueCompare.Add( "Y1",				new ValidValueNumeric( typeof( short ) )	);
				tagValueCompare.Add( "Y2",				new ValidValueNumeric( typeof( short ) )	);
			}

		}
		public class TownRegionSchema : BaseSchema
		{
			public TownRegionSchema() : base()
			{
			}
			protected override void BuildSchema()
			{
				tagValueCompare.Add( "ABWEATH",			new ValidValueNumeric( typeof( byte ) )		);
				tagValueCompare.Add( "APPEARANCE",		new ValidValueString( new string[] { Region.WorldType.Spring.ToString(), Region.WorldType.Autumn.ToString(), Region.WorldType.Desolation.ToString(), Region.WorldType.Summer.ToString(), Region.WorldType.Winter.ToString() }  )						);
				tagValueCompare.Add( "BUYABLE",			new ValidValueNumeric( typeof( int  ) )		);
				tagValueCompare.Add( "COLOURMINSKILL",	new ValidValueNoData()						);
				tagValueCompare.Add( "CHANCEFORBIGORE",	new ValidValueNumeric( typeof( byte  ) )	);
				tagValueCompare.Add( "CHANCEFORCOLOUR",	new ValidValueNoData()						);
				tagValueCompare.Add( "DUNGEON",			new ValidValueBoolean()						);
				tagValueCompare.Add( "ESCORTS",			new ValidValueBoolean()						);
				tagValueCompare.Add( "GUARDNUM",		new ValidValueNoData()						);
				tagValueCompare.Add( "GUARDLIST",		new ValidValueString()						);
				tagValueCompare.Add( "GUARDOWNER",		new ValidValueString()						);
				tagValueCompare.Add( "GUARDED",			new ValidValueBoolean()						);
				tagValueCompare.Add( "GATE",			new ValidValueBoolean()						);
				tagValueCompare.Add( "GOOD",			new ValidValueNumeric( typeof( int    ) )	);
				tagValueCompare.Add( "MIDILIST",		new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "MAGICDAMAGE",		new ValidValueBoolean()						);
				tagValueCompare.Add( "MARK",			new ValidValueBoolean()						);
				tagValueCompare.Add( "NAME",			new ValidValueString()						);
				tagValueCompare.Add( "OREPREF",			new ValidValueTokens( new BaseValidValue [] { new ValidValueString(), new ValidValueNumeric( typeof( byte ) ) } )						);
				tagValueCompare.Add( "RECALL",			new ValidValueBoolean()						);
				tagValueCompare.Add( "RANDOMVALUE",		new ValidValueDoubleNumeric( typeof( int ) )	);
				tagValueCompare.Add( "RACE",			new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "SELLABLE",		new ValidValueNumeric( typeof( int    ) )	);
				tagValueCompare.Add( "SPAWN",			new ValidValueString()						);
				tagValueCompare.Add( "SCRIPT",			new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "WORLD",			new ValidValueNumeric( typeof( byte   ) )	);
				tagValueCompare.Add( "X1",				new ValidValueNumeric( typeof( short  ) )	);
				tagValueCompare.Add( "X2",				new ValidValueNumeric( typeof( short  ) )	);
				tagValueCompare.Add( "Y1",				new ValidValueNumeric( typeof( short  ) )	);
				tagValueCompare.Add( "Y2",				new ValidValueNumeric( typeof( short  ) )	);
			}

		}
		public class MidiListSchema : BaseSchema
		{
			public MidiListSchema() : base()
			{
			}
			protected override void BuildSchema()
			{
				tagValueCompare.Add( "MIDI",			new ValidValueNumeric( typeof( sbyte ) )		);
			}

		}
		public class InstaLogSchema : BaseSchema
		{
			public InstaLogSchema() : base()
			{
			}
			protected override void BuildSchema()
			{
				tagValueCompare.Add( "X1",			new ValidValueNumeric( typeof( short ) )		);
				tagValueCompare.Add( "X2",			new ValidValueNumeric( typeof( short ) )		);
				tagValueCompare.Add( "Y1",			new ValidValueNumeric( typeof( short ) )		);
				tagValueCompare.Add( "Y2",			new ValidValueNumeric( typeof( short ) )		);
			}

		}
		public class CarveSchema : BaseSchema
		{
			public CarveSchema() : base()
			{
			}
			protected override void BuildSchema()
			{
				tagValueCompare.Add( "ADDITEM", new ValidValueTokens( new BaseValidValue [] { new ValidValueString(), new ValidValueNumeric( typeof( ushort ) ) }, ",", false ) );
			}

		}
		public class CommandLevelsSchema : BaseSchema
		{
			protected ValidValueString	validStr;
			protected ValidValueNumeric	validNum;
			public CommandLevelsSchema() : base()
			{
				validStr = new ValidValueString();
				validNum = new ValidValueNumeric( typeof( byte ) );
			}
			protected override bool ValidatePair( TagDataPair t, ArrayList errorLog )
			{
				return validStr.Valid( t.Tag ) && validNum.Valid( t.Data.Value );
			}
		}
		public class CommandOverrideSchema : BaseSchema
		{
			protected ValidValueString	validStr;
			protected ValidValueNumeric	validNum;
			public CommandOverrideSchema() : base()
			{
				validStr = new ValidValueString();
				validNum = new ValidValueNumeric( typeof( byte ) );
			}
			protected override bool ValidatePair( TagDataPair t, ArrayList errorLog )
			{
				return validStr.Valid( t.Tag ) && validNum.Valid( t.Data.Value );
			}
		}
		public class CommandLevelIndivSchema : BaseSchema
		{
			public CommandLevelIndivSchema() : base()
			{
			}
			protected override void BuildSchema()
			{
				tagValueCompare.Add( "NICKCOLOUR",		new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "DEFAULTPRIV",		new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "BODYID",			new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "ALLSKILL",		new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "BODYCOLOUR",		new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "STRIPHAIR",		new ValidValueNoData()						);
				tagValueCompare.Add( "STRIPITEMS",		new ValidValueNoData()						);
			}

		}
		public class RandomColourSchema : BaseSchema
		{
			protected ValidValueNumeric	validNum;
			public RandomColourSchema() : base()
			{
				validNum = new ValidValueNumeric( typeof( ushort ) );
			}
			protected override bool ValidatePair( TagDataPair t, ArrayList errorLog )
			{
				return validNum.Valid( t.Tag );
			}
		}
		public class CreatureSchema : BaseSchema
		{
			public CreatureSchema() : base()
			{
			}
			protected override void BuildSchema()
			{
				tagValueCompare.Add( "ANTIBLINK",			new ValidValueNoData()						);
				tagValueCompare.Add( "ANIMAL",				new ValidValueNoData()						);
				tagValueCompare.Add( "BASESOUND",			new ValidValueNoData()						);
				tagValueCompare.Add( "FLIES",				new ValidValueNoData()						);
				tagValueCompare.Add( "ICON",				new ValidValueNoData()						);
				tagValueCompare.Add( "MOVEMENT",			new ValidValueUppercaseString( new string[] { "WATER", "BOTH" } )			);
				tagValueCompare.Add( "SOUNDFLAG",			new ValidValueNoData()						);
				tagValueCompare.Add( "SOUND_IDLE",			new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "SOUND_STARTATTACK",	new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "SOUND_ATTACK",		new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "SOUND_DEFEND",		new ValidValueNumeric( typeof( ushort ) )	);
				tagValueCompare.Add( "SOUND_DIE",			new ValidValueNumeric( typeof( ushort ) )	);
			}
		}
	}
}
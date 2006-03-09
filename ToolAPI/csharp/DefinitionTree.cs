using System;

namespace UOXData.Script
{
	/// <summary>
	/// Summary description for DefinitionTree.
	/// </summary>
	public class DefinitionTree
	{
		protected string					basePath;
		protected DefinitionCollection []	dfnCollection;
		public DefinitionTree( string bPath )
		{
			//
			// TODO: Add constructor logic here
			//
			basePath		= bPath;
			dfnCollection	= new DefinitionCollection[(int)DFN_Categories.NUM_DEFS];
			Load();
		}

		public ScriptSection FindEntry( string toFind, DFN_Categories toSearch )
		{
			return dfnCollection[(int)toSearch].FindEntry( toFind );
		}

		protected void Load()
		{
			for( DFN_Categories i = DFN_Categories.FIRST_DEF; i < DFN_Categories.NUM_DEFS; ++i )
			{
				dfnCollection[(int)i]	= new DefinitionCollection( i );
				string updPath			= basePath + i.ToString().ToLower();
				dfnCollection[(int)i].Load( updPath );
			}
		}

		public DefinitionCollection GetCollection( UOXData.Script.DFN_Categories toGet )
		{
			return dfnCollection[(int)toGet];
		}

		public static Validation.Schemas.BaseSchema ValidationSchema( ScriptSection toValidate )
		{
			return ValidationSchema( toValidate.Category, toValidate.SectionName );
		}
		public static Validation.Schemas.BaseSchema ValidationSchema( DFN_Categories toComp, string sectHeader )
		{
			Validation.Schemas.BaseSchema toReturn = null;
			switch( toComp )
			{
				case DFN_Categories.advance:
					break;
				case DFN_Categories.carve:
					if( sectHeader.StartsWith( "CARVE" ) )
						toReturn = new UOXData.Script.Validation.Schemas.CarveSchema();
					break;
				case DFN_Categories.colors:
					if( sectHeader.StartsWith( "RANDOMCOLOR" ) )
						toReturn = new UOXData.Script.Validation.Schemas.RandomColourSchema();
					break;
				case DFN_Categories.command:
					if( sectHeader == "COMMANDLEVELS" )
						toReturn = new UOXData.Script.Validation.Schemas.CommandLevelsSchema();
					else if( sectHeader == "COMMAND_OVERRIDE" )
						toReturn = new UOXData.Script.Validation.Schemas.CommandOverrideSchema();
					else
						toReturn = new UOXData.Script.Validation.Schemas.CommandLevelIndivSchema();
					break;
				case DFN_Categories.create:
					break;
				case DFN_Categories.creatures:
					if( sectHeader.StartsWith( "CREATURE" ) )
						toReturn = new UOXData.Script.Validation.Schemas.CreatureSchema();
					break;
				case DFN_Categories.harditems:
					break;
				case DFN_Categories.house:
					if( sectHeader.StartsWith( "HOUSE ITEM" ) )
						toReturn = new UOXData.Script.Validation.Schemas.HouseItemSchema();
					else if( sectHeader.StartsWith( "HOUSE " ) )
						toReturn = new UOXData.Script.Validation.Schemas.HouseSchema();
					break;
				case DFN_Categories.html:
					if( sectHeader.StartsWith( "DEFAULT_" ) )
						toReturn = new UOXData.Script.Validation.Schemas.HTMLSchema();
					break;
				case DFN_Categories.items:
					break;
				case DFN_Categories.location:
					if( sectHeader.StartsWith( "LOCATION" ) )
						toReturn = new UOXData.Script.Validation.Schemas.LocationSchema();
					break;
				case DFN_Categories.maps:
					if( sectHeader.StartsWith( "TILE" ) )
						toReturn = new UOXData.Script.Validation.Schemas.MapTileSchema();
					else if( sectHeader.StartsWith( "MAP" ) )
						toReturn = new UOXData.Script.Validation.Schemas.MapSchema();
					break;
				case DFN_Categories.menus:
					break;
				case DFN_Categories.misc:
					if( sectHeader.StartsWith( "BOOK" ) )
						toReturn = new UOXData.Script.Validation.Schemas.BookSchema();
					else if( sectHeader.StartsWith( "PAGE" ) )
						toReturn = new UOXData.Script.Validation.Schemas.PageSchema();
					else if( sectHeader.StartsWith( "GUMPTEXT" ) )
						toReturn = new UOXData.Script.Validation.Schemas.GumpTextSchema();
					else if( sectHeader.StartsWith( "GUMPMENU" ) )
						toReturn = new UOXData.Script.Validation.Schemas.GumpMenuSchema();
					else if( sectHeader.StartsWith( "MOTD" ) )
						toReturn = new UOXData.Script.Validation.Schemas.MOTDSchema();
					else if( sectHeader.StartsWith( "TIPS" ) )
						toReturn = new UOXData.Script.Validation.Schemas.TipsListSchema();
					else if( sectHeader.StartsWith( "TIP" ) )
						toReturn = new UOXData.Script.Validation.Schemas.TipSchema();
					break;
				case DFN_Categories.msgboard:
					if( sectHeader.StartsWith( "ESCORTS" ) )
						toReturn = new UOXData.Script.Validation.Schemas.EscortListSchema();
					else if( sectHeader.StartsWith( "ESCORT" ) )
						toReturn = new UOXData.Script.Validation.Schemas.EscortSchema();
					break;
				case DFN_Categories.newbie:
					if( sectHeader.StartsWith( "BESTSKILL" ) || sectHeader == "DEFAULT" )
						toReturn = new UOXData.Script.Validation.Schemas.NewbieSchema();
					break;
				case DFN_Categories.npc:
					break;
				case DFN_Categories.race:
					if( sectHeader.StartsWith( "RACE" ) )
						toReturn = new Validation.Schemas.RaceSchema();
					break;
				case DFN_Categories.regions:
					if( sectHeader.StartsWith( "REGION" ) )
						toReturn = new UOXData.Script.Validation.Schemas.TownRegionSchema();
					else if( sectHeader.StartsWith( "MIDILIST" ) )
						toReturn = new UOXData.Script.Validation.Schemas.MidiListSchema();
					else if( sectHeader.StartsWith( "INSTALOG" ) )
						toReturn = new UOXData.Script.Validation.Schemas.InstaLogSchema();
					break;
				case DFN_Categories.skills:
					if( sectHeader == "ORE_LIST" )
						toReturn = new UOXData.Script.Validation.Schemas.OreListSchema();
					else if( sectHeader.StartsWith( "SKILL" ) )
						toReturn = new UOXData.Script.Validation.Schemas.SkillSchema();
					else
						toReturn = new UOXData.Script.Validation.Schemas.OreSchema();
					break;
				case DFN_Categories.spawn:
					if( sectHeader.StartsWith( "REGIONSPAWN" ) )
						toReturn = new UOXData.Script.Validation.Schemas.SpawnRegionSchema();
					break;
				case DFN_Categories.spells:
					if( sectHeader.StartsWith( "SPELL" ) )
						toReturn = new UOXData.Script.Validation.Schemas.SpellSchema();
					break;
				case DFN_Categories.titles:
					if( sectHeader == "SKILL" )
						toReturn = new UOXData.Script.Validation.Schemas.SkillTitleSchema();
					else if( sectHeader == "PROWESS" )
						toReturn = new UOXData.Script.Validation.Schemas.ProwessSchema();
					else if( sectHeader == "FAME" )
						toReturn = new UOXData.Script.Validation.Schemas.FameSchema();
					else if( sectHeader == "MURDERER" )
						toReturn = new UOXData.Script.Validation.Schemas.MurdererSchema();
					break;
				case DFN_Categories.weather:
					if( sectHeader.StartsWith( "WEATHERAB" ) )
						toReturn = new UOXData.Script.Validation.Schemas.WeatherSchema();
					break;
			}
			return toReturn;
		}
	}
}

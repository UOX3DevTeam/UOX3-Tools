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
				case DFN_Categories.house:
				case DFN_Categories.html:
				case DFN_Categories.items:
				case DFN_Categories.location:
				case DFN_Categories.maps:
				case DFN_Categories.menus:
				case DFN_Categories.misc:
				case DFN_Categories.msgboard:
				case DFN_Categories.newbie:
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
					break;
				case DFN_Categories.spawn:
					if( sectHeader.StartsWith( "REGIONSPAWN" ) )
						toReturn = new UOXData.Script.Validation.Schemas.SpawnRegionSchema();
					break;
				case DFN_Categories.spells:
				case DFN_Categories.titles:
				case DFN_Categories.weather:
					break;
			}
			return toReturn;
		}
	}
}

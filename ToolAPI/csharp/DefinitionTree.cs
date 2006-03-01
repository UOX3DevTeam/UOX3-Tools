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
	}
}

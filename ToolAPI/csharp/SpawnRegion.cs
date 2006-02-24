using System;
using System.Collections;

namespace UOXData.Region
{
	/// <summary>
	/// Summary description for SpawnRegion.
	/// </summary>
	public class SpawnRegion : Script.ScriptSectionLoadable
	{
		protected string	name;
		protected ArrayList	sNpcs;
		protected ArrayList	sItems;
		protected ushort	regionnum;
		protected int		maxcspawn;
		protected int		maxispawn;
		protected int		curcspawn;
		protected int		curispawn;
		protected byte		mintime;
		protected byte		maxtime;
		protected int		nexttime;

		protected short		x1;
		protected short		x2;
		protected short		y1;
		protected short		y2;
		protected sbyte		prefZ;
		protected ushort	call;
		protected byte		worldNumber;

		protected Script.DefinitionTree	dfnTree;

		public SpawnRegion( Script.DefinitionTree toScan )
		{
			//
			// TODO: Add constructor logic here
			//
			nexttime	= 0;
			call		= 0;
			x1			= 0;
			x2			= 0;
			y1			= 0;
			y2			= 0;
			maxcspawn	= 0;
			maxispawn	= 0;
			maxtime		= 0;
			mintime		= 0;
			curcspawn	= 0;
			curispawn	= 0;
			worldNumber	= 0;
			prefZ		= 18;
			sNpcs		= new ArrayList();
			sItems		= new ArrayList();
			name		= "the Wilderness";

			dfnTree		= toScan;
		}

		public void Load( Script.ScriptSection toScan )
		{
			string UTag;

			ArrayList tagList = toScan.TagDataPairs;
			foreach( Script.TagDataPair t in tagList )
			{
				UTag = t.Tag.ToUpper();

				if( UTag == "NPCLIST" )
					LoadNPCList( t.Data );
				else if( UTag == "NPC" )
					sNpcs.Add( t.Data.Value );
				else if( UTag == "ITEMLIST" )
					LoadItemList( t.Data );
				else if( UTag == "ITEM" )
					sItems.Add( t.Data.Value );
				else if( UTag == "MAXITEMS" )
					maxispawn = t.Data.ToInt32();
				else if( UTag == "MAXNPCS" )
					maxcspawn = t.Data.ToInt32();
				else if( UTag == "X1" )
					x1 = t.Data.ToInt16();
				else if( UTag == "X2" )
					x2 = t.Data.ToInt16();
				else if( UTag == "Y1" )
					y1 = t.Data.ToInt16();
				else if( UTag == "Y2" )
					y2 = t.Data.ToInt16();
				else if( UTag == "MINTIME" )
					mintime = t.Data.ToUInt08();
				else if( UTag == "MAXTIME" )
					maxtime = t.Data.ToUInt08();
				else if( UTag == "NAME" )
					name = t.Data;
				else if( UTag == "CALL" )
					call = t.Data.ToUInt16();
				else if( UTag == "WORLD" )
					worldNumber = t.Data.ToUInt08();
				else if( UTag == "PREFZ" )
					prefZ = t.Data.ToInt08();
			}
		}
		public void LoadNPCList( string npcList )
		{
			string sect						= "NPCLIST " + npcList;
			Script.ScriptSection CharList	= dfnTree.FindEntry( sect, Script.DFN_Categories.npc );
			if( CharList != null )
			{
				foreach( Script.TagDataPair t in CharList.TagDataPairs )
				{
					if( t.Tag.ToUpper() == "NPCLIST" )
						LoadNPCList( t.Data.Value );
					else
						sNpcs.Add( t.Tag );
				}
			}
		}

		public void LoadItemList( string itemList )
		{
			string sect						= "ITEMLIST " + itemList;
			Script.ScriptSection ItemList	= dfnTree.FindEntry( sect, Script.DFN_Categories.items );
			if( ItemList != null )
			{
				foreach( Script.TagDataPair t in ItemList.TagDataPairs  )
				{
					if( t.Tag.ToUpper() == "ITEMLIST" )
						LoadItemList( t.Data.Value );
					else
						sItems.Add( t.Tag );
				}
			}
		}
	}
}

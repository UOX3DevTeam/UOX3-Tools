using System.Collections;

namespace CharacterExporter
{
	public enum ObjectType
	{
		OT_CBO = 0,
		OT_CHAR = 1,
		OT_ITEM = 2
	};

    public class ObjectHandler
	{
        #region "ProtectedData"
        protected uint nextItemSer;
        protected uint nextCharSer;
        protected ArrayList charList;
        protected ArrayList itemList;
        protected ArrayList importCharList;
        protected ArrayList importItemList;
        #endregion "ProtectedData"

        #region "Public Properties"	
        public ArrayList CharList       { get { return charList;        }									}
        public ArrayList ItemList       { get { return itemList;        }									}
        public ArrayList ImportCharList { get { return importCharList;  }									}
        public ArrayList ImportItemList { get { return importItemList;  }									}
        public uint NextItemSer         { get { return nextItemSer;     } set { nextItemSer = value;	}	}
        public uint NextCharSer         { get { return nextCharSer;     } set { nextCharSer = value;	}	}
        #endregion "Public Properties"

        public ObjectHandler()
        {
			nextItemSer		= 0x40000000;
			nextCharSer		= 0;
            charList		= new ArrayList();
            itemList		= new ArrayList();
            importCharList	= new ArrayList();
            importItemList	= new ArrayList();
        }

		public void Clear()
		{
			charList.Clear();
			itemList.Clear();
		}

        public WorldObject FindObjectBySerial( uint toFind, bool doImport )
        {
            if( toFind == 0xFFFFFFFF )
                return null;

            if( toFind >= 0x40000000 )
            {
				ArrayList iList = ItemList;
				if( doImport )
					iList = ImportItemList;
				foreach (WorldObject mObj in iList)
                {
                    if( mObj.Serial == toFind )
                        return mObj;
                }
            }
            else
            {
				ArrayList cList = CharList;
				if( doImport )
					cList = ImportCharList;
                foreach( WorldObject mObj in cList )
                {
                    if( mObj.Serial == toFind )
                        return mObj;
                }
            }
            return null;
        }
    }

    public abstract class WorldObject
	{
		#region "Protected Data"
		protected ObjectType objType;
		protected string name;
		protected uint serial;
		protected string serString;
		protected ushort id;
		protected ArrayList containsList;
		protected UOXData.Script.WorldSection section;
		#endregion "Protected Data"

		#region "Public Properties"
		public UOXData.Script.WorldSection Section	{ get { return section;			} set { section = value;	}	}
		public ArrayList ContainsList				{ get { return containsList;	}								}
		public string Name							{ get { return name;			} set { name = value;		}	}
		public ushort ID							{ get { return id;				} set { id = value;			}	}
		public uint Serial							{ get { return serial;			} set { serial = value;		}	}
		public string SerString						{ get { return serString;		} set { serString = value;	}	}
		public ObjectType ObjType					{ get { return objType;			} set { objType = value;	}	}
		#endregion "Public Properties"

		public WorldObject()
        {
			ResetDefaults();
        }
        public WorldObject(uint newSer)
        {
			ResetDefaults();
            serial = newSer;
        }
		private void ResetDefaults()
		{
            containsList	= new ArrayList();
			objType			= ObjectType.OT_CBO;
			name			= "";
			serString		= "0xFFFFFFFF";
			serial			= 0xFFFFFFFF;
			id				= 0xFFFF;
			section			= null;
		}
    }

    public class CharObject : WorldObject
    {
        public CharObject() : base()
        {
			ResetDefaults();
        }
        public CharObject(uint newSer) : base(newSer)
        {
			ResetDefaults();
        }

		private void ResetDefaults()
		{
			ObjType = ObjectType.OT_CHAR;
		}
    }

    public class ItemObject : WorldObject
    {
        public ItemObject() : base()
        {
			ResetDefaults();
        }
        public ItemObject(uint newSer) : base(newSer)
        {
			ResetDefaults();
        }

		private void ResetDefaults()
		{
			ObjType		= ObjectType.OT_ITEM;
			container	= 0xFFFFFFFF;
		}

        protected uint container;
        public uint Container
        {
            get { return container; }
            set { container = value; }
        }
    }
}

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
            charList = new ArrayList();
            itemList = new ArrayList();
            importCharList = new ArrayList();
            importItemList = new ArrayList();
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
		public ObjectType ObjType					{ get { return objType;			} set { objType = value;	}	}
		#endregion "Public Properties"
		public WorldObject()
        {
            containsList = new ArrayList();
        }
        public WorldObject(uint newSer)
        {
            serial = newSer;
            containsList = new ArrayList();
        }
    }

    public class CharObject : WorldObject
    {
        public CharObject() : base()
        {
			ObjType = ObjectType.OT_CHAR;
        }
        public CharObject(uint newSer) : base(newSer)
        {
			ObjType = ObjectType.OT_CHAR;
        }
    }

    public class ItemObject : WorldObject
    {
        public ItemObject() : base()
        {
			ObjType = ObjectType.OT_ITEM;
        }
        public ItemObject(uint newSer) : base(newSer)
        {
			ObjType = ObjectType.OT_ITEM;
        }

        protected uint container;
        public uint Container
        {
            get { return container; }
            set { container = value; }
        }
    }
}

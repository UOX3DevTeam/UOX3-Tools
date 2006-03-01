using System;
using System.Collections;
using System.IO;

namespace UOXData.Script
{
	/// <summary>
	/// This class is a repository of all the Scripts that belong to a particular DFN Category.
	/// </summary>
	public class DefinitionCollection
	{
		protected Hashtable				files;
		protected DFN_Categories		mCat;

		public DefinitionCollection( DFN_Categories toSet )
		{
			//
			// TODO: Add constructor logic here
			//
			mCat	= toSet;
			files	= new Hashtable();
		}

		public void Load( string directory )
		{
			string [] mDirs		= Directory.GetDirectories( directory );
			string [] mFiles	= Directory.GetFiles( directory );

			for( int i = 0; i < mFiles.Length; ++i )
			{
				if( mFiles[i].Substring( mFiles[i].Length - 4 ) == ".dfn" )
					files.Add( mFiles[i], new Script( mFiles[i], mCat ) );
			}

			if( mDirs.Length > 0 )
			{
				for( int i = 0; i < mDirs.Length; ++i )
					Load( mDirs[i] );
			}
		}

		public ScriptSection FindEntry( string toFind )
		{
			foreach( Script s in files.Values )
			{
				ScriptSection checkVal = s.FindSection( toFind );
				if( checkVal != null )
					return checkVal;
			}
			return null;
		}
	}
}

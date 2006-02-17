using System;
using System.IO;
using System.Collections;
using System.Globalization;

namespace UOXData 
{
	public class Conversion
	{
		protected static char[] whitespace = { ' ', '\t' };
		public static string TrimCommentAndWhitespace( string input )
		{
			int position = -1;
			for( int i = 0; i < (input.Length-1); i++ )
			{
				if( input[i] == '/' )
				{
					if( input[i+1] == '/' )	// we have a comment!
					{
						position = i;
						break;
					}
				}
			}
			string working = input;
			if( position != -1 )
			{
				working = input.Remove( position, input.Length - position );
			}
			return working.TrimEnd( whitespace );
		}
		protected static string PadHex( string toPad, int padLength )
		{
			string leading = "0x";
			for( int i = toPad.Length; i < padLength; i++ )
				leading += "0";
			return leading + toPad;
		}
		public static string ToHexString( int toConvert )
		{
			return PadHex( Convert.ToString( toConvert, 16 ), 8 );
		}
		public static string ToHexString( uint toConvert )
		{
			return PadHex( Convert.ToString( toConvert, 16 ), 8 );
		}
		public static string ToHexString( short toConvert )
		{
			return PadHex( Convert.ToString( toConvert, 16 ), 4 );
		}
		public static string ToHexString( ushort toConvert )
		{
			return PadHex( Convert.ToString( toConvert, 16 ), 4 );
		}
		public static string ToHexString( byte toConvert )
		{
			return PadHex( Convert.ToString( toConvert, 16 ), 2 );
		}
		public static string ToHexString( sbyte toConvert )
		{
			return PadHex( Convert.ToString( toConvert, 16 ), 2 );
		}
		public static int ToInt32( string toConvert )
		{
			int convertedValue	= 0;
			bool isHex			= toConvert.StartsWith( "0x" ) || toConvert.StartsWith( "0X" );
			string testing		= toConvert;
			try
			{
				if( isHex )
					convertedValue = int.Parse( toConvert.Substring(2), NumberStyles.HexNumber );
				else
					convertedValue = System.Convert.ToInt32( testing );
			}
			catch( Exception )
			{
				convertedValue = 0;
			}
			return convertedValue;
		}
		public static uint ToUInt32( string toConvert )
		{
			uint convertedValue = 0;
			bool isHex			= toConvert.StartsWith( "0x" ) || toConvert.StartsWith( "0X" );
			string testing		= toConvert;
			try
			{
				if( isHex )
					convertedValue = uint.Parse( toConvert.Substring(2), NumberStyles.HexNumber );
				else
					convertedValue = System.Convert.ToUInt32( testing );
			}
			catch( Exception )
			{
				convertedValue = 0;
			}
			return convertedValue;
		}
		public static short ToInt16( string toConvert )
		{
			short convertedValue	= 0;
			bool isHex				= toConvert.StartsWith( "0x" ) || toConvert.StartsWith( "0X" );
			string testing			= toConvert;
			try
			{
				if( isHex )
					convertedValue = short.Parse( toConvert.Substring(2), NumberStyles.HexNumber );
				else
					convertedValue = System.Convert.ToInt16( testing );
			}
			catch( Exception )
			{
				convertedValue = 0;
			}
			return convertedValue;
		}
		public static ushort ToUInt16( string toConvert )
		{
			ushort convertedValue	= 0;
			bool isHex				= toConvert.StartsWith( "0x" ) || toConvert.StartsWith( "0X" );
			string testing			= toConvert;
			try
			{
				if( isHex )
					convertedValue = ushort.Parse( toConvert.Substring(2), NumberStyles.HexNumber );
				else
					convertedValue = System.Convert.ToUInt16( testing );
			}
			catch( Exception )
			{
				convertedValue = 0;
			}
			return convertedValue;
		}
		public static sbyte ToInt08( string toConvert )
		{
			sbyte convertedValue	= 0;
			bool isHex				= toConvert.StartsWith( "0x" ) || toConvert.StartsWith( "0X" );
			string testing			= toConvert;
			try
			{
				if( isHex )
					convertedValue = sbyte.Parse( toConvert.Substring(2), NumberStyles.HexNumber );
				else
					convertedValue = System.Convert.ToSByte( testing );
			}
			catch( Exception )
			{
				convertedValue = 0;
			}
			return convertedValue;
		}
		public static byte ToUInt08( string toConvert )
		{
			byte convertedValue = 0;
			bool isHex			= toConvert.StartsWith( "0x" ) || toConvert.StartsWith( "0X" );
			string testing		= toConvert;
			try
			{
				if( isHex )
					convertedValue = byte.Parse( toConvert.Substring(2), NumberStyles.HexNumber );
				else
					convertedValue = System.Convert.ToByte( testing );
			}
			catch( Exception )
			{
				convertedValue = 0;
			}
			return convertedValue;
		}
	}
}

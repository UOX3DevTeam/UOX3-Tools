using System;
using System.IO;
using System.Collections;
using System.Globalization;

namespace UOXData 
{
	public class Conversion
	{
		protected static char[] whitespace = { ' ', '\t', '\0' };
		public static string ToString( byte[] input )
		{
			string retVal = "";
			for( int i = 0; i < input.Length; ++i )
			{
				if( input[i] == 0 )
					break;
				retVal += (char)input[i];
			}
			return retVal;
		}
		public static string ToString( char[] input )
		{
			string retVal = "";
			for( int i = 0; i < input.Length; ++i )
			{
				if( input[i] == 0 )
					break;
				retVal += input[i];
			}
			return retVal;
		}
		public static byte[] ToByteArray( string input, int length )
		{
			byte[] retVal = new byte[length];
			for( int i = 0; i < Math.Min( input.Length, length ); ++i )
				retVal[i] = (byte)input[i];
			return retVal;
		}
		public static byte[] ToByteArray( uint input )
		{
			byte[] retVal = new byte[4];
			retVal[0] = (byte)((input>>24)%256);
			retVal[1] = (byte)((input>>16)%256);
			retVal[2] = (byte)((input>>8)%256);
			retVal[3] = (byte)(input%256);
			return retVal;
		}
		public static byte[] ToByteArray( int input )
		{
			byte[] retVal = new byte[4];
			retVal[0] = (byte)((input>>24)%256);
			retVal[1] = (byte)((input>>16)%256);
			retVal[2] = (byte)((input>>8)%256);
			retVal[3] = (byte)(input%256);
			return retVal;
		}
		public static byte[] ToByteArray( short input )
		{
			byte[] retVal = new byte[2];
			retVal[0] = (byte)((input>>8)%256);
			retVal[1] = (byte)(input%256);
			return retVal;
		}
		public static byte[] ToByteArray( ushort input )
		{
			byte[] retVal = new byte[2];
			retVal[0] = (byte)((input>>8)%256);
			retVal[1] = (byte)(input%256);
			return retVal;
		}
		public static string TrimTrailingWhitespace( string input )
		{
			return input.TrimEnd( whitespace );
		}
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
		public static int ToInt32( byte[] toConvert, int offset )
		{
			int convertedValue = 0;
			if( offset + 4 <= toConvert.Length )
			{
				const int OFFSET_24	= 256 * 256 * 256;
				const int OFFSET_16	= 256 * 256;
				const int OFFSET_8	= 256;
				convertedValue		= toConvert[offset] * OFFSET_24 + toConvert[offset+1] * OFFSET_16 + toConvert[offset+2] * OFFSET_8 + toConvert[offset+3];
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
		public static uint ToUInt32( byte[] toConvert, int offset )
		{
			uint convertedValue = 0;
			if( offset + 4 <= toConvert.Length )
			{
				const uint OFFSET_24	= 256 * 256 * 256;
				const uint OFFSET_16	= 256 * 256;
				const uint OFFSET_8		= 256;
				convertedValue = toConvert[offset] * OFFSET_24 + toConvert[offset+1] * OFFSET_16 + toConvert[offset+2] * OFFSET_8 + toConvert[offset+3];
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

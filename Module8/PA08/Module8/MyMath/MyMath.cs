/*
 * Name: Aidan Linerud
 * Date: 11/30/2023
 * Assignment: PA08-1
 */

namespace MyMath
{
	public class MyMath
	{
		public static byte Subtract(byte a, byte b)
		{
			return checked((byte)(a - b));
		}
	}
}
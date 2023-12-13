/*
 * Name: Aidan Linerud
 * Date: 11/30/2023
 * Assignment: PA08-1
 */

namespace MyMathTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			Assert.That(() => MyMath.MyMath.Subtract(5, 2), Is.EqualTo(3));
			Assert.That(() => MyMath.MyMath.Subtract(3, 7), Throws.Exception);
		}
	}
}
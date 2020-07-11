using NUnit.Framework;

namespace MyMath.Tests
{
	[TestFixture]
	public class OperationsTests
	{
		[Test]
		public void AddTest1()
		{
			int int_a = 5;
			int int_b = 6;
			int answer = Operations.Add(int_a, int_b);
			Assert.AreEqual(int_a + int_b, answer);
		}
	}
}
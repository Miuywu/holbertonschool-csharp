using NUnit.Framework;

namespace Text.Tests
{
	///<summary>checking for string test</summary>
	[TestFixture]
	public class StrTests
	{
		///<summary>checking for normal operation</summary>
		[Test]
		public void Test1()
		{
			string s = "aaabaa";

			int output = Str.UniqueChar(s);

			Assert.AreEqual(3, output);
		}

		///<summary>checking if all character is consecutive</summary>
		[Test]
		public void Test2()
		{
			string s = "aaaaaaa";

			int output = Str.UniqueChar(s);

			Assert.AreEqual(-1, output);
		}

		///<summary>check if string is none</summary>
		[Test]
		public void Test3()
		{
			string s = "";

			int output = Str.UniqueChar(s);

			Assert.AreEqual(-1, output);
		}

		///<summary>check if string is null</summary>
		[Test]
		public void Test4()
		{
			string s = null;

			int output = Str.UniqueChar(s);

			Assert.AreEqual(-1, output);
		}

		[Test]
		public void Tes5()
		{
			string s = "ab";

			int output = Str.UniqueChar(s);

			Assert.AreEqual(1, output);
		}
	}
}
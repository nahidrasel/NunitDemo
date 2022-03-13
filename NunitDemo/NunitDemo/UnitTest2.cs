using NUnit.Framework;
using System;

namespace NunitDemo
{
	public class TestFor2
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test2()
		{
			Console.WriteLine("This is Second Commit");
			Assert.Pass();

		}
	}
}
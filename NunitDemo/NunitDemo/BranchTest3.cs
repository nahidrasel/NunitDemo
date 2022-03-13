	using NUnit.Framework;
	using System;

	namespace NunitDemo
	{
		public class Test3
		{
			[SetUp]
			public void Setup()
			{
			}

			[Test]
			public void Test2()
			{
				Console.WriteLine("This is Third Commit");
				Assert.Pass();

			}
		}
	}
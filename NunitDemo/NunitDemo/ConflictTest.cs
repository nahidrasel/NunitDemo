using NUnit.Framework;
using System;

namespace NunitDemo
{
    public class ConflictTest
    {
			[SetUp]
			public void Setup()
			{
			}

			[Test]
			public void CTest()
			{
				Console.WriteLine("This is Conlict Commit By QA");
			Console.WriteLine("Empty");

			Console.WriteLine("Conflict By Nahid");

				Assert.Pass();

			}
		}
	}

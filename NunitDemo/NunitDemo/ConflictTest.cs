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
			
				Console.WriteLine("This is Conlict Commit By SHIYAM-251");
			
				Console.WriteLine("Empty");
				Console.WriteLine("Nahid");

				Console.WriteLine("Conflict By Nahid Original");

				Console.WriteLine("Conflict By QA");

				Assert.Pass();

			}
		}
	}

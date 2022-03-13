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

			Console.WriteLine("Conflict By QA")

				Assert.Pass();

			}
		}
	}

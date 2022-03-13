using NUnit.Framework;
using System;

namespace NunitDemo
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
            Console.WriteLine("This is the First Commit");
            Assert.Pass();
        }
    }
}
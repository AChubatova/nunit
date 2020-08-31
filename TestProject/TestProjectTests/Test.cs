using NUnit.Framework;
using System;

namespace TestProjectTests
{
    public class Test
    {
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("It's Test SetUp");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("It's Test TearDown");
        }

        [Test]
        public void SomeTest()
        {
            Console.WriteLine("Hello from SomeTest");
        }
    }
}

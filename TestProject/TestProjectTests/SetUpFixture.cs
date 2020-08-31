using NUnit.Framework;
using System;

namespace TestProjectTests
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [OneTimeSetUp]
        public void SetUp() 
        {
            Console.WriteLine("It's SetUpFixture SetUp");
        }
        
        [OneTimeTearDown]
        public void TearDown()
        {
            Console.WriteLine("It's SetUpFixture TearDown");
        }
    }
}

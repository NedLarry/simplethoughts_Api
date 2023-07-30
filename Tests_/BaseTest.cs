
using Abstractions.Interfaces;
using NUnit.Framework;
using Services;

namespace Tests_
{

    [TestFixture]
    public class BaseTest
    {
        private PingService _pingService;

        [SetUp]
        public void Setup()
        {
            _pingService = new PingService();
        }


        [Test]
        public void PingTest_Should_Return_WE_UP()
        {
            string expected = "WE UP!!!";

            string actual = _pingService.Ping().Result;

            Console.WriteLine(actual);

            Assert.AreEqual(expected, actual);
        }
    }
}
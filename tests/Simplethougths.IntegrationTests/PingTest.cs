using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net.NetworkInformation;
using Xunit;

namespace Simplethougths.IntegrationTests
{
    [TestFixture]
    public class PingTest : IClassFixture<_base<Program>>
    {

        private _base<Program> webApplicationFactory;

        public PingTest()
        {
        }

        [Test]
        public void Ping_Should_Return_We_Up()
        {
            string url = "api/ping";

            webApplicationFactory = new _base<Program>();

            var client = webApplicationFactory.CreateClient();

            var response = client.GetAsync(url).Result;

            var responseString = response.Content.ReadAsStringAsync().Result;

            var istrue = response.IsSuccessStatusCode;

            Assert.IsTrue(istrue);
        }
    }
}
using System.Collections.Generic;
using System.Configuration;
using KentekenApi.Net.Rdw;
using NUnit.Framework;

namespace KentekenApi.Tests.Rdw
{
    [TestFixture]
    public class KentekenTests
    {
        private KentekenApiClient _client;

        [SetUp]
        public void Setup()
        {
            string appToken = ConfigurationManager.AppSettings.Get("RdwAppToken");
            _client = new KentekenApiClient(appToken);
        }

        [Test]
        public void GetKenteken()
        {
            var filters = new Dictionary<string, string>
            {
                {"kenteken", "77FTK3"}
            };
            var result = _client.GetKenteken(filters);
            Assert.IsNotNull(result);
        }
    }
}

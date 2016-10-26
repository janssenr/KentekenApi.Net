using System.Collections.Generic;
using System.Configuration;
using KentekenApi.Net.Overheid;
using NUnit.Framework;

namespace KentekenApi.Tests.Overheid
{
    [TestFixture]
    public class KentekenTests
    {
        private KentekenApiClient _client;

        [SetUp]
        public void Setup()
        {
            string apiKey = ConfigurationManager.AppSettings.Get("OverheidApiKey");
            _client = new KentekenApiClient(apiKey);
        }

        [Test]
        public void GetKenteken()
        {
            var result = _client.GetKenteken("4-TFL-24");
            Assert.IsNotNull(result);
        }

        [Test]
        public void SearchByBrand()
        {
            var filters = new Dictionary<string, string>
            {
                {"merk", "bmw"}
            };
            var result = _client.GetKentekens(filters);
            Assert.IsNotNull(result);
        }

        [Test]
        public void SearchWithWildcardsAndShowExtraFields()
        {
            var result = _client.GetKentekens("*laren", new[] { "merk" }, new[] { "eerstekleur", "vermogen" });
            Assert.IsNotNull(result);
        }
    }
}

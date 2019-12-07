using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DEV_3Tests
{
    [TestClass]
    public class TranslitTests
    {
        private DEV_3.Translit _transliter = new DEV_3.Translit();

        [TestMethod]
        [DataRow(null, null)]
        [DataRow("sshi", "ЩИ")]
        [DataRow("SchAsTye", "СЧАСТЕ")]
        [DataRow("привет", "PRIVET")]
        [DataRow("ПоКа", "POKA")]
        [DataRow("ая", "AYA")]
        [DataRow("АЯ", "AYA")]
        [DataRow("az", "АЗ")]
        [DataRow("AZ", "АЗ")]
        public void TestGetTranslitString(string actual, string expected)
        {
            Assert.AreEqual(expected, _transliter.GetTranslitString(actual));
        }
        [TestMethod]
        public void TestGetTranslitString_EmptyString()
        {
            Assert.AreEqual(string.Empty, _transliter.GetTranslitString(string.Empty));
        }

        [TestMethod]
        [DataRow("ghbd!.,@##$", null)]
        [DataRow("123", null)]
        [DataRow("1hello", null)]
        [DataRow("1Hey", null)]
        [DataRow("2вовово", null)]
        [DataRow("2ОлочркР", null)]
        [DataRow("2вововоghdbt", null)]
        [DataRow("2вHKJHвовоgРПРПdbt", null)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetTranslitString_Exception(string actual, string expected)
        {
            Assert.AreEqual(expected, _transliter.GetTranslitString(actual));
        }
    }
}

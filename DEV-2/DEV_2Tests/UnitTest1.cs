using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_2;

namespace DEV_2Tests
{
    [TestClass]
    public class StringManagerTests
    {
        private StringManager _manager = new StringManager();

        [TestMethod]
        [DataRow("", 0)]
        [DataRow("11121", 3)]
        [DataRow("11  lkjs23", 2)]
        [DataRow("_-lskj4àëîğûëìîğ44ÎÎÎÏÔëñîğCCjhgxdYY*****", 2)]
        public void TestGetMaxNumberOfIdenticalConsecutiveDigits(string str, int expected)
        {
            Assert.AreEqual(expected, _manager.GetMaxNumberOfIdenticalConsecutiveDigits(str));
        }

        [TestMethod]
        [DataRow("", 0)]
        [DataRow("123123fkjhkgjhàîğïàaaaA", 3)]
        [DataRow("ïëîâğëîğåëî ĞĞĞĞĞËÎĞËÎÒ", 0)]
        [DataRow("123123__()(**&^*&^%gjhàHğïÎØHhhG", 2)]
        public void TestGetMaxNumberOfIdenticalConsecutiveLatinCharacters(string str, int expected)
        {
            Assert.AreEqual(expected, _manager.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(str));
        }

        [TestMethod]
        [DataRow("", 0)]
        [DataRow("123123fkjhKÎgjhàîğïàaaaA", 21)]
        [DataRow("ïëîâğëîğåëî ĞĞĞĞĞËÎĞËÎÒ", 13)]
        [DataRow("11121111", 3)]
        public void TestGetMaxNumberOfUnequalConsecutiveCharacters(string str, int expected)
        {
            Assert.AreEqual(expected, _manager.GetMaxNumberOfUnequalConsecutiveCharacters(str));
        }
    }
}

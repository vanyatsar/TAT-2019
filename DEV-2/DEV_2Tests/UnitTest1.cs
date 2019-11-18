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
        [DataRow("_-lskj4���������44���������CCjhgxdYY*****", 2)]
        public void TestGetMaxNumberOfIdenticalConsecutiveDigits(string str, int expected)
        {
            Assert.AreEqual(expected, _manager.GetMaxNumberOfIdenticalConsecutiveDigits(str));
        }

        [TestMethod]
        [DataRow("", 0)]
        [DataRow("123123fkjhkgjh�����aaaA", 3)]
        [DataRow("����������� �����������", 0)]
        [DataRow("123123__()(**&^*&^%gjh�H����HhhG", 2)]
        public void TestGetMaxNumberOfIdenticalConsecutiveLatinCharacters(string str, int expected)
        {
            Assert.AreEqual(expected, _manager.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(str));
        }

        [TestMethod]
        [DataRow("", 0)]
        [DataRow("123123fkjhK�gjh�����aaaA", 21)]
        [DataRow("����������� �����������", 13)]
        [DataRow("11121111", 3)]
        public void TestGetMaxNumberOfUnequalConsecutiveCharacters(string str, int expected)
        {
            Assert.AreEqual(expected, _manager.GetMaxNumberOfUnequalConsecutiveCharacters(str));
        }
    }
}

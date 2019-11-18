using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_2;

namespace DEV_2Tests
{
    [TestClass]
    public class StringManagerTests
    {
        [TestMethod]
        public void TestGetMaxNumberOfIdenticalConsecutiveDigits()
        {
            StringManager manager = new StringManager();
            Assert.AreEqual(0, manager.GetMaxNumberOfIdenticalConsecutiveDigits(""));
        }

        [TestMethod]
        public void TestGetMaxNumberOfIdenticalConsecutiveLatinCharacters()
        {
            StringManager manager = new StringManager();
            Assert.AreEqual(0, manager.GetMaxNumberOfIdenticalConsecutiveLatinCharacters(""));
        }

        [TestMethod]
        public void TestGetMaxNumberOfUnequalConsecutiveCharacters()
        {
            StringManager manager = new StringManager();
            Assert.AreEqual(0, manager.GetMaxNumberOfUnequalConsecutiveCharacters(""));
        }
    }
}

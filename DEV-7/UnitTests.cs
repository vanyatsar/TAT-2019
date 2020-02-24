using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnitTestProject.PageObjectLibrary;

namespace NUnitTestProject
{
    class Tests
    {
        private IWebDriver Driver { get; set; }
        private CalculatorMainPage Calculator { get; set; }
        private TestInvoker TestInvoker { get; set; }

        [OneTimeSetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Calculator = new CalculatorMainPage(Driver);
            Calculator.GoToPage();
            Calculator.Initialize();
            TestInvoker = new TestInvoker(this.Calculator);
        }

        [Test]
        public void StartPageTest()
        {
            Assert.AreEqual("Калькулятор онлайн - Calkulyator.ru", Calculator.Title);
        }

        [TestCase("2 + 2 =", ExpectedResult = "4")]
        [TestCase("2 0 + 2 1 =", ExpectedResult = "41")]
        [TestCase("0 + 0 =", ExpectedResult = "0")]
        [TestCase("2 * 1 =", ExpectedResult = "2")]
        [TestCase("0 / 0 =", ExpectedResult = "NaN")]
        //[TestCase("2 / 0 =", ExpectedResult = "NaN")]
        [TestCase("2 + 0 = C", ExpectedResult = "0")]
        [TestCase("1 0 0 0 0 00>0", ExpectedResult = "1 000")]
        [TestCase("AC 8 M+ 9 M- MR MC MR", ExpectedResult = "0")]
        public string GetCalculationResultsTests(string actual)
        {
            string actualResult = TestInvoker.GetResult(actual);
            return actualResult;
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}
using OpenQA.Selenium;
using System.Collections.Generic;

namespace NUnitTestProject.PageObjectLibrary
{
    class CalculatorMainPage : BasePage
    {
        /// <summary>
        /// Dictionary with web elements
        /// </summary>
        public Dictionary<string, IWebElement> WebElements { get; private set; } = new Dictionary<string, IWebElement>();
        /// <summary>
        /// Result web element
        /// </summary>
        public IWebElement ResultWebElement { get; private set; }
        /// <summary>
        /// Page title
        /// </summary>
        public string Title { get; private set; }
        readonly Dictionary<string, By> ElementsLocators = new Dictionary<string, By>
        {
            {"+", By.Id("nmr_22")},
            {"-", By.Id("nmr_17")},
            {"*", By.Id("nmr_16")},
            {"/", By.Id("nmr_10")},
            {"&", By.Id("nmr_4")},
            {"C", By.Id("nmr_24")},
            {"%", By.Id("nmr_11")},
            {"=", By.Id("nmr_23")},
            {".", By.Id("nmr_27")},
            {"1", By.Id("nmr_19")},
            {"2", By.Id("nmr_20")},
            {"3", By.Id("nmr_21")},
            {"4", By.Id("nmr_13")},
            {"5", By.Id("nmr_14")},
            {"6", By.Id("nmr_15")},
            {"7", By.Id("nmr_7")},
            {"8", By.Id("nmr_8")},
            {"9", By.Id("nmr_9")},
            {"0", By.Id("nmr_25")},
            {"MC", By.Id("nmr_0")},
            {"MR", By.Id("nmr_1")},
            {"M+", By.Id("nmr_2")},
            {"M-", By.Id("nmr_3")},
            {"Xy", By.Id("nmr_5")},
            {"AC", By.Id("nmr_18")},
            {"+-", By.Id("nmr_12")},
            {"00", By.Id("nmr_26")},
            {"00>0", By.Id("nmr_6")}
        };

        /// <summary>
        /// Constructor to initialization main page
        /// </summary>
        /// <param name="driver">driver which help contact with browser</param>
        public CalculatorMainPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Go to start page
        /// </summary>
        /// <returns>current page instance</returns>
        public CalculatorMainPage GoToPage()
        {
            Driver.Navigate().GoToUrl("https://calkulyator.ru/");
            Title = Driver.Title;
            return this;
        }

        /// <summary>
        /// Initializes web elements dictionary 
        /// </summary>
        /// <returns>current page instance</returns>
        public CalculatorMainPage Initialize()
        {
            ResultWebElement = GetWebElement(By.Id("display"));
            foreach (var element in ElementsLocators)
            {
                WebElements.Add(element.Key, GetWebElement(element.Value));
            }
            return this;
        }
    }
}


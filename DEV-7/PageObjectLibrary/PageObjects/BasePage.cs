using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject.PageObjectLibrary
{
    /// <summary>
    /// Base class for page objects
    /// </summary>
    public abstract class BasePage
    {
        protected IWebDriver Driver { get; }
        protected WebDriverWait Wait { get; }

        /// <summary>
        /// Base constructor for page objects
        /// </summary>
        /// <param name="driver">driver which help contact with browser</param>
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(40));
        }

        protected IWebElement GetWebElement(By locator) => Wait
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));

    }
}

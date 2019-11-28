using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_5.PageObjects
{
    public abstract class BasePage
    {
        protected IWebDriver Driver { get; }

        protected WebDriverWait Wait { get; }

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(40));
        }

        protected IWebElement GetWebElement(By locator) => Wait
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));

    }
}

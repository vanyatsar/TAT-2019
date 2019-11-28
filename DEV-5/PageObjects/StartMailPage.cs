using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_5.PageObjects
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginMailPage
    {
        private readonly By usernameLocator = By.Id("mailbox:login");
        private readonly By passwordLocator = By.Id("mailbox:password");

        IWebElement element;
        IWebElement button;

        private WebDriverWait _waitTime;
        private readonly IWebDriver _driver;

        public LoginMailPage(IWebDriver driver)
        {
            _driver = driver;
            _waitTime = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public LoginMailPage NavigetToLoginPage()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://mail.ru/");
            return this;
        }

        public LoginMailPage TypeUsename(string username)
        {
            GetWebElement(usernameLocator).SendKeys(username + Keys.Enter);
            return this;
        }

        public LoginMailPage TypePassword(string password)
        {
            GetWebElement(passwordLocator).SendKeys(password + Keys.Enter);
            return this;
        }

        private IWebElement GetWebElement(By locator)
        {
            element = _waitTime
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            return element;
        }

        public void LoginToMail(string username, string password)
        {
            TypeUsename(username);
            TypePassword(password);

        }

    }
}

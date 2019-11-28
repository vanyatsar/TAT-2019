using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_5.PageObjects
{
    /// <summary>
    /// 
    /// </summary>
    public class MailRuLoginPage : BasePage
    {
        private readonly By usernameLocator = By.Id("mailbox:login");
        private readonly By passwordLocator = By.Id("mailbox:password");

        private IWebElement Element { get; set; }

        public MailRuLoginPage(IWebDriver driver) : base(driver)
        {
        }

        public MailRuLoginPage NavigetToLoginPage()
        {
            Driver.Navigate().GoToUrl("https://mail.ru/");
            return this;
        }

        private MailRuLoginPage TypeUsename(string username)
        {
            GetWebElement(usernameLocator).SendKeys(username + Keys.Enter);
            return this;
        }

        private MailRuLoginPage TypePassword(string password)
        {
            GetWebElement(passwordLocator).SendKeys(password + Keys.Enter);
            return this;
        }

        public void LoginToMail(string username, string password)
        {
            TypeUsename(username);
            TypePassword(password);

            return new MailRuMainPage(Driver);
        }

        private IWebElement GetWebElement(By Locator)
        {
            Element = Wait
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            return Element;
        }
    }
}

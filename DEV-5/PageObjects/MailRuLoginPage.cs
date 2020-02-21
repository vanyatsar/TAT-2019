using OpenQA.Selenium;

namespace DEV_5.PageObjects
{
    public class MailRuLoginPage : BasePage
    {
        private readonly By usernameLocator = By.Id("mailbox:login");
        private readonly By passwordLocator = By.Id("mailbox:password");

        public MailRuLoginPage(IWebDriver driver) : base(driver)
        {
        }

        public MailRuLoginPage NavigateToMainPage()
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

        public void Login(string username, string password)
        {
            TypeUsename(username);
            TypePassword(password);
        }
    }
}

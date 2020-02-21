using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using DEV_5.PageObjects;

namespace DEV_5
{
    /// <summary>
    /// Class of entry point
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        static void Main()
        { 
            const string LOGIN_USERNAME = "tat2019.2";
            const string LOGIN_PASSWORD = "verydifficult";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            MailRuLoginPage loginPage = new MailRuLoginPage(driver);
            loginPage.NavigateToMainPage();
            loginPage.Login(LOGIN_USERNAME, LOGIN_PASSWORD);

            MailRuMainPage mailRuMain = new MailRuMainPage(driver);
            mailRuMain.SendMessage("ivan.tsar99@gmail.com", "Hello, how are you?");
        }
    }
}

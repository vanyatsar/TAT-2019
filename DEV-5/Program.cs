using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using DEV_5.PageObjects;

namespace DEV_5
{
    class Program
    {
        static void Main()
        { 
            const string LOGIN_USERNAME = "tat2019.2";
            const string LOGIN_PASSWORD = "verydifficult";

            IWebDriver driver = new ChromeDriver();
            LoginMailPage loginPage = new LoginMailPage(driver);

            loginPage.NavigetToLoginPage();
            loginPage.LoginToMail(LOGIN_USERNAME, LOGIN_PASSWORD);
        }
    }
}

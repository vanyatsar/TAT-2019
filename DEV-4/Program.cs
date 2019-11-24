using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

/// <summary>
/// log: tat2019.2
/// pass: verydifficult
/// </summary>

namespace DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://mail.ru/");
            driver.Manage().Window.Maximize();

            Input(driver);

            //driver.Quit();
        }

        static void Input(IWebDriver driver)
        {
            IWebElement searchLogin = driver.FindElement(By.Id("mailbox:login"));
            searchLogin.SendKeys("tat2019.2" + Keys.Enter);

            IWebElement searchPassword = driver.FindElement(By.Id("mailbox:password"));
            searchPassword.SendKeys("verydifficult" + Keys.Enter);
        }
    }
}

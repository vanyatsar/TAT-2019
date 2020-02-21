using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
            WebDriverWait waitTime = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;

            driver.Navigate().GoToUrl("https://mail.ru/");
            driver.Manage().Window.Maximize();

            IWebElement searchLogin = GetWebElement("mailbox:login", waitTime);
            searchLogin.SendKeys("tat2019.2" + Keys.Enter);

            IWebElement searchPassword = GetWebElement("mailbox:password", waitTime);
            searchPassword.SendKeys("verydifficult" + Keys.Enter);

            IWebElement unreadMessages = GetWebElement("g_mail_events", waitTime);

            Console.WriteLine(unreadMessages.Text);
            executor.ExecuteScript($"alert('{unreadMessages.Text}')");

            driver.Quit();
        }
        static IWebElement GetWebElement(string arg, WebDriverWait waitTime)
        {
            IWebElement element = waitTime
                .Until(ExpectedConditions.ElementIsVisible(By.Id(arg)));

            return element;
        }
    }
}

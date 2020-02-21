using OpenQA.Selenium;

namespace DEV_5.PageObjects
{
    public class MailRuMainPage : BasePage
    {
        private readonly By textMessageLocator = By.XPath("//div[contains(@tabindex, \"505\")]");
        private readonly By destinationLocator = By.CssSelector(".container--zU301");
        private readonly By buttonLocator = By.ClassName("compose-button__wrapper");

        public MailRuMainPage(IWebDriver driver) : base (driver)
        {
        }

        private MailRuMainPage ClickToPrintButton ()
        {
            GetWebElement(buttonLocator).Click();
            return this;
        }

        private MailRuMainPage InputDestination(string email)
        {
            GetWebElement(destinationLocator).SendKeys(email);
            return this;
        }
  
        private MailRuMainPage TextLetter(string text)
        {
            GetWebElement(textMessageLocator).SendKeys(text + Keys.Control + Keys.Enter);
            return this;
        }
     
        public void SendMessage(string email, string textOfLetter)
        {
            ClickToPrintButton();
            InputDestination(email);
            TextLetter(textOfLetter);
        }
    }
}

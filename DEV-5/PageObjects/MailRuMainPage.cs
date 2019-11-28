using OpenQA.Selenium;

namespace DEV_5.PageObjects
{
    public class MailRuMainPage : BasePage
    {
        private readonly By textMessageLocator = By.XPath("/html/body/div[17]/div[2]/div/div[1]/div[2]/div[3]/div[5]/div/div/div[2]/div[1]/div");
        private readonly By destinationLocator = By.CssSelector(".container--zU301");
        private readonly By buttonLocator = By.ClassName("compose-button__wrapper");
        private readonly By buttonSendLocator = By.ClassName("button2__txt");

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
            GetWebElement(textMessageLocator).SendKeys(text+ Keys.Control + Keys.Enter);
            return this;
        }

        private MailRuMainPage ClickToSendButton()
        {
            GetWebElement(buttonSendLocator);
            return this;
        }

        public void SendMessage(string email, string textOfLetter)
        {
            ClickToPrintButton();
            InputDestination(email);
            TextLetter(textOfLetter);
            ClickToSendButton();
            //this.SendLetterButton.Click();
        }

    }
}

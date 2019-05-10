using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_9.Google
{
    class GoogleMailSendler
    {
        private IWebDriver _driver { get; set; }
        private WebDriverWait _wait { get; }

        public IWebElement NewLetter => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@class = 'T-I J-J5-Ji T-I-KE L3']")));

        public IWebElement Recipient => _wait.Until(t => this._driver.FindElement(By.XPath("//textarea[@name = 'to']")));

        public IWebElement TextOfMessage => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@role='textbox']")));

        public IWebElement SubmitButton => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@class='dC']")));

        public GoogleMailSendler(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public void SendLetter(string recipient,string text)
        {
            this.NewLetter.Click();
            this.Recipient.SendKeys(recipient);
            this.TextOfMessage.SendKeys(text);
            this.SubmitButton.Click();
        }

        public GoogleMailReadPage ChangeAlias()
        {
            return new GoogleMailReadPage(this._driver);
        }
    }
}

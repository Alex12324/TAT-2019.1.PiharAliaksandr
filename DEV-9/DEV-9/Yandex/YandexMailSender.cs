using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_9.Yandex
{
    public class YandexMailSender
    {
        private IWebDriver _driver { get; set; }
        private WebDriverWait _wait { get; }

        public IWebElement NewLetter => _wait.Until(t => this._driver.FindElement(By.XPath("//a[@class='mail-ComposeButton js-main-action-compose']")));

        public IWebElement Recipient => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@name='to']")));

        public IWebElement TextOfMessage => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@role='textbox']")));

        public IWebElement SubmitButton => _wait.Until(t => this._driver.FindElement(By.XPath("//span[contains(text(), 'Отправить')]")));

        public IWebElement LastMessage => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@class='ns-view-container-desc mail-MessagesList js-messages-list']/div[1]")));

        public YandexMailSender(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public void SendLetter(string recipient,string text)
        {
            this.NewLetter.Click();
            this.Recipient.SendKeys(recipient);
            this.Recipient.SendKeys(Keys.Enter);
            this.TextOfMessage.SendKeys(text);
            this.SubmitButton.Click();
        }

        public YandexMailReadPage ReadMessage()
        {
            this.LastMessage.Click();
            return new YandexMailReadPage(this._driver);
        }
    }
}

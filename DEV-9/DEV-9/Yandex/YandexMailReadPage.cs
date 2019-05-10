using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_9.Yandex
{
    /// <summary>
    /// 
    /// </summary>
    public class YandexMailReadPage
    {
        private IWebDriver _driver { get; set; }
        private WebDriverWait _wait { get; }

        public IWebElement QuickReplyBox => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@class ='mail-QuickReply-Placeholder_text']")));

        public IWebElement QuickReplyTextBox => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@role = 'textbox']")));

        public IWebElement SendingButton => _wait.Until(t => this._driver.FindElement(By.XPath("//button[contains(@class, 'js-send-button')]")));

        public YandexMailReadPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public void ReplyMessageWithNewAlias(string alias)
        {
            this.QuickReplyBox.Click();
            this.QuickReplyTextBox.SendKeys(alias);
            this.SendingButton.Click();
        }
    }
}

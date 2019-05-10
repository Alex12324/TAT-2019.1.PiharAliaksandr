using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_9.Yandex
{
    public class YandexMainPage
    {
        private IWebDriver _driver { get; set; }
        private WebDriverWait _wait { get; }

        public IWebElement LoginButton => _wait.Until(t => this._driver.FindElement(By.XPath("//a[contains(@class,'button desk-notif-card__login-enter-expanded')]")));

        public IWebElement Username => _wait.Until(t => this._driver.FindElement(By.XPath("//input[@name='login']")));

        public IWebElement Password => _wait.Until(t => this._driver.FindElement(By.XPath("//input[@name='passwd']")));

        public IWebElement SubmitButton => _wait.Until(t => this._driver.FindElement(By.XPath("//button[@type='submit']")));

        public IWebElement ErrorMessage => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@class='passp-form-field__error']")));

        public YandexMainPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public void GoToURL()
        {
            _driver.Navigate().GoToUrl("https://yandex.by/");
        }

        public YandexMailSender Login(string username,string password)
        {
            this.LoginButton.Click();
            this.Username.SendKeys(username);
            this.SubmitButton.Click();
            this.Password.SendKeys(password);
            this.SubmitButton.Click();
            return new YandexMailSender(_driver);
        }

        public YandexMainPage LoginError(string username, string password)
        {
            this.LoginButton.Click();
            this.Username.SendKeys(username);
            this.LoginButton.Click();
            if (this._driver.FindElements(By.XPath("//div[@class='passp-form-field__error']")).Count == 0)
            {
                this.Password.SendKeys(password);
                this.LoginButton.Click();
            }

            return this;
        }
    }
}

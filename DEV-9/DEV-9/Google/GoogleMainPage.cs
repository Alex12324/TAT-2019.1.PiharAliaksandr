using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_9.Google
{
    class GoogleMainPage
    {
        private IWebDriver _driver { get; set; }
        private WebDriverWait _wait { get; }

        public IWebElement LoginButton => _wait.Until(t => this._driver.FindElement(By.XPath("//a[contains(text(), 'Войти')]")));

        public IWebElement UserName => _wait.Until(t => this._driver.FindElement(By.XPath("//input[@name = 'identifier']")));

        public IWebElement Password => _wait.Until(t => this._driver.FindElement(By.XPath("//input[@name = 'password']")));

        public IWebElement MailButton => _wait.Until(t => this._driver.FindElement(By.XPath("//a[@class = 'gb_d']")));

        public GoogleMainPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public void GoToURL()
        {
            _driver.Navigate().GoToUrl("https://www.google.com/");
        }

        public GoogleMailSendler Login(string username,string password)
        {
            this.LoginButton.Click();
            this.UserName.SendKeys(username);
            this.UserName.SendKeys(Keys.Enter);
            this.Password.SendKeys(password);
            this.Password.SendKeys(Keys.Enter);
            this.MailButton.Click();
            return new GoogleMailSendler(_driver);
        }
    }
}

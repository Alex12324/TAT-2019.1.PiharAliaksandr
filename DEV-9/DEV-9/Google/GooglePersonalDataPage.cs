using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_9.Google
{
    class GooglePersonalDataPage
    {
        private IWebDriver _driver { get; set; }
        private WebDriverWait _wait { get; }
        private string _alias { get; }

        //public IWebElement PersonalData => _wait.Until(t => this._driver.FindElement(By.XPath("//a[@data-rid='10003']")));

        public IWebElement UserName => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@class='ugt2L aK2X8b t97Ap iDdZmf']")));

        public IWebElement Pencil => _wait.Until(t => this._driver.FindElement(By.XPath("//span[@class = 'DPvwYc gPVQ']")));

        public IWebElement FirstNameBox => _wait.Until(t => this._driver.FindElement(By.XPath("//input[@class = 'whsOnd zHQkBf']")));

        public IWebElement SubmitButton => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@class = 'ZFr60d CeoRYc']")));

        public GooglePersonalDataPage(IWebDriver driver, string NewAlias)
        {
            _driver = driver;
            _alias = NewAlias;
            _wait = new WebDriverWait(this._driver, TimeSpan.FromSeconds(30));
        }

        public void ChangeName()
        {
            _driver.Navigate().GoToUrl("https://myaccount.google.com/personal-info");
            this.UserName.Click();
            this.Pencil.Click();
            this.FirstNameBox.Clear();
            this.FirstNameBox.SendKeys(_alias);
            this.SubmitButton.Click();
            this.SubmitButton.SendKeys(Keys.Enter);
            this.SubmitButton.SendKeys(Keys.Enter);
        }
    }
}

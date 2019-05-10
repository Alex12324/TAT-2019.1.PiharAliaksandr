using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_9.Google
{
    class GoogleMailReadPage
    {
        private IWebDriver _driver { get; set; }
        private WebDriverWait _wait { get; }

        public IWebElement MessageBox => _wait.Until(t => this._driver.FindElement(By.XPath("//div[@class ='ae4 aDM']//tr[1]")));

        //public string MailText => _wait.Until(t => this._driver.FindElement(By.XPath("//*[@id=':br']/div[1]")).Text);

        public IWebElement ProfileButton => _wait.Until(t => this._driver.FindElement(By.XPath("//a[@class = 'gb_x gb_Da gb_f']")));

        public IWebElement AccountGoogleButton => _wait.Until(t => this._driver.FindElement(By.XPath("//a[contains(text(),'Аккаунт Google')]")));

        public GoogleMailReadPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(this._driver, TimeSpan.FromSeconds(30));
        }

        public GooglePersonalDataPage ReadingMessage()
        {
            this.MessageBox.Click();
            this.ProfileButton.Click();
            //this.AccountGoogleButton.Click();
            return new GooglePersonalDataPage(this._driver,"Boss");
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using DEV_9.Yandex;

namespace Tests
{
    class YandexLoginTests
    {
        /// <summary>
        /// The WebDriver instance for tests.
        /// </summary>
        private IWebDriver _driver;

        /// <summary>
        /// Set up: initializes the WebDriver. Sets the URL and implicit timer.
        /// </summary>
        [SetUp]
        public void StartBrowser()
        {
            this._driver = new ChromeDriver { Url = "https://yandex.by" };
            this._driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }
        /// <summary>
        /// Negative test for logging in:
        /// wrong id, results in error message.
        /// Combines test for empty username: impossible to proceed without entering one.
        /// </summary>
        [Test]
        public void Login_EmptyInput_ErrorMessage()
        {
            var mainPage = new YandexMainPage(this._driver);
            mainPage.LoginError(string.Empty, string.Empty);
            Assert.AreEqual("Логин не указан", mainPage.ErrorMessage.Text);
        }

        /// <summary>
        /// Negative test for logging in:
        /// empty password, results in error message.
        /// </summary>
        [Test]
        public void Login_EmptyPassword_ErrorMessage()
        {
            var mainPage = new YandexMainPage(this._driver);
            var username = "alexanderpigor@yandex.by";
            var password = string.Empty;
            mainPage.LoginError(username, password);
            Assert.AreEqual("Пароль не указан", mainPage.ErrorMessage.Text);
        }

        /// <summary>
        /// Negative test for logging in:
        /// wrong username, results in error message.
        /// Combines test for wrong id: login operation won't proceed unless username is correct.
        /// </summary>
        [Test]
        public void Login_WrongUsername_ErrorMessage()
        {
            var mainPage = new YandexMainPage(this._driver);
            var username = "dontexists234332";
            var password = string.Empty;
            mainPage.LoginError(username, password);
            Assert.AreEqual("Такого аккаунта нет", mainPage.ErrorMessage.Text);
        }

        /// <summary>
        /// Negative test for logging in:
        /// wrong password, results in error message.
        /// </summary>
        [Test]
        public void Login_WrongPassword_ErrorMessage()
        {
            var mainPage = new YandexMainPage(this._driver);
            var username = "alexanderpigor@yandex.by";
            var password = "Barsik1242664";
            mainPage.LoginError(username, password);
            Assert.AreEqual("Неверный пароль", mainPage.ErrorMessage.Text);
        }

        /// <summary>
        /// Tear down: closes the driver.
        /// </summary>
        [TearDown]
        public void CloseBrowser()
        {
            this._driver.Quit();
        }
    }
}
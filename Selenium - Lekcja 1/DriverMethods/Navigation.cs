using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium___Lekcja_1.DriverMethods
{
    internal class Navigation
    {
        WebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Users\ProGamer\source\repos\Selenium - Lekcja 1\Selenium - Lekcja 1\bin\Debug\net8.0\Rescources\");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(5);
        }

        [Test]
        public void GoToUrlTest()
        {
            Uri googleUrl = new Uri("https://google.pl");
            driver.Navigate().GoToUrl(googleUrl);
            IWebElement acceptButton = driver.FindElement(By.Id("L2AGLb"));
            acceptButton.Click();
            string expectedUrl = "https://www.google.pl/";
            Assert.AreEqual(expectedUrl, driver.Url, "URL is not correct");

        }

        [Test]
        public void BackTest()
        {
            string googleUrl = "https://google.pl";
            driver.Navigate().GoToUrl(googleUrl);
            IWebElement acceptButton = driver.FindElement(By.Id("L2AGLb"));
            acceptButton.Click();

            string amazonUrl = "https://amazon.com";
            driver.Navigate().GoToUrl(amazonUrl);
            driver.Navigate().Back();


            string expectedUrl = "https://www.google.pl/";
            Assert.AreEqual(expectedUrl, driver.Url, "URL is not correct");

        }

        [Test]
        public void ForwardTest()
        {
            string googleUrl = "https://google.pl";
            string amazonUrl = "https://amazon.com";

            driver.Navigate().GoToUrl(amazonUrl);
            driver.Navigate().GoToUrl(googleUrl);
            IWebElement acceptButton = driver.FindElement(By.Id("L2AGLb"));
            acceptButton.Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();



            string expectedUrl = "https://www.google.pl/";
            Assert.AreEqual(expectedUrl, driver.Url, "URL is not correct");

        }
        [Test]
        public void RefreshTest()
        {
            string allegroURL = "https://allegro.pl";       
            driver.Navigate().GoToUrl(allegroURL);


            driver.Navigate().Refresh();
            Thread.Sleep(5000);
        }


    }
}

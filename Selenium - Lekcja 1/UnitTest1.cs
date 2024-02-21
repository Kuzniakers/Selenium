using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium___Lekcja_1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Users\ProGamer\source\repos\Selenium - Lekcja 1\Selenium - Lekcja 1\bin\Debug\net8.0\Rescources\");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(5);
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://google.pl");
            IWebElement acceptButton = driver.FindElement(By.Id("L2AGLb"));
            acceptButton.Click();
            IWebElement searchField = driver.FindElement(By.CssSelector("[title='Szukaj']"));
            string searchEntry = "wszechœwiaty równoleg³e";
            searchField.SendKeys(searchEntry);
            searchField.Submit();

            string title = "Wieloœwiat – Wikipedia, wolna encyklopedia";
            driver.FindElement(By.XPath(".//*[text()='" + title + "']")).Click();

            string entryURL = "https://pl.wikipedia.org/wiki/Wielo%C5%9Bwiat";
            Assert.AreEqual(entryURL, driver.Url, "URL is not correct.");

        }

        

    }
}
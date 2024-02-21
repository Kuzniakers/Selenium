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
    public class QuitAndClose
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
        public void goToGoogleTest()
        {
            driver.Navigate().GoToUrl("https://google.pl");
        }
        [TearDown]
        public void TearDown() 
        {
            //driver.Close();
            driver.Quit();
        }
    }
}

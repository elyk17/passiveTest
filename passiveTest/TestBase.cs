using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace passiveTest
{
    public class TestBase
    {
        public static IWebDriver driver { get; set; }

        public void LaunchBrowser()
        {
            string Name = System.Environment.UserName;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file://C:/Users/" + Name + "/Documents/GitHub/passiveTest/passiveTest/Website.html");
        }


        [TearDown]
        public void TearDownEnvironment()
        {
            driver.Quit();
        }
    }
}
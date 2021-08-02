using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
namespace passiveTest.TestBase
{
    public class TestBase
    {
        public static IWebDriver driver { get; set; }

        public void SetUpEnvironment()
        {
            driver = new ChromeDriver();
            string Name = System.Environment.UserName;
            driver.Navigate().GoToUrl("file://C:/Users/"+Name+"/Desktop/passiveTest/passiveTest/Website.html");
        }

    }
}

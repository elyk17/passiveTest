
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System;

namespace passiveTest.pageObjects
{
    public class pageObjects 
    {
        private IWebDriver driver = TestBase.driver;
        private WebDriverWait wait;

        public pageObjects()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "header")]
        public IWebElement header;

        [FindsBy(How = How.Id, Using = "title")]
        public IWebElement title;

        [FindsBy(How = How.Id, Using = "release-date")]
        public IWebElement release;

        [FindsBy(How = How.Id, Using = "ratings")]
        public IWebElement ratings;

        [FindsBy(How = How.Id, Using = "add")]
        public IWebElement addMovie;

    }
}

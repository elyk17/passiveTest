
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading.Tasks;
using passiveTest.TestBase;

namespace passiveTest.pageObjects
{
    public class pageObjects 
    {
        
        public pageObjects()
        {

            driver = testbase.testbase.driver;
            pagefactory.initelements(driver, this);



        }
        [FindsBy(How = How.Id, Using = "header")]        public IWebElement header;

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

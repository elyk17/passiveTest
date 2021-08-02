using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;

namespace passiveTest
{
    public class sansTest : TestBase
    {
        public pageObjects.pageObjects page;

        [SetUp]
        public void SetUp()
        {
            LaunchBrowser();
            page = new pageObjects.pageObjects();
        }

        [Test, Category("positive")]
        public void positive()
        {
            var thing = Environment.CurrentDirectory;
            var today = DateTime.Today;
            page.header.GetAttribute("text").Equals("Sans");
      

            //Testing Title for positive alphanumeric input
            page.title.SendKeys("aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ");
            page.title.GetAttribute("value").Equals("aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ");
            page.title.Click();
            page.title.Clear();
            page.title.SendKeys("0123456789!@#$%^&*");
            page.title.GetAttribute("value").Equals("0123456789!@#$%^&*");
            page.title.Click();
            page.title.Clear();

            //Testing Release Date Positive
            page.release.SendKeys("05302021");
            page.release.GetAttribute("value").Equals("05/30/2021");
            page.release.Clear();
            page.release.SendKeys("10012025");
            page.release.GetAttribute("value").Equals("10/01/2025");
            page.release.SendKeys(today.Day.ToString());
            page.release.GetAttribute("value").Equals(today.Day.ToString());


            //Testing rating positive
            page.ratings.SendKeys("1");
            page.ratings.GetAttribute("value").Equals("1");
            page.ratings.Clear();
            page.ratings.SendKeys("5");

            //Testing add movie button
            page.addMovie.Click();

            
        }
        [Test, Category("Negative")]
        public void negative()
        {           
            //Negative testing Title
            page.title.Clear();
            page.title.SendKeys("12345678901112131415161718192021222324252627282930313233343536373839404142434445464748495051525354555657585960616263646566676869707172737475767778798081828384858687888990919293949596979899100101102103104105106107108109110111112113114115116117118119120121122123124125126127128129130313132133134135136137138139140141142143144145146147148149150151152153154155156157158159160161162163164165166167168169170171172173174175176177178179180181182183184185186187188189190191192193194195196197198199200");
            page.title.GetAttribute("value").Equals("12345678901112131415161718192021222324252627282930313233343536373839404142434445464748495051525354555657585960616263646566676869707172737475767778798081828384858687888990919293949596979899100101102103");

            //Negative Testing Release Date
            page.release.SendKeys("aaaabbbb");
            page.release.GetAttribute("value").Equals(null);
            page.release.SendKeys("01012014");
            page.release.SendKeys(Keys.Enter);
            page.release.GetAttribute("value").Equals("01/01/2014");

            //Negative Testing Ratings
            page.ratings.SendKeys("a");
            page.ratings.GetAttribute("value").Equals(null);
            page.ratings.SendKeys("@");
            page.ratings.GetAttribute("value").Equals(null);
            page.ratings.SendKeys("0" );
            page.ratings.SendKeys(Keys.Enter);
            page.ratings.GetAttribute("value").Equals("0");
            page.ratings.Clear();
            page.ratings.SendKeys("6");
            page.ratings.GetAttribute("value").Equals("6");
            page.ratings.Clear();
            page.ratings.SendKeys("10" + Keys.Enter);

            //popup is not working with driver.alert().switchTo().Alert()
            //unable to test the constraints through automation but ideally the code would look like
            // string text = driver.alert().switchTo().Alert().Text;
            // text.isEqual("Value must be between 10/15/2015 or later.")
            // Visually validated that this error does popup

            //Website is not throwing error for when ratings goes outside of the min or max. It is causing the
            //calendar popup warning to appear. Therefore I cannot validate the constraints. I would push this back to the
            //dev and advise that the the popup constraints are not working as expected.

        }     
    }
}

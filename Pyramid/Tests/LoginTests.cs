using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Newtonsoft.Json;
using NUnit.Framework;
using Pyramid.Infrastructure;
using Pyramid.Pages;

namespace Pyramid.Tests
{
    
    
    public class LoginTests
    {


        [Test]
        public void LoginToLinkedinWillReturn()
        {
            #region oldCode
            /*driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl("https://www.linkedin.com/home");
            driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]")).Click();
            IWebElement user = driver.FindElement(By.Id("username"));
            user.SendKeys("gilnada007@gmail.com");
            IWebElement pass = driver.FindElement(By.Id("password"));
            pass.SendKeys("gtgtgt");
            driver.FindElement(By.XPath("//button[text()='Sign in']")).Click();
            driver.FindElement(By.XPath("//span[text()='Me']/..")).Click();
            driver.FindElement(By.XPath("//*[text()='View Profile']")).Click();
            driver.FindElement(By.XPath("//a[contains(@href,'people')]")).Click();
            List<string> names = new(), lastjobs = new(), locations = new();
            var list = By.CssSelector(".entity-result__item");
              
                          var connectionElements = driver.FindElements(list);
            string name, lastJob, location;
            List<Person> people = new List<Person>();
            foreach (var element in connectionElements)
            {
                name = element.FindElement(By.CssSelector("a span[aria-hidden='true']")).Text;
                lastJob = element.FindElement(By.CssSelector(".entity-result__primary-subtitle")).Text;
                location = element.FindElement(By.CssSelector(".entity-result__secondary-subtitle")).Text;
                people.Add(new Person(name, lastJob, location));

            }


            var json = JsonConvert.SerializeObject(people, Formatting.Indented);
            Console.WriteLine(json);*/

            #endregion
            var mainPage=Website.GoToSignInPage();
            mainPage.SignIn();
            mainPage.GoToProfilePage();
            mainPage.GoToConnections();
            var json=mainPage.LogPageJson();
            Assert.IsTrue(json.Contains("Israel"));

        }
    }
}
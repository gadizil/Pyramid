using OpenQA.Selenium;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Chrome;
using Pyramid.Infrastructure;
using OpenQA.Selenium.Interactions;

namespace Pyramid.Pages
{
    public class MainPage
    {
        IWebDriver driver;

        public MainPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://linkedin.com/home");

        }

        public void SignIn()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]")).Click();
            var username = Config.Username;
            var password = Config.Password;
            IWebElement user = driver.FindElement(By.Id("username"));
            user.SendKeys(username);
            IWebElement pass = driver.FindElement(By.Id("password"));
            pass.SendKeys(password);
            driver.FindElement(By.XPath("//button[text()='Sign in']")).Click();
        }

        public void GoToProfilePage()
        {
            driver.FindElement(By.XPath("//span[text()='Me']/..")).Click();
            driver.FindElement(By.XPath("//*[text()='View Profile']")).Click();
        }

        internal void GoToConnections()
        {
            driver.FindElement(By.XPath("//a[contains(@href,'people')]")).Click();
            driver.Navigate().GoToUrl("https://www.linkedin.com/search/results/people/?network=%5B%22F%22%5D&sid=alZ");
        }

        internal string LogPageJson()
        {
            List<string> names = new(), lastjobs = new(), locations = new();
            var connectionElements = driver.FindElements(By.CssSelector(".entity-result__item"));
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
            Console.WriteLine(json);
            return json;
        }
    }
}

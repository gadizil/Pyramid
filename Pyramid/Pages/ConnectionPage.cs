using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pyramid.Infrastructure;

namespace Pyramid.Pages
{
    internal class ConnectionPage
    {
        IWebDriver driver;
        public ConnectionPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://https://www.linkedin.com/feed/");
            driver.FindElement(By.XPath("//span[text()='Me']/..")).Click();
            driver.FindElement(By.XPath("//*[text()='View Profile']")).Click();
        }

        public string LogPageJson()
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
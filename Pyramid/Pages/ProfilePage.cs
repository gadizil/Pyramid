using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pyramid.Infrastructure;

namespace Pyramid.Pages
{
    internal class ProfilePage
    {
        IWebDriver driver;
        public ProfilePage()
        {
            var mainPage=new MainPage();
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }

        internal ConnectionPage GoToConnections()
        {
            driver.FindElement(By.XPath("//a[contains(@href,'people')]")).Click();
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
            javaScriptExecutor.ExecuteScript("window.scrollTo(0,1000)");
            return new ConnectionPage();
        }
    }
}
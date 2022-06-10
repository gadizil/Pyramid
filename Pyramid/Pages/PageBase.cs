using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pyramid.Pages
{
    public class PageBase
    {
        ChromeDriver driver;
        public PageBase(IWebDriver driver)
        {
            
        }

        public ChromeDriver Driver
        {
            get
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(15);
                driver.Manage().Window.Maximize();
                return driver;
            }
            
        }

    }


}

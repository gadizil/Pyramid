using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Pyramid.Infrastructure
{
    public class Config
    {
        public static readonly string LastVersionChromeDriverFile = "..\\Webdriver\\chromedriver.exe";
        public static readonly string LastVersionFirefoxDriverFile = "..\\Webdriver\\geckodriver.exe";
        public static readonly string Username = "gilnada007@gmail.com";
        public static readonly string Password = "gtgtgt";
        public static ChromeDriver GetDriver()
        {
            return new ChromeDriver();
        }
        
    }
}

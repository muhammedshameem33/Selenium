using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingBookSwagon
{
    public class Factory
    {
        public static IWebDriver StartBrowser(string browserName,string url)
        {
            IWebDriver driver=null;
            if (browserName.Equals("chrome"))
            {
               driver = new ChromeDriver();
            }

            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}

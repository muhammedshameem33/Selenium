using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingBookSwagon.Pages
{
    public class SearchPage
    {
        public IWebDriver WebDriver { get; }

        public SearchPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI elements
        public IWebElement searchInput => WebDriver.FindElement(By.Id("ctl00_TopSearch1_txtSearch"));

        public IWebElement searchButton => WebDriver.FindElement(By.Id("ctl00_TopSearch1_Button1"));

    }
}

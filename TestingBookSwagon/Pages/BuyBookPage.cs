using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingBookSwagon.Pages
{
    public class BuyBookPage
    {
        IWebDriver webDriver = Factory.StartBrowser("chrome", "https://www.bookswagon.com");
        SearchPage searchPage = null;
        LoginPage loginPage = null;

    }
}

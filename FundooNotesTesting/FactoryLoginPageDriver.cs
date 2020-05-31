using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooNotesTesting
{
    public class FactoryLoginPageDriver
    {
        public static IWebDriver webDriver = Factory.StartBrowser("chrome", "http://localhost:4200/login");
    }
}

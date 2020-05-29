using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingBookSwagon.Pages
{
    public class BuyBookPage
    {
        private readonly IWebDriver driver;

        public BuyBookPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //UI Elements
        public IWebElement firstBook => driver.FindElement(By.XPath("//div[@class='search-results fltrs']//div[1]//div[2]//div[1]//div[1]//a[1]"));

        public IWebElement buyNowbutton => driver.FindElement(By.XPath("//div[1]//div[4]//div[5]//a[1]"));

        public IWebElement shopingCart => driver.FindElement(By.XPath("//input[@id='BookCart_lvCart_imgPayment']"));

        public void ClickFirstBook() => this.firstBook.Click();

        public void ClickBuyButton() => this.buyNowbutton.Click();

        public bool IsDisplayed() => this.shopingCart.Displayed;
    }
}

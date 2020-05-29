using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingBookSwagon.Pages
{
    public class PlaceOrderPage
    {
        
        private readonly IWebDriver driver;

        public PlaceOrderPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //UI Elements

        public IWebElement placeOrderButton => driver.FindElement(By.XPath("//input[@id='BookCart_lvCart_imgPayment']"));
        public IWebElement checkoutCart => driver.FindElement(By.XPath("//div[@class='checkout-head-new']//img[1]"));

        public void ClickPlaceOrderButton() => this.placeOrderButton.Click();

        public bool IsDisplayed() => this.checkoutCart.Displayed;
    }
}

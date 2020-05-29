using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestingBookSwagon.Pages;
using System.Drawing.Imaging;

namespace TestingBookSwagon.Steps
{
    [Binding]
    public class PlaceOrderSteps
    {
        IWebDriver webDriver = Factory.StartBrowser("chrome", "https://www.bookswagon.com");
        BuyBookPage buyBook = null;
        SearchPage searchPage = null;
        LoginPage loginPage = null;
        PlaceOrderPage placeOrderPage = null;

        [Given(@"I launched the site")]
        public void GivenILaunchedTheSite()
        {
            loginPage = new LoginPage(webDriver);
        }
        
        [Given(@"I clicked login")]
        public void GivenIClickedLogin()
        {
            loginPage.ClickLogin();
        }
        
        [Given(@"I enterered the following details")]
        public void GivenIEntereredTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login((string)data.Email, (string)data.Password);
        }
        [Given(@"I clicked login buttn")]
        public void GivenIClickedLoginButtn()
        {
            loginPage.ClickLoginButton();
        }

        [Given(@"I enter compter as search keyword")]
        public void GivenIEnterCompterAsSearchKeyword()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            searchPage = new SearchPage(webDriver);
            searchPage.Search("computer");
        }
        
        [When(@"I clicked the search button")]
        public void WhenIClickedTheSearchButton()
        {
            searchPage.ClickSearchButton();
        }
        
        [Then(@"I should be navigate to result page")]
        public void ThenIShouldBeNavigateToResultPage()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Assert.That(searchPage.IsShowResultExist(), Is.True);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
        }
        
        [Then(@"I click the first book link")]
        public void ThenIClickTheFirstBookLink()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            buyBook = new BuyBookPage(webDriver);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            buyBook.ClickFirstBook();
        }
        
        [Then(@"I clicked the Buy Now button")]
        public void ThenIClickedTheBuyNowButton()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            buyBook.ClickBuyButton();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        
        [Then(@"I click place order button")]
        public void ThenIClickPlaceOrderButton()
        {
            webDriver.SwitchTo().Frame(webDriver.FindElement(By.ClassName("cboxIframe")));
            placeOrderPage = new PlaceOrderPage(webDriver);
            placeOrderPage.ClickPlaceOrderButton();
            webDriver.SwitchTo().DefaultContent();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        
        [Then(@"I should see checkout Page")]
        public void ThenIShouldSeeCheckoutPage()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Screenshot screenshot = ((ITakesScreenshot)webDriver).GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\Muhammed Shahan\Desktop\test.Png", ScreenshotImageFormat.Png);
            webDriver.Close();
        }
    }
}

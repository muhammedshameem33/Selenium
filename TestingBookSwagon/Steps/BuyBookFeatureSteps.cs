using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestingBookSwagon.Pages;

namespace TestingBookSwagon.Steps
{
    [Binding]
    public class BuyBookFeatureSteps
    {
        IWebDriver webDriver = Factory.StartBrowser("chrome", "https://www.bookswagon.com");
        BuyBookPage buyBook = null;
        SearchPage searchPage = null;
        LoginPage loginPage = null;
        [Given(@"I launched the application")]
        public void GivenILaunchedTheApplication()
        {
            loginPage = new LoginPage(webDriver);
        }

        [Given(@"I clicked login link")]
        public void GivenIClickedLoginLink()
        {
            loginPage.ClickLogin();
        }

        [Given(@"I enterered following details")]
        public void GivenIEntereredFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login((string)data.Email, (string)data.Password);
        }

        [Given(@"I clicked login button")]
        public void GivenIClickedLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Given(@"I enter computer as search keyword")]
        public void GivenIEnterComputerAsSearchKeyword()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            searchPage = new SearchPage(webDriver);
            searchPage.Search("computer");
        }

        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            searchPage.ClickSearchButton();
        }

        [Then(@"I should be navigated to search result page")]
        public void ThenIShouldBeNavigatedToSearchResultPage()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Assert.That(searchPage.IsShowResultExist(), Is.True);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
        }

        [Then(@"I click the first book")]
        public void ThenIClickTheFirstBook()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            buyBook = new BuyBookPage(webDriver);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            buyBook.ClickFirstBook();
        }
        
        [Then(@"I click the Buy Now button")]
        public void ThenIClickTheBuyNowButton()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            buyBook.ClickBuyButton();
        }
        
        [Then(@"I should see My Shopping Cart")]
        public void ThenIShouldSeeMyShoppingCart()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Assert.That(buyBook.IsDisplayed(), Is.True);
            webDriver.Close();
        }
    }
}

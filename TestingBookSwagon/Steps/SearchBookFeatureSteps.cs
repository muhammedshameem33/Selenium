using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestingBookSwagon.Pages;

namespace TestingBookSwagon.Steps
{
    [Binding]
    public class SearchBookFeatureSteps
    {
        IWebDriver webDriver = Factory.StartBrowser("chrome", "https://www.bookswagon.com");
        SearchPage searchPage = null;

        [Given(@"I have launch the Book Swagon Application")]
        public void GivenIHaveLaunchTheBookSwagonApplication()
        {
            searchPage = new SearchPage(webDriver);
        }
        
        [Given(@"I entered computer as search keyword")]
        public void GivenIEnteredComputerAsSearchKeyword()
        {
            searchPage.Search("computer");
        }
        
        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            searchPage.ClickSearchButton();
        }
        
        [Then(@"I should be navigate to search result page")]
        public void ThenIShouldBeNavigateToSearchResultPage()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Assert.That(searchPage.IsShowResultExist(), Is.True);
            webDriver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(25);
        }
    }
}

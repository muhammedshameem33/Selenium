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
        IWebDriver webDriver = new ChromeDriver();
        SearchPage searchPage = null;

        [Given(@"I have launch the Book Swagon Application")]
        public void GivenIHaveLaunchTheBookSwagonApplication()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://www.bookswagon.com");
            searchPage = new SearchPage(webDriver);
        }
        
        [Given(@"I entered computer as search keyword")]
        public void GivenIEnteredComputerAsSearchKeyword()
        {
        }
        
        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
        }
        
        [Then(@"I should be navigate to search result page")]
        public void ThenIShouldBeNavigateToSearchResultPage()
        {
        }
    }
}

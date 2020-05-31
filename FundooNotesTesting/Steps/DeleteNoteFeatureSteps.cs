using FundooNotesTesting.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace FundooNotesTesting.Steps
{
    [Binding]
    public class DeleteNoteFeatureSteps : FactoryLoginPageDriver
    {
        DeletePage deletePage = null;

        [When(@"I click the more button")]
        public void WhenIClickTheMoreButton()
        {
            deletePage = new DeletePage(webDriver);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            deletePage.ClickMoreButton();
        }
        
        [When(@"I click the Delete Note")]
        public void WhenIClickTheDeleteNote()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            deletePage.ClickDeleteButton();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [Then(@"I shouldn't see the note which I deleted")]
        public void ThenIShouldnTSeeTheNoteWhichIDeleted()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.Navigate().Refresh();
            Assert.That(deletePage.IsDeleted(), Is.True);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            webDriver.Close();
        }
    }
}

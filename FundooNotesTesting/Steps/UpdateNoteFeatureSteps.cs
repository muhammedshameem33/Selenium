using FundooNotesTesting.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace FundooNotesTesting.Steps
{
    [Binding]
    public class UpdateNoteFeatureSteps : FactoryLoginPageDriver
    {
        UpdateNotePage updateNotePage = null;

        [When(@"I click first display Note")]
        public void WhenIClickFirstDisplayNote()
        {
            updateNotePage = new UpdateNotePage(webDriver);
            updateNotePage.ClickDisplayNote();
        }
        
        [When(@"I enter title as '(.*)'")]
        public void WhenIEnterTheTitleAs(string title)
        {
            updateNotePage.UpdateNote(title);
        }
        
        [When(@"I click close button")]
        public void WhenIClickCloseButton()
        {
            updateNotePage.ClickCloseButton();
        }
        
        [Then(@"I should see the note which I updated")]
        public void ThenIShouldSeeTheNoteWhichIUpdated()
        {
            Thread.Sleep(3000);
            Assert.That(updateNotePage.IsUpdatedNoteDisplayed(), Is.True);
            webDriver.Close();
        }
    }
}

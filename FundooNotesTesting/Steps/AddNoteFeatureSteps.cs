using FundooNotesTesting.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace FundooNotesTesting.Steps
{
    [Binding]
    public class AddNoteFeatureSteps : FactoryLoginPageDriver
    {
        AddNotePage addNotePage = null;
        
        [When(@"I click on Take a note")]
        public void WhenIClickOnTakeANote()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            addNotePage = new AddNotePage(webDriver);
            addNotePage.ClickTakeANote();
        }

        [When(@"I enter the title as '(.*)' and description as '(.*)'")]
        public void WhenIEnterTheTitleAsAndDescriptionAs(string title, string description)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            addNotePage.AddNote(title, description);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        [When(@"I click the close button")]
        public void WhenIClickTheCloseButton()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            addNotePage.ClickCloseButton();
        }

        [Then(@"I should see the note which I created")]
        public void ThenIShouldSeeTheNoteWhichICreated()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.Navigate().Refresh();
            Assert.That(addNotePage.IsNoteDisplayed(), Is.True);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            webDriver.Close();
        }
    }
}

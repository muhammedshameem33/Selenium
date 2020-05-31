using FundooNotesTesting.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace FundooNotesTesting.Steps
{
    [Binding]
    public class ListViewFeatureSteps : FactoryLoginPageDriver
    {
        ListViewPage listViewPage = null;

        [When(@"I click on List view Icon")]
        public void WhenIClickOnListViewIcon()
        {
            Thread.Sleep(4000);
            listViewPage = new ListViewPage(webDriver);
            listViewPage.ClickListView();
            Thread.Sleep(3000);
        }
        
        [Then(@"I should see the notes in list format")]
        public void ThenIShouldSeeTheNotesInListFormat()
        {
            Assert.That(listViewPage.IsDisplayedInListForm());
            webDriver.Close();
        }
    }
}

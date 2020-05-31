using FundooNotesTesting.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace FundooNotesTesting.Steps
{
    [Binding]
    public class ArchiveNoteFeatureSteps : FactoryLoginPageDriver
    {
        ArchivePage archivePage = null;

        [When(@"I click the Archive Icon")]
        public void WhenIClickTheArchiveIcon()
        {
            archivePage = new ArchivePage(webDriver);
            archivePage.ClickArchiveIcon();
            Thread.Sleep(3000);
        }
        
        [Then(@"I shouldn't see the note which I Archived")]
        public void ThenIShouldnTSeeTheNoteWhichIArchived()
        {
            Assert.That(archivePage.IsArchived());
            webDriver.Close();
        }
    }
}

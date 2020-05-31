using FundooNotesTesting.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace FundooNotesTesting.Steps
{
    [Binding]
    public class ColorFeatureSteps : FactoryLoginPageDriver
    {
        ColorPage colorPage = null;

        [When(@"I click color icon")]
        public void WhenIClickColorIcon()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            colorPage = new ColorPage(webDriver);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            colorPage.ClickColorIcon();
        }
        
        [When(@"I selected the last color")]
        public void WhenISelectedTheLastColor()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            colorPage.SelectLastColor();
        }
        
        [Then(@"I should see the note with the new color")]
        public void ThenIShouldSeeTheNoteWithTheNewColor()
        {
            Assert.That(colorPage.IsColorChanged(), Is.True);
            webDriver.Close();
        }
    }
}

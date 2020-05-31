using FundooNotesTesting.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace FundooNotesTesting.Steps
{
    [Binding]
    public class LogoutFeatureSteps : FactoryLoginPageDriver
    {
        LogoutPage logoutPage = null;

        [When(@"I click the profile icon")]
        public void WhenIClickTheProfileIcon()
        {
            logoutPage = new LogoutPage(webDriver);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            logoutPage.ClickProfileIcon();
        }

        [When(@"I click logout button")]
        public void WhenIClickLogoutButton()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            logoutPage.ClickSignoutButton();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Then(@"I should see login page of Fundoo Notes Application")]
        public void ThenIShouldSeeLoginPageOfFundooNotesApplication()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.That(logoutPage.IsSignInPageDisplayed(), Is.True);
            webDriver.Close();
        }
    }
}

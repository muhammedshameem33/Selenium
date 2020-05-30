using FundooNotesTesting.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace FundooNotesTesting.Steps
{
    [Binding]
    public class ForgotPasswordFeatureSteps
    {
        IWebDriver webDriver = Factory.StartBrowser("chrome", "http://localhost:4200/forgotPassword");
        ForgotPasswordPage forgotPasswordPage = null;

        [Given(@"I launch the Fundoo Notes application")]
        public void GivenILaunchTheFundooNotesApplication()
        {
            forgotPasswordPage = new ForgotPasswordPage(webDriver);
        }

        [Given(@"I enter email as '(.*)'")]
        public void GivenIEnterEmailAs(string p0)
        {
            forgotPasswordPage.ForgotPassword(p0);
        }

        [Given(@"I click continue button")]
        public void GivenIClickContinueButton()
        {
            forgotPasswordPage.ClickContinueButton();
        }
        
        [Then(@"I should be navigated to login page of Fundoo Notes Application")]
        public void ThenIShouldBeNavigatedToLoginPageOfFundooNotesApplication()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Assert.That(forgotPasswordPage.IsLoginPageDisplayed(), Is.True);
            webDriver.Close();
        }
    }
}

using FundooNotesTesting.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FundooNotesTesting.Steps
{
    [Binding]
    public class LoginFeatureSteps : FactoryLoginPageDriver
    {
        LoginPage loginPage = null;

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            loginPage = new LoginPage(webDriver);
        }
        
        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login((string)data.Email, (string)data.Password);
        }
        
        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }
        
        [Then(@"I should see dashboard of Fundoo Notes Application")]
        public void ThenIShouldSeedashboardofFundooNotesApplication()
        {
            Screenshot screenshot = ((ITakesScreenshot)webDriver).GetScreenshot();
            screenshot.SaveAsFile(@"C:\\Users\\Muhammed Shahan\\Desktop\\ss\\test.Png", ScreenshotImageFormat.Png);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Assert.That(loginPage.IsDashboardDisplayed(), Is.True);
        }
    }
}

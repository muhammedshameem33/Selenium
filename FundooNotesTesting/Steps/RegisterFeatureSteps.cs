using FundooNotesTesting.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FundooNotesTesting.Steps
{
    [Binding]
    public class RegisterFeatureSteps
    {
        IWebDriver webDriver = Factory.StartBrowser("chrome", "http://localhost:4200/registration");
        RegisterPage registerPage = null;

        [Given(@"I launch the Fundoo application")]
        public void GivenILaunchTheFundooApplication()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            registerPage = new RegisterPage(webDriver);
        }
        
        [Given(@"I enter following details")]
        public void GivenIEnterFollowingDetails(Table table)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            dynamic data = table.CreateDynamicInstance();
            var formData = new string[5];
            formData[0] = (string)data.FirstName;
            formData[1] = (string)data.LastName;
            formData[2] = (string)data.Email;
            formData[3] = (string)data.Password;
            formData[4] = (string)data.ConfirmPassword;
            registerPage.Register(formData);
        }
        
        [Given(@"I click Register button")]
        public void GivenIClickRegisterButton()
        {
            this.registerPage.ClickRegisterButton();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }
        
        [Then(@"I should see Login Page of Fundoo Notes Application")]
        public void ThenIShouldSeeLoginPageOfFundooNotesApplication()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Assert.That(registerPage.IsLoginPageDisplayed(), Is.True);
        }
    }
}

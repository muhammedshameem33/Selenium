using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestingBookSwagon.Pages;

namespace TestingBookSwagon.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        IWebDriver webDriver = new ChromeDriver();
        LoginPage loginPage = null;

        //step definitions
       [Given (@"I launch the application")]
       public void GivenILaunchTheApplication()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://www.bookswagon.com");
            loginPage = new LoginPage(webDriver);
        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            loginPage.ClickLogin();
        }

        [Given(@"I enter the following details")]
        public void GivenIenterthefollowingdetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login((string)data.Email, (string)data.Password);
        }


        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should see My Account")]
        public void IShouldSeeMyAccount()
        {
            //ScenarioContext.Current.Pending();
            //webDriver.Close();
        }
    }
}

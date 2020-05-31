using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooNotesTesting.Pages
{
    public class LogoutPage
    {
        private readonly IWebDriver webDriver;

        private RegisterPage registerPage = null;

        public LogoutPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            this.registerPage = new RegisterPage(webDriver);
        }

        public IWebElement profileIcon => this.webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/mat-toolbar[1]/button[3]"));

        public IWebElement signoutButton => this.webDriver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[2]/div[1]/div[1]/div[1]/button[1]"));

        public void ClickProfileIcon() => this.profileIcon.Click();

        public void ClickSignoutButton() => this.signoutButton.Click();

        public bool IsSignInPageDisplayed() => this.registerPage.loginPage.Displayed;
    }
}

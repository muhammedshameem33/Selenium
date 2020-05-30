using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooNotesTesting.Pages
{
    public class ForgotPasswordPage
    {
        private readonly IWebDriver webDriver;

        public ForgotPasswordPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement email => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-forgot-password[1]/div[1]/mat-card[1]/form[1]/mat-form-field[1]/div[1]/div[1]/div[3]/input[1]"));

        public IWebElement continueButton => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-forgot-password[1]/div[1]/mat-card[1]/form[1]/div[1]/button[1]"));

        public IWebElement loginPage => webDriver.FindElement(By.XPath("//h1[contains(text(),'Sign In')]"));

        public void ForgotPassword(string email) => this.email.SendKeys(email);

        public void ClickContinueButton() => this.continueButton.Click();

        public bool IsLoginPageDisplayed() => this.loginPage.Displayed;
    }
}

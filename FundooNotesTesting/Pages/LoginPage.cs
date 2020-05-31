using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooNotesTesting.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver webDriver;

        
        public LoginPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement emailText => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-login[1]/div[1]/mat-card[1]/form[1]/mat-form-field[1]/div[1]/div[1]/div[3]/input[1]"));

        public IWebElement passwordText => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-login[1]/div[1]/mat-card[1]/form[1]/mat-form-field[2]/div[1]/div[1]/div[3]/input[1]"));

        public IWebElement loginButton => webDriver.FindElement(By.XPath("//button[@class='mat-focus-indicator mat-raised-button mat-button-base mat-primary']"));

        public IWebElement dashboard => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/mat-toolbar[1]/h3[1]/img[1]"));

        public void Login(string email,string password)
        {
            this.emailText.SendKeys(email);
            this.passwordText.SendKeys(password);
        }

        public void ClickLoginButton() => this.loginButton.Submit();

        public bool IsDashboardDisplayed() => this.dashboard.Displayed;
    }
}

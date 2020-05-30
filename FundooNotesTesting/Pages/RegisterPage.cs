using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooNotesTesting.Pages
{
    public class RegisterPage
    {
        private readonly IWebDriver webDriver;

        public RegisterPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement firstName => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-registration[1]/div[1]/mat-card[1]/form[1]/div[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/input[1]"));

        public IWebElement lastName => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-registration[1]/div[1]/mat-card[1]/form[1]/div[1]/div[2]/mat-form-field[1]/div[1]/div[1]/div[3]/input[1]"));

        public IWebElement email => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-registration[1]/div[1]/mat-card[1]/form[1]/div[2]/mat-form-field[1]/div[1]/div[1]/div[3]/input[1]"));

        public IWebElement password => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-registration[1]/div[1]/mat-card[1]/form[1]/div[3]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/input[1]"));

        public IWebElement confirmPassword => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-registration[1]/div[1]/mat-card[1]/form[1]/div[3]/div[2]/mat-form-field[1]/div[1]/div[1]/div[3]/input[1]"));

        public IWebElement registerButton => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-registration[1]/div[1]/mat-card[1]/form[1]/div[4]/div[2]/button[1]"));

        public IWebElement loginPage => webDriver.FindElement(By.XPath("//h1[contains(text(),'Sign In')]"));

        public void Register(string[] formData)
        {
            this.firstName.SendKeys(formData[0]);
            this.lastName.SendKeys(formData[1]);
            this.email.SendKeys(formData[2]);
            this.password.SendKeys(formData[3]);
            this.confirmPassword.SendKeys(formData[4]);
        }

        public void ClickRegisterButton() => this.registerButton.Submit();

        public bool IsLoginPageDisplayed() => this.loginPage.Displayed;
    }
}

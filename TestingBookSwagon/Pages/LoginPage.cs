using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingBookSwagon.Pages
{
    public class LoginPage
    {
        public IWebDriver WebDriver { get; }

        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI elements
        public IWebElement login => WebDriver.FindElement(By.XPath("//div[@id='ctl00_divLogin']"));

        public IWebElement email => WebDriver.FindElement(By.Id("ctl00_phBody_SignIn_txtEmail"));

        public IWebElement password => WebDriver.FindElement(By.Id("ctl00_phBody_SignIn_txtPassword"));

        public IWebElement submit => WebDriver.FindElement(By.Id("ctl00_phBody_SignIn_txtPassword"));

        public IWebElement myAccount => WebDriver.FindElement(By.Id("ctl00_lblUser"));

        public void ClickLogin() => login.Click();

        public void Login(string email,string password)
        {
            this.email.SendKeys(email);
            this.password.SendKeys(password);
        }

        public void ClickLoginButton() => this.submit.Click();

        public bool IsMyAccountExist() => this.myAccount.Displayed;

    }
}

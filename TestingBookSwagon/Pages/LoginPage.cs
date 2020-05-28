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
        public IWebElement lnkLogin => WebDriver.FindElement(By.XPath("//div[@id='ctl00_divLogin']"));

        public IWebElement txtEmail => WebDriver.FindElement(By.Id("ctl00_phBody_SignIn_txtEmail"));

        public IWebElement txtPassword => WebDriver.FindElement(By.Id("ctl00_phBody_SignIn_txtPassword"));

        public IWebElement btnLogin => WebDriver.FindElement(By.Id("ctl00_phBody_SignIn_txtPassword"));

        public IWebElement lnkMyAccount => WebDriver.FindElement(By.LinkText("My Account"));

        public void ClickLogin() => lnkLogin.Click();

        public void Login(string email,string password)
        {
            txtEmail.SendKeys(email);
            txtPassword.SendKeys(password);
        }
        //sir it's displayed already
        public void ClickLoginButton() => btnLogin.Click();

        public bool IsMyAccountExist() => lnkMyAccount.Displayed;

    }
}

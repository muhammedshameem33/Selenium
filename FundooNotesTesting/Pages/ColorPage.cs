using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FundooNotesTesting.Pages
{
    public class ColorPage
    {
        private readonly IWebDriver webDriver;

        public ColorPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        private IWebElement colorButton => this.webDriver.FindElement(By.XPath("//mat-card[1]//div[3]//app-icon[1]//div[1]//button[3]"));

        private IWebElement lastColor => this.webDriver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[3]/mat-card[4]"));

        public IWebElement displayCard => this.webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/mat-sidenav-container[1]/mat-sidenav-content[1]/app-notes[1]/app-display[1]/div[1]/mat-card[1]"));

        private string previousColor;

        private string newColor;

        public void ClickColorIcon() => this.colorButton.Click();

        public void SelectLastColor()
        {
            this.previousColor = this.displayCard.GetCssValue("background");
            this.lastColor.Click();
            //IJavaScriptExecutor executor = (IJavaScriptExecutor)webDriver;
            //executor.ExecuteScript("document.evaluate('//mat-card[1]//div[3]//app-icon[1]//div[1]//button[3]', document, null, XPathResult.ANY_TYPE, null).click();");
            Thread.Sleep(7000);
            this.newColor = this.displayCard.GetCssValue("background");
        }

        public bool IsColorChanged()
        {
            if (this.previousColor.Equals(this.newColor))
            {
                return false;
            }

            return true;
        }

    }
}

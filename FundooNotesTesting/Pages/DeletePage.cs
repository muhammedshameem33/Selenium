using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooNotesTesting.Pages
{
    public class DeletePage
    {
        private readonly IWebDriver webDriver;

        public DeletePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        private IWebElement moreButton => this.webDriver.FindElement(By.XPath("//mat-card[1]//div[3]//app-icon[1]//div[1]//button[6]"));

        private IWebElement deleteNoteButton => this.webDriver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[2]/div[1]/div[1]/div[1]/button[2]"));

        private bool deleted = false;

        public void ClickMoreButton() => this.moreButton.Click();

        public void ClickDeleteButton()
        {
            this.deleteNoteButton.Click();
            this.deleted = true;
        }

        public bool IsDeleted()
        {
            if (deleted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

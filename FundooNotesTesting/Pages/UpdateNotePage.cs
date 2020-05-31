using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooNotesTesting.Pages
{
    public class UpdateNotePage
    {
        private readonly IWebDriver webDriver;
        AddNotePage addNotePage = null;
        private string previousTitle;
        public UpdateNotePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            addNotePage = new AddNotePage(webDriver);
            previousTitle = addNotePage.title.Text;
        }

        public IWebElement title => this.webDriver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[2]/div[1]/mat-dialog-container[1]/app-edit-note[1]/div[1]/div[1]/div[1]"));

        public IWebElement closeButton => this.webDriver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[2]/div[1]/mat-dialog-container[1]/app-edit-note[1]/div[1]/div[2]/button[1]"));

        public IWebElement displayCard => this.webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/mat-sidenav-container[1]/mat-sidenav-content[1]/app-notes[1]/app-display[1]/div[1]/mat-card[1]/div[1]"));

        private string currentTitle;

        public void ClickDisplayNote() => displayCard.Click();

        public void UpdateNote(string title)
        {
            this.currentTitle = title;
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            this.title.SendKeys(title);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public void ClickCloseButton() => this.closeButton.Click();

        public bool IsUpdatedNoteDisplayed()
        {
            return previousTitle != this.currentTitle;
        }
    }
}

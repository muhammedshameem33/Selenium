using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooNotesTesting.Pages
{
    public class AddNotePage
    {
        private readonly IWebDriver webDriver;

        public AddNotePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public IWebElement takeNoteField => webDriver.FindElement(By.XPath("//input[@placeholder='Take a note']"));

        public IWebElement title => webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/mat-sidenav-container[1]/mat-sidenav-content[1]/app-notes[1]/app-display[1]/div[1]/mat-card[1]/div[1]/div[1]"));

        public IWebElement description => webDriver.FindElement(By.XPath("//div[@class='searchbox description-box']"));

        public IWebElement closeButton => webDriver.FindElement(By.XPath("//button[@class='mat-focus-indicator btn mat-button mat-button-base ng-star-inserted']"));

        public IWebElement displaynote => webDriver.FindElement(By.XPath("//app-display[@class='ng-star-inserted']//mat-card[1]"));

        public void ClickTakeANote() => this.takeNoteField.Click();

        public void AddNote(string title,string description)
        {
            this.title.SendKeys(title);
            this.description.SendKeys(description);
        }

        public void ClickCloseButton() => this.closeButton.Click();

        public bool IsNoteDisplayed() => this.displaynote.Displayed;
    }
}

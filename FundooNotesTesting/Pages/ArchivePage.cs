using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooNotesTesting.Pages
{
    public class ArchivePage
    {
        private readonly IWebDriver webDriver;

        public ArchivePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement archiveIcon => this.webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/mat-sidenav-container[1]/mat-sidenav-content[1]/app-notes[1]/app-display[1]/div[1]/mat-card[1]/div[3]/app-icon[1]/div[1]/button[5]/span[1]/span[1]"));

        private bool archived = false;
        public void ClickArchiveIcon()
        {
            this.archiveIcon.Click();
            this.archived = true;
        }

        public bool IsArchived() => this.archived;
    }
}

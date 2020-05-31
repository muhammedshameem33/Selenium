using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooNotesTesting.Pages
{
    public class ListViewPage
    {
        private readonly IWebDriver webDriver;

        public ListViewPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement listView => this.webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/mat-toolbar[1]/button[2]"));

        public IWebElement noteCard => this.webDriver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-dashboard[1]/div[1]/mat-sidenav-container[1]/mat-sidenav-content[1]/app-notes[1]/app-display[1]/div[1]/mat-card[1]"));

        public void ClickListView() => this.listView.Click();

        public bool IsDisplayedInListForm()
        {
            if (this.noteCard.GetCssValue("width").Equals("20%"))
            {
                return false;
            }

            return true;
        }
    }
}

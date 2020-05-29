using System;
using TechTalk.SpecFlow;

namespace FundooNotesTesting.Steps
{
    [Binding]
    public class LoginFeatureSteps
    {
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
        }
        
        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
        }
        
        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
        }
        
        [Then(@"I should see My Account")]
        public void ThenIShouldSeeMyAccount()
        {
        }
    }
}

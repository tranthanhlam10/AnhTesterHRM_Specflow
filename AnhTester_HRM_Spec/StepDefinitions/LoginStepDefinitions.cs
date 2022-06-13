using AnhTester_HRM_Spec.Bases;
using NUnit.Framework;

namespace AnhTester_HRM_Spec.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        
        BasePage basePage = new BasePage();

        [Given(@"I have set up and navigated to HRM Website")]
        public void GivenIHaveSetUpAndNavigatedToHRMWebsite()
        {
            basePage.SetupBrowser();
        }

        [Given(@"I typed (.*) and (.*)")]
        public void GivenITypedAdminAnd(string username, string password)
        {
            LoginPage.GetInstance().InputUsernameAndPassword(username, password);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            LoginPage.GetInstance().ClickTheLoginButton();
        }

        [Then(@"I must see HRM system")]
        public void ThenIMustSeeHRMSystem()
        {
            Assert.AreEqual("https://hrm.anhtester.com/erp/login", LoginPage.GetInstance().SeeTheHomepageOfHRM());
            basePage.tearDown();
        }
    }
}

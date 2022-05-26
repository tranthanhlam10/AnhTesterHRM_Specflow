using AnhTester_HRM_Spec.Bases;
using NUnit.Framework;

namespace AnhTester_HRM_Spec.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        LoginPage loginPage = new LoginPage();
        BasePage basePage = new BasePage();

        [Given(@"I have set up and navigated to HRM Website")]
        public void GivenIHaveSetUpAndNavigatedToHRMWebsite()
        {
            basePage.SetupBrowser();
        }

        [Given(@"I typed (.*) and (.*)")]
        public void GivenITypedAdminAnd(string username, string password)
        {
            loginPage.InputUsernameAndPassword(username, password);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            loginPage.ClickTheLoginButton();
        }

        [Then(@"I must see HRM system")]
        public void ThenIMustSeeHRMSystem()
        {
            //loginPage.SeeTheHomepageOfHRM();
            Assert.AreEqual("https://hrm.anhtester.com/erp/desk", loginPage.SeeTheHomepageOfHRM());
        }
    }
}

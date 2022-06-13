using AnhTester_HRM_Spec.Bases;
using System;
using TechTalk.SpecFlow;

namespace AnhTester_HRM_Spec.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions
    {
        BasePage basePage = new BasePage();
        
        [Given(@"I must nagative and login to HRM page")]
        public void GivenIMustNagativeAndLoginToHRMPage()
        {
            basePage.SetupBrowser();
        }

        [Given(@"I type (.*) and (.*) to login")]
        public void GivenITypeAdminAndToLogin(string username, string password)
        {
            LoginPage.GetInstance().InputUsernameAndPassword(username, password);
        }

        [When(@"I click login button to see the HRM")]
        public void WhenIClickLoginButtonToSeeTheHRM()
        {
            LoginPage.GetInstance().ClickTheLoginButton();
        }

        [Then(@"I must see the HRM")]
        public void ThenIMustSeeTheHRM()
        {
            LoginPage.GetInstance().SeeTheHomepageOfHRM();
        }

        [Given(@"I nagative to Employee Page")]
        public void GivenINagativeToEmployeePage()
        {
            EmployeePage.GetInstance().NagativeToEmployeePage();
        }

        [When(@"I find the employee role (.*)")]
        public void WhenIFindTheEmployeeRoleAutomation(string role)
        {
            EmployeePage.GetInstance().GetRoleTotalNumber(role).Should().Be(2);

        }

        [Then(@"I must see result of my expected \?")]
        public void ThenIMustSeeResultOfMyExpected()
        {
            EmployeePage.GetInstance().MustSeeEmployeePage();
        }
    }
}

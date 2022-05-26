using AnhTester_HRM_Spec.Bases;
using System;
using TechTalk.SpecFlow;

namespace AnhTester_HRM_Spec.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions
    {
        LoginPage loginPage = new LoginPage();
        BasePage basePage = new BasePage();
        EmployeePage employeePage = new EmployeePage(); 
        
        [Given(@"I must nagative and login to HRM page")]
        public void GivenIMustNagativeAndLoginToHRMPage()
        {
            basePage.SetupBrowser();
        }

        [Given(@"I type (.*) and (.*) to login")]
        public void GivenITypeAdminAndToLogin(string username, string password)
        {
            loginPage.InputUsernameAndPassword(username, password);
        }

        [When(@"I click login button to see the HRM")]
        public void WhenIClickLoginButtonToSeeTheHRM()
        {
            loginPage.ClickTheLoginButton();
        }

        [Then(@"I must see the HRM")]
        public void ThenIMustSeeTheHRM()
        {
            loginPage.SeeTheHomepageOfHRM();
        }

        [Given(@"I nagative to Employee Page")]
        public void GivenINagativeToEmployeePage()
        {
            employeePage.NagativeToEmployeePage();
        }

        [When(@"I find the employee role (.*)")]
        public void WhenIFindTheEmployeeRoleAutomation(string role)
        {
            employeePage.FindEmRole(role).Should().Be(2);

        }

        [Then(@"I must see result of my expected \?")]
        public void ThenIMustSeeResultOfMyExpected()
        {
            employeePage.MustSeeEmployeePage();
        }
    }
}

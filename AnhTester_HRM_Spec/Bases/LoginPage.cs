using OpenQA.Selenium;

namespace AnhTester_HRM_Spec.Bases
{
    class LoginPage : BasePage
    {
        private static LoginPage instance;
        private LoginPage() { }
        public static LoginPage GetInstance()
        {
            if(instance == null)
                instance = new LoginPage();
            return instance;
        }

        //Get locator for Login testing
        By txtUserName = By.XPath("//input[@id='iusername']");
        By txtPassWord = By.XPath("//input[@id='ipassword']");
        By btnLogin = By.XPath("//span[@class='ladda-label']");

        public void InputUsernameAndPassword(string username, string password)
        {
            driver.Navigate().GoToUrl("https://hrm.anhtester.com/erp/login");
            driver.FindElement(txtUserName).SendKeys(username);
            driver.FindElement(txtPassWord).SendKeys(password);     
        }

        public void ClickTheLoginButton()
        {
            driver.FindElement(btnLogin).Click();
        }

        public string SeeTheHomepageOfHRM()
        {           
            return driver.Url;    
        }
    }
}

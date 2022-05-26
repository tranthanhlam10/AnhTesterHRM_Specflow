using System;
using System.Threading;
using OpenQA.Selenium;

namespace AnhTester_HRM_Spec.Bases
{
    class LoginPage : BasePage
    {
        //Get locator for Login testing
        By txtUserName = By.XPath("//input[@id='iusername']");
        By txtPassWord = By.XPath("//input[@id='ipassword']");
        By btnLogin = By.XPath("//span[@class='ladda-label']");

        public void InputUsernameAndPassword(string username, string password)
        {
            driver.Navigate().GoToUrl("https://hrm.anhtester.com/erp/login");
            Thread.Sleep(3000);
            Console.WriteLine("Lam");
            driver.FindElement(txtUserName).SendKeys(username);
            driver.FindElement(txtPassWord).SendKeys(password);     
        }

        public void ClickTheLoginButton()
        {
            driver.FindElement(btnLogin).Click();
        }

        public string SeeTheHomepageOfHRM()
        {
            Thread.Sleep(5000);
            return driver.Url;
            //driver.Quit();
        }
    }
}

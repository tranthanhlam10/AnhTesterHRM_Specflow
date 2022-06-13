using OpenQA.Selenium;

namespace AnhTester_HRM_Spec.DriverManage
{
    public abstract class BDriverManager 
    {
        public abstract IWebDriver GetDriver();
    }
}

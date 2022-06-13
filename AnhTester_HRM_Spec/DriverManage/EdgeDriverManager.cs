using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AnhTester_HRM_Spec.DriverManage
{
    public class EdgeDriverManager : BDriverManager
    {
        override
        public IWebDriver GetDriver()
        {
            new DriverManager().SetUpDriver(new EdgeConfig());
            return new EdgeDriver();
        }
    }
}

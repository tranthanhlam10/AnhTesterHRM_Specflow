using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AnhTester_HRM_Spec.DriverManage
{
    public class ChromeDriverManager: BDriverManager
    {
        override
        public IWebDriver GetDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }
    }
}

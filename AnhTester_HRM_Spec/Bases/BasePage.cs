using OpenQA.Selenium;
using Microsoft.Extensions.Configuration;
using AnhTester_HRM_Spec.Support;
using AnhTester_HRM_Spec.DriverManage;

namespace AnhTester_HRM_Spec.Bases
{
    public class BasePage
    {
        public static IWebDriver driver;
        public static Config config;
        
        public void SetupBrowser()
        {
            // read file config json
            config = new Config();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("Support/Config.json");
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);

            // setup driver
            driver = BDriverFactory.InitDriver(config.env);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
        }

        public void tearDown()
        {
            Console.WriteLine(config.os);
            driver.Quit();
        }
    }
}

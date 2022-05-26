using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Microsoft.Extensions.Configuration;
using AnhTester_HRM_Spec.Support;

namespace AnhTester_HRM_Spec.Bases
{
    class BasePage
    {
        public static IWebDriver driver;

        Config config = new Config();
        public void SetupBrowser()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("C:/Specflow/AnhTester_HRM_Spec/AnhTester_HRM_Spec/Support/Config.json");
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);
            Thread.Sleep(1000);
            
            switch (config.env)
            {
                case "chrome":
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
                    break;
                case "edge":
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
                    break;
            }
        }

        public void tearDown()
        {
            driver.Quit();
        }
    }
}

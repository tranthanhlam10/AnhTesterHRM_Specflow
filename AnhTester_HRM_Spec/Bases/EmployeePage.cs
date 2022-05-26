using OpenQA.Selenium;

namespace AnhTester_HRM_Spec.Bases
{
    class EmployeePage : BasePage
    {
        //Get locator for role test
        //NOTE: Table must take full xpath
        By roleName = By.XPath("/html/body/div[2]/div/div[4]/div[2]/div/div/div[2]/div/table/tbody/tr/td[2]");

        public void NagativeToEmployeePage()
        {
            driver.Navigate().GoToUrl("https://hrm.anhtester.com/erp/staff-list");
            Thread.Sleep(2000);
        }

        public int FindEmRole(string role)
        {
            List<IWebElement> roleList = new List<IWebElement>(driver.FindElements(roleName));
            int i = 0;
            foreach (var roleE in roleList)
            {
                if (String.Compare(roleE.Text, role) == 0)
                {
                    i++;
                }
            }
            Console.WriteLine("Co tong cong " + i + " "+role+" Tester trong cong ty");
            return i;
        }
        public void MustSeeEmployeePage()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }

    }
}

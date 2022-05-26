
# Selenium C# - Anh Tester HRM System

This is a test project written in C# programming language, with Selenium framework and Specflow library.

## Programming tools and libraries
- Visual Studio 2022
- .Net 6.0
- Selenium
- Webdriver Manager
- Nunit
- Browser Driver
- Fluent Assertions
- Microsoft.Extensions.Configuration.Binder
- Microsoft.Extensions.Configuration.Json
- Microsoft.NET.Test.Sdk
- nRetry.SpecFlowPlugin
- SpecFlow
- SpecFlow.Plus.LivingDocPlugin
- SpecFlow.Tools.MsBuild.Generation
 *Install on Nuget package*

## Main test case

### Login
- Login basic: Add username and password to function and test. (Use data driven testing on Specflow).

### EmployeePage
- Test HTML table by Selenium C#: find number of Employee in this HRM.

## Run test
- Open commandline and type "dotnet test" to run all test.
- Open commandline and type "dotnet test --filter "TestCategory=tagname" to run all test.
*tagname is defined before scenairo*.
*you also define same tagname to group more test cases you wanna run*

### Step to change Browser
1. Open Config.Json.
2. Chang value of env, if you want to use Edge Browser, change "chrome" to "edge".

### Step to export report
1. Open commandline
2. Get path of project.dll file (""location of project in your computer"\bin\Debug\net6.0\AnhTester_HRM_Spec.dll).
3. Type "livingdoc test-assembly "previous path you get on step 2".
4. The Livingdoc.html will be generated.

### How to assert on Specflow ?
- You can use Test libraries support for Selenium C# (NUnit, xNuit, MStest). I used NUnit to assert for login function.
- I suggest to use Fluent Assertions is more convenient. It's easy to use and easy to read. I used it to assert for employee function.

### How to retry fail test case on Specflow
- Use the nRetry Library. 
- You add annotation @retry(n) before scenario with n is a number of repetitions.

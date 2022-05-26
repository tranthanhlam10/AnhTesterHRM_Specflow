Feature: Employee

Find number of automation tester in this company

@tag1
Scenario: EmployeeTest
	Given I must nagative and login to HRM page
	Given I type <username> and <password> to login
	When I click login button to see the HRM
	Then I must see the HRM
	Given I nagative to Employee Page
	When I find the employee role <role>
	Then I must see result of my expected ?
	Examples: 
		| username | password | role		|
		| admin01  | 123456   | Automation	|
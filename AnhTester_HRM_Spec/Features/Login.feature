Feature: Login

Test login with account admin role
@retry(2)
@tag1
Scenario: Login Test
	Given I have set up and navigated to HRM Website
	Given I typed <username> and <password>
	When I click login button
	Then I must see HRM system
	Examples: 
		| username   | password |
		| admin01	 | 123456	|
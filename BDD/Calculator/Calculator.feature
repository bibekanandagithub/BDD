Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

	Scenario: Create a new employee with mandatory details
	#Given I have opened my Application
	#Then I should see employee detils page
	When i fill all the mandatory details in form
	|Name	| Age | Phone     | Email                        |
	|Bibek	|34   |8895591255 |bibekanand.panigrahi@bkfs.com |
	|RAJU	|51   |123456789 |rahuk.panigrahi@bkfs.com |
	|john	|30   |321654987 |dem.panigrahi@bkfs.com |
	#And I click the save button
	#Then I should see all the details saved in my application and DB



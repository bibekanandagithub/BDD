Feature: OutlineBoardExample
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Create a new  mandatory details for different iteration
	#Given I have opened my Application
	#Then I should see employee detils page
	When i even important  details in of  <empname>, <empage> and <empphone>
	#And I click the save button
	#Then I should see all the details saved in my application and DB
	Examples: 
	| Name  | Age | Phone      |
	| Bibek | 34  | 8895591255 |
	| RAJU  | 51  | 123456789  |
	| john  | 30  | 321654987  |

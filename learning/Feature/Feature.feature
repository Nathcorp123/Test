Feature: Feature
	Simple calculator for adding two numbers

@Login into Flight booking application
Scenario Outline: Open Flight booking application and make login into it
	Given Launch the flight booking application
	And Click on the Login button to make login into application.
	When Enter to valid emailid<emailid> and pasword<password>
	Then Click on the Login button to make login
	Then Verift the Title of Home page
	@source:Flight.xlsx:Sheet1
	Examples:
		| emailid | password |
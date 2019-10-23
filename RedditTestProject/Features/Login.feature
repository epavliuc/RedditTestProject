Feature: Login
As a user I want to be able to login onto Reddit

Scenario: Valid Login
	Given I am on the home page
	And Input valid details
	And I click on the sign in button
	Then I should see the username on the homepage

Scenario: Invalid Password Login
	Given I am on the home page
	And Input invalid password
	And I click on the sign in button
	Then I should see the correct error message

Scenario: Invalid Email Login
	Given I am on the home page
	And Input invalid email
	And I click on the sign in button
	Then I should see the correct related error message 

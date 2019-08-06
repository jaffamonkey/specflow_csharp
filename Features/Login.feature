Feature: Login
	As an admin user I want to be able to login

#@smoke
Scenario: Admin Login
	Given the user is on the login page
	When they enter valid admin credentials add
	Then they should be taken to the home page
	 
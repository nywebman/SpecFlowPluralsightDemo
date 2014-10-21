Feature: New User Registration
	In order to get access to the member-only features
	As a potential user
	I want to create an account

@authenticationSuperset
Scenario: Password Strength Indicator
	Given I'm on the registration page
	When I enter a password of Pass
	Then the password strength indicator should read Poor
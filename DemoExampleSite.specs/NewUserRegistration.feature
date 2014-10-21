Feature: New User Registration
	In order to get access to the member-only features
	As a potential user
	I want to create an account

@authenticationSuperset
Scenario Outline: Password Strength Indicator
	Given I'm on the registration page
	When I enter a password of <password>
	Then the password strength indicator should read <strength>

Examples: 
| password      | strength |
| pass          | Poor     |
| password      | Average  |
| long password | Awesome  |
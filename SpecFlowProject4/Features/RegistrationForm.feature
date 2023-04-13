Feature: RegistrationForm

As a user
    I want to register for an account
    So that I can access the website's features
@tag1
Scenario: Fill out registration form
	Given I navigate to website
	And I enter First name
	And I enter Last name
	And I enter address
	And I enter Email address
	#And I choose file to upload photo
	And I enter Phone number
	And I select my Gender
	And I select my Hobbie
	#And I select my Language
	#And I select English
	And I select my Skills
	And I select my Country
	And I select my Day of birth
	And I select my Month of birth
	And I select my yeat of birth
	And I enter Password
	And I confirm Password
	When I click on the Submit button
	#Then I should be able to register successfully
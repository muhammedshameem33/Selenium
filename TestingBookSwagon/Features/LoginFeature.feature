Feature: LoginFeature
	Login to Book Swagon Application

@smoke
Scenario: Perform Login of Book Swagon Application site
	Given I launch the application
	And I click login link
	And I enter the following details
		| Email               | Password |
		| demod5429@gmail.com | demodemo |
	And I click login button
	Then I should see My Account

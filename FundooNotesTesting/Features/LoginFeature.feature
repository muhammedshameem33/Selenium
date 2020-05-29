Feature: LoginFeature
	Login to Fundoo Notes Application

@smoke
Scenario: Perform Login of Fundoo Notes Application
	Given I launch the application
	And I enter the following details
		| Email               | Password |
		| demod5429@gmail.com | asd      |
	And I click login button
	Then I should see dashboard of Fundoo Notes Application

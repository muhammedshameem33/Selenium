Feature: RegisterFeature
	Register Account for Fundoo Notes Application

@smoke
Scenario: Perform Registration of Fundoo Notes Application
	Given I launch the Fundoo application
	And I enter following details
		| FirstName | LastName | Email          | Password | ConfirmPassword |
		| test      | test     | test@test1.com | test     | test            |
	And I click Register button
	Then I should see Login Page of Fundoo Notes Application

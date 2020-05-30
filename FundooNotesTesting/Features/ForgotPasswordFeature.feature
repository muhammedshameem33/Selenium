Feature: ForgotPasswordFeature
	Forgot Password feature in Fundoo Application

@smoke
Scenario: Perform Login of Fundoo Notes Application
	Given I launch the Fundoo Notes application
	And I enter email as 'demod5429@gmail.com'
	And I click continue button
	Then I should be navigated to login page of Fundoo Notes Application

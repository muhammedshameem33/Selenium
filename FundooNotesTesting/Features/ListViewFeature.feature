Feature: ListViewFeature
	View the notes in list form in Fundoo Notes Application

@smoke
Scenario:1 Perform Login of Fundoo Notes Application
	Given I launch the application
	And I enter the following details
		| Email               | Password |
		| demod5429@gmail.com | asd      |
	And I click login button
	Then I should see dashboard of Fundoo Notes Application
Scenario:2 Perform the viewing of notes in list form in Fundoo Notes Application
	When I click on List view Icon 
	Then I should see the notes in list format
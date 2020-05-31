Feature: UpdateNoteFeature
	update the note from Fundoo Notes Application

@smoke
Scenario:1 Perform Login of Fundoo Notes Application
	Given I launch the application
	And I enter the following details
		| Email               | Password |
		| demod5429@gmail.com | asd      |
	And I click login button
	Then I should see dashboard of Fundoo Notes Application
Scenario:2 Perform the update Note in Fundoo Notes Application
	When I click first display Note
	And I enter title as 'testing update note'
	And I click close button
	Then I should see the note which I updated
Feature: AddNoteFeature
	Add Note to Fundoo Notes Application

@smoke
Scenario:1 Perform Login of Fundoo Notes Application
	Given I launch the application
	And I enter the following details
		| Email               | Password |
		| demod5429@gmail.com | asd      |
	And I click login button
	Then I should see dashboard of Fundoo Notes Application
Scenario:2 Perform the adding of note to Fundoo Notes Application
	When I click on Take a note 
	And I enter the title as 'testing' and description as 'my description'
	And I click the close button
	Then I should see the note which I created
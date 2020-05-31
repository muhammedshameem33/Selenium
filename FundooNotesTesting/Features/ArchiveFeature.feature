Feature: ArchiveNoteFeature
	Archive a Note from Fundoo Notes Application

@smoke
Scenario:1 Perform Login of Fundoo Notes Application
	Given I launch the application
	And I enter the following details
		| Email               | Password |
		| demod5429@gmail.com | asd      |
	And I click login button
	Then I should see dashboard of Fundoo Notes Application
Scenario:2 Perform the Archiving of note from Fundoo Notes Application
	When I click the Archive Icon
	Then I shouldn't see the note which I Archived
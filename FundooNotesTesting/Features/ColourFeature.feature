Feature: ColorFeature
	Add Colour to the Note in Fundoo Notes Application

@smoke
Scenario:1 Perform Login of Fundoo Notes Application
	Given I launch the application
	And I enter the following details
		| Email               | Password |
		| demod5429@gmail.com | asd      |
	And I click login button
	Then I should see dashboard of Fundoo Notes Application
Scenario:2 Perform adding colour for the note in Fundoo Notes Application
	When I click color icon 
	And I selected the last color
	Then I should see the note with the new color
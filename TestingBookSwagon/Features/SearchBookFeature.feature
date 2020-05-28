Feature: SearchBookFeature
	Search for a book in Book Swagon Application

@smoke
Scenario: Perform Search for given keyword in Book Swagon Site and navigate to search result page
	Given I have launch the Book Swagon Application
	And I entered computer as search keyword
	When I press the search button
	Then I should be navigate to search result page

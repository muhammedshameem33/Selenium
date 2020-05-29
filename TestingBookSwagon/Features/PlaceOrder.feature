Feature: PlaceOrder

@smoke
Scenario: placing order of the book which is in the shopping cart of Book Swagon Site and navite to checkout page
	Given I launched the site
	And I clicked login 
	And I enterered the following details
		| Email               | Password |
		| demod5429@gmail.com | demodemo |
	And I clicked login buttn
	And I enter compter as search keyword
	When I clicked the search button
	Then I should be navigate to result page
	And I click the first book link
	And I clicked the Buy Now button
	And I click place order button
	Then I should see checkout Page

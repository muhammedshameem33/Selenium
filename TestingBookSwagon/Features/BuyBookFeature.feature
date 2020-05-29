Feature: BuyBookFeature

@smoke
Scenario: Buy a Book from Swagon Site and navigate to the shopping cart
	Given I launched the application
	And I clicked login link
	And I enterered following details
		| Email               | Password |
		| demod5429@gmail.com | demodemo |
	And I clicked login button 
	And I enter computer as search keyword
	When I click the search button
	Then I should be navigated to search result page
	And I click the first book
	And I click the Buy Now button
	Then I should see My Shopping Cart 
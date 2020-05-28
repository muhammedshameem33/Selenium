Feature: BuyBookFeature
	Buy a book from Book Swagon Application

@smoke
Scenario: Buy a Book from Swagon Site and navigate to the shopping cart
	Given I have launch Application
	And I clicked login link
	And I enter following details
		| Email               | Password |
		| demod5429@gmail.com | demodemo |
	And I clicked login button
	And I enter computer as search keyword
	When I click the search button
	Then I should be navigate to result page
	And I clicked the first book
	And I clicked the Buy Now button
	Then I should see My Shopping Cart page 

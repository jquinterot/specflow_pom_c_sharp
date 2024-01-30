Feature: Order Management

Scenario: Check that a samsung cellphone can be added
	Given the user visits Demoblaze page
	When selects 'Phone' category
	And selects 'Nexus 6' product
	Then 'Nexus 6' is displayed in product summary page
	When  adds the product to the cart
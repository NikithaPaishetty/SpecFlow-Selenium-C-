Feature: SaucedemoLogin

Background: 
Given : User Should Launch Valid URL
	When : User Should Enter Valid Login Details
	| Username      | Password     |
	| standard_user | secret_sauce |
	And : User Click on Login Button

Scenario: Login Through Valid Details
	Then : User Able to See HomePage

Scenario: Ordering An Iteam from the site
 When : User able to see Homepage and Clicks on Add to cart button
 When : User Clicks on Cart Icon and User able to see Cart Page
 And : User Clicks on Checkout button and User able to see Checkout Page
 When : User enter the vaild information in the page
 | FirstName | LastName | ZipCode |
 | Princess  | Cutie    | 223301  |
 Then : User Click on Finish button and Places an order

 Scenario: Ordering an iteam from Low To High Price
 When : User should be able to see HomePage and Click on Filter Icon
 And : User click on Price(Low To High) One
 When : User Select the Particular Iteam or Iteams they need by clicking on Add to cart button
 When : User click on CartIcon
 And : User Clicks on Checkout button
  When : User enter the vaild information in the page
 | FirstName | LastName | ZipCode |
 |   | Cutie    | 223301  |
 Then : User click on Finish button and Order is Placed.

 Scenario: Removing An Iteam From The List
  When : User able to see Homepage and Clicks on Add to cart button
 When : User Clicks on Cart Icon and User able to see Cart Page
 And : User Removes an Iteam from the list
  And : User Clicks on Checkout button and User able to see Checkout Page
 When : User enter the vaild information in the page
 | FirstName | LastName | ZipCode |
 | Princess  | Cutie    | 223301  |
 Then : User Click on Finish button and Places an order

 Scenario: Cancel An Order
  When : Customer able to see homepage and clicks on Add to Cart Button
 When :  Customer Clicks On Cart Icon and They able to see Cart page
 And :  Customer Clicks on Checkout Button and able to see Checkout Page
 When : User enter the information in the page
 | FirstName | LastName | ZipCode |
 | Admin     | Password | 60063   |
 Then : User Clicks On Cancel Button

 Scenario: End-To-End Testing
 When : User able to see Homepage and Clicks on Add to cart button
 When : User Clicks on Cart Icon and User able to see Cart Page
 And : User Clicks on Checkout button and User able to see Checkout Page
 When : User enter the vaild information in the page
 | FirstName | LastName | ZipCode |
 | Princess  | Cutie    | 223301  |
 When : User Click on Finish button and Places an order
 When : User Clicks on Back-to-Home button
 And : User able to see Homepage and Clicks on Menu button
 Then : User Clicks on Logout button and able to see Loginpage. 




	
	
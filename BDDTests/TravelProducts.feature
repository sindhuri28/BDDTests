Feature: GoogleSearch

@mytag
Scenario: Travel Products
	Given I have navigated to CommbankPage 
	And I have clicked travel Products
	And I click Discover more 
	Then I can see "Features & benifits"
	#And I click Netbank Login
	#Then I see Usename and Password fields are present

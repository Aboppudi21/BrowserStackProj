Feature: OpenAudenSite

@mytag
Scenario Outline: Can Launch AudenSite
  Given I am on the Auden Home Page for <profile> and <environment>
  When I Click On Login
  Then I should see LoginPage
  
  Examples:
    | profile | environment |
	| parallel    | chrome      |
    #| parallel    | firefox     |
    #| parallel    | safari      |
    #| parallel    | ie          |

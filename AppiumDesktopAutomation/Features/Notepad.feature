Feature: Notepad
	

Scenario Outline: Write some text on notepad
	Given I have opened the notepad
	And I type the text "<text>"
	When I press File and Save
	Then should to show the Save Dialog window 

	Examples:
	| text								 |
	| Automation Windows Test with Appium|

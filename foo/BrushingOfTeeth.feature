Feature: Brushing Of Teeth


Scenario: Successfull brushing
	#text in purple means no step definition binded
	#when hooked up the text turns black
	Given there is 1 gram of toothpaste of Brand X on the brush
		And the mouth is open
	When the back teeth are  brushed
		And the front teeth are brushed
	Then the teeth look clean
		And the mouth feels fresh
		But the braces aren't damaged

Scenario: Successfull brushing 2
	Given there is 2 gram of toothpaste on the brush
		And the mouth is open
	When the back teeth are  brushed
		And the front teeth are brushed
	Then the teeth look clean
		And the mouth feels fresh
		But the braces aren't damaged

Scenario: Successfull brushing 3
	Given I have the following tools:
	|ToolName|ToolQUality|
	|paste|medium|
	|brush|high|
	|water|low|
		And the mouth is open
	When the back teeth are  brushed
	Then the teeth look clean
		And the mouth feels fresh
		But the braces aren't damaged
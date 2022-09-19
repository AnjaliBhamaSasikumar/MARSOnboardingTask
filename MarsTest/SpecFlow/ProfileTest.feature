Feature: Project

As a Seller
I want the following description, language and skill features to 
add,edit and delete to my Profile Details
So that
The people seeking for some skills can look into my details.

Acceptance Criteria
Seller is able to add the Profile Details
Seller is able to see the seller’s details on the Profile page


Background: 
  Given I successfully SignIn to the Website
   And I navigate to Profile page

@AddDescription
Scenario: Testcase_1 Add description to the profile
  When I create description details to the profile
  Then I am able to see my Description details in the profile page

@AddLanguages
Scenario Outline: Testcase_2 Add langauge details
   When I add Language including '<Language>' and '<Level>'
   Then I am able to see Language details including '<Language>' and '<Level>'   
Examples: 
| Language  | Level            | 
| Malayalam | Native/Bilingual |   
| English   | Fluent           |   
| Tamil     | Conversational   |   
| Hindi     | Basic            | 

@EditLanguages
Scenario Outline: Testcase_3 Edit language details
  When I edit language including'<Language>' and '<Level>'
  Then I am able to see edited language details including '<Language>' and '<Level>'
  Examples: 
  | Language     | Level            |
  | Urdu         | Fluent           |
  #| Spanish      | Native/Bilingual |
  #| Kannada      | Basic            |
  #| Hindi        | Conversational   |

  @DeleteLanguages
Scenario: Testcase_4 Delete existing languages
   When I navigate to Language tab and delete language
   Then I am able to delete languages details from the profile page

@AddSkills
Scenario Outline: Testcase_5 Add Skills to the profile
  When I add skill details including '<skill>' and '<level>' to the profile
  Then I am able to see skill details including '<skill>' and '<level>' 
	Examples: 
	| skill                | level            |
	| Selenium             | Beginner         |
	| Matlab               | Intermediate     |
	| Microsoft office     | Expert           |
	| VHDL                 | Intermediate     |

@EditSkills
Scenario Outline: Testcase_6 Edit skill details
  When I edit skill details including '<skill>' and '<level>' to the profile
  Then I am ble to see edited skill details including '<skill>' and '<level>'
Examples: 
    | skill                | level            |
	#| Selenium             | Intermediate     |
	| Simulink             | Intermediate     |
	#| Microsoft word       | Expert           |
	#| Verilog              | Beginner         |

@DeleteSkills
Scenario: Testcase_7 Delete existing skills
  When I navigate to skill tab and delete skill details
  Then I am able to delete skill details from the profile page
    

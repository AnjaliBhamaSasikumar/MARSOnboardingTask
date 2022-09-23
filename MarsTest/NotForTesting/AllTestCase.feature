#Feature: AllTestCase
#As a Seller
#I want the feature to add my Profile Details
#So that
#The people seeking for some skills can look into my details.
#
#Acceptance Criteria
#Seller is able to add the Profile Details
#Seller is able to see the seller’s details on the Profile page
#
#@AddDescription
#Scenario: Testcase_1 Add description to the profile
#    Given  I successfully SignIn to the Website
#	When I navigate to Profile page
#	When I add Description details to the profile
#	Then The record should add Description details to the profile page
#
#Scenario: Testcase_1.1 Verify validate error for description detail
#    Given I successfully SignIn to the Website
#	When  I navigate to profile page
#	When I left description text box empty and click save button
#	Then "Please,a description is required" message should popup
#
#@AddLanguages
#Scenario Outline: Testcase_2 Add langauge details
#   Given I successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I add language details including '<Language>' and '<Level>'
#   Then Language detaoils including '<Language>' and '<Level>' should be created  
#Examples: 
#| Language  | Level            | 
#| Malayalam | Native/Bilingual |   
#| English   | Fluent           |   
#| Tamil     | Conversational   |   
#| Hindi     | Basic            |   
#
#Scenario: Testcase_2.1 Add one language to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I add one Language detail to the profile
#   Then New language records ncluding language and skill should be created
#   
#Scenario Outline: Testcase_2.2 Add two languages to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I add two  Language details '<Language>' and '<Level>" to the profile
#   Then '<Language>' and '<Level>' language details should be added to the profile
#   Examples: 
#   | Language  | Level            |
#   | Malayalam | Native/Bilingual |
#   | English   | Fluent           |
#
#Scenario Outline: Testcase_2.3 Add three languages to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I add three Language details '<Language>' and '<Level>" to the profile
#   Then '<Language>' and '<Level>' language details should be added to the profile
#   Examples: 
#   | Language  | Level            |
#   | Malayalam | Native/Bilingual |
#   | English   | Fluent           |
#   | Tamil     | Conversational   |
#
#Scenario: Testcase_2.4 Cancel adding language details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter language text, did not select language skill and click cancel button
#  Then Langauge add option should get cancelled
#
#Scenario: Testcase_2.5 Verify validation error for langauge detail
#  Given I Successfully SignIn to the Website
#  When I navigate to Profile page
#  When I left Language textbox blank and click add language button
#  Then "Please enter language and level" message pop up should display
#
#Scenario: Testcase_2.6 Verify validation error for already existing language
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter already existing language and level details
#  Then Error message should popup "This language is already exist in your laguage list"
#
#Scenario: Testcase_2.7 Verify validation error for already existing language
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter already existing language but change the level
#  Then "Duplicated data" Message should popup 
#
#
#@EditLanguages
#Scenario Outline: Testcase_3 Edit language details
# Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I edit language including '<Language>' and '<Level>'
#  Then The record should update '<Language>' and '<Level>' details
#  Examples: 
#  | Language     | Level            |
#  | Malayalam    | Fluent           |
#  | English      | Native/Bilingual |
#  | Kannada      | Basic            |
#  | Hindi        | Conversational   |
#
#  Scenario: Testcase_3.1 Cancel editing language details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter language text and click cancel button
#  Then Langauge edit option should be cancelled
#
#Scenario: Testcase_3.2 Verify error while updating the existing langauage data
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When Click edit button and click update button without changing the data
#  Then "This language is already added to your language list" message should popup
#
#@DeleteLanguages
#Scenario: Testcase_4 Delete existing languages
#   Given I successfully SignIn to the Website
#   When I navigate to Profile page
#   When I navigate to Language tab and delete language
#   Then Language details should be deleted from the profile
#
#@AddSkills
#Scenario Outline: Testcase_5 Add Skills to the profile
#   Given  I successfully SignIn to the Website
#	When I navigate to Profile page
#	When I create skill details '<skill>' and '<level>' to the profile
#	Then The record '<skill>' and '<level>' should add to the profile page
#	Examples: 
#	| skill                | level            |
#	| Selenium             | Beginner         |
#	| Matlab               | Intermediate     |
#	| Microsoft office     | Expert           |
#	| VHDL                 | Intermediate     |
#
#Scenario Outline: Testcase_6 Edit skill details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I edit '<skill>' and '<level>' to the profile
#  Then '<skill>' and '<level>' should be updated
#Examples: 
#    | skill                | level            |
#	| Selenium             | Intermediate     |
#	| Simulink             | Intermediate     |
#	| Microsoft word       | Expert           |
#	| Verilog              | Beginner         |
#
#Scenario: Testcase_7 Delete existing skills
# Given I successfully SignIn to the Website
# When I navigate to Profile page
# When I navigate to skill tab and delete skill
# Then skill details should be deleted
#
#
#
#
#
#
#
#	
#
#
#@Deleteexistinglanguage
#Scenario: Testcase_4 Delete existing language
# Given I successfully SignIn to the Website
# When I navigate to Profile page
# When I navigate to Language tab and delete language
# Then Language details should be deleted
#
#@AddSkills
#Scenario Outline: Testcase_5 Add Skills to the profile
#   Given  I successfully SignIn to the Website
#	When I navigate to Profile page
#	When I create skill details '<skill>' and '<level>' to the profile
#	Then The record '<skill>' and '<level>' should add to the profile page
#	Examples: 
#	| skill                | level            |
#	| Selenium             | Beginner         |
#	| Matlab               | Intermediate     |
#	| Microsoft office     | Expert           |
#	| VHDL                 | Intermediate     |
#
#Scenario: Testcase_5.1 Add one skill to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I create skill detail to the profile
#   Then New skill record should be created
#   
#Scenario Outline: Testcase_5.2 Add two skills to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I create skill details '<skill>' and '<level>" to the profile
#   Then '<skill>' and '<level>' should be added to the profile
#   Examples: 
#   | skill                | level            |
#	| Selenium             | Beginner         |
#	| Matlab               | Intermediate     |
#
#Scenario Outline: Testcase_5.3 Add three skills to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I create skill details '<skill>' and '<level>" to the profile
#   Then '<skill>' and '<level>' should be added to the profile
#   Examples: 
#   | skill                | level            |
#	| Selenium             | Beginner         |
#	| Matlab               | Intermediate     |
#	| Microsoft office     | Expert           |
#
#Scenario: Testcase_5.4 Cancel adding skill details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter skill text and click cancel button
#  Then skill add option should be cancelled
#
#Scenario: Testcase_5.5 verify error for skill detail
#  Given I Successfully SignIn to the Website
#  When I navigate to Profile page
#  When I leave skill textbox blank 
#  Then "Please enter skill and level" pop up should display
#
#Scenario: Testcase_5.6 Verify error for already existing skill
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter already existing skill and level details
#  Then Error message should popup "This skill is already exist in your laguage list"
#
#Scenario: Testcase_5.7 Verify error for already existing skill
#Given I successfully SignIn to the Website
#When I navigate to Profile page
#When I enter already existing skill but change the level
#Then "Duplicated data" Message should popup 
#
# @EditSkills
#Scenario Outline: Testcase_6 Edit skill details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I navigate to Skill Tab
#  When I edit '<skill>' and '<level>'
#  Then '<skill>' and '<level>' should be updated
#Examples: 
#   | skill                | level            |
#	| Selenium             | Intermediate     |
#	| Simulink             | Intermediate     |
#	| Microsoft word       | Expert           |
#	| Verilog              | Beginner         |
#
#Scenario: Testcase_6.1 Cancel editing skill details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter skill text and click cancel button
#  Then skill edit option should be cancelled
#
#Scenario: Testcase_6.2 Verify error while updating the existing skill data
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When Click edit button and click update button without changing the data
#  Then "This skill is already added to your language list" message should popup
#
#@Deleteexistingskill
#Scenario: Testcase_7 Delete existing language
# Given I successfully SignIn to the Website
# When I navigate to Profile page
# When I navigate to skill tab and delete skill
# Then skill details should be deleted
#
#@AddEducation
#Scenario Outline: Testcase_8 Add Education to the profile
#   Given  I successfully SignIn to the Website
#	When I navigate to Profile page
#	When I create education details '<College>', '<Country>', '<Title>', '<Degree>' and '<Year>' to the profile
#	Then The record '<College>', '<Country>', '<Title>', '<Degree>' and '<Year>' should add to the profile page
#	Examples: 
#	| College                      | Country    | Title     | Degree             | Year |
#   | Amrita School of Engineering | Denmark    | M.Tech    | Power Elecctronics | 2012 |
#   | LBSITW                       | Bangladesh | B.Tech    | Instrumentation    | 2006 |
#   | NSS College                  | India      | PHD       | Electronics        | 2020 |
#   | Industry Connect             | Australia  | Associate | Testing            | 2021 |
#
#Scenario: Testcase_8.1 Add one education details to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I create education detail to the profile
#   Then New education record should be created
#   
#Scenario Outline: Testcase_8.2 Add two education details to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I create skill details '<College>', '<Country>', '<Title>', '<Degree>' and '<Year>' to the profile
#   Then '<College>', '<Country>', '<Title>', '<Degree>' and '<Year>' should be added to the profile
#   Examples: 
#   Examples: 
#	| College                      | Country    | Title     | Degree             | Year |
#   | Amrita School of Engineering | Denmark    | M.Tech    | Power Elecctronics | 2012 |
#   | LBSITW                       | Bangladesh | B.Tech    | Instrumentation    | 2005 |
#
#Scenario Outline: Testcase_8.3 Add three skills to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I create education details '<College>', '<Country>', '<Title>', '<Degree>' and '<Year>' to the profile
#   Then '<College>', '<Country>', '<Title>', '<Degree>' and '<Year>' should be added to the profile
#   Examples: 
#   | College                      | Country    | Title     | Degree             | Year |
#   | Amrita School of Engineering | Denmark    | M.Tech    | Power Elecctronics | 2012 |
#   | LBSITW                       | Bangladesh | B.Tech    | Instrumentation    | 2006 |
#   | NSS College                  | India      | PHD       | Electronics        | 2020 |
#
#Scenario: Testcase_8.4 Cancel adding education details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter College/University Name text and click cancel button
#  Then education add option should be cancelled
#
#Scenario: Testcase_8.5 verify error for education detail
#  Given I Successfully SignIn to the Website
#  When I navigate to Profile page
#  When I leave Degree text box blank 
#  Then "Please enter all the fields" pop up should display
#
#Scenario: Testcase_8.6 Verify error for already existing education 
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter already existing education details
#  Then Error message should popup "This information is already exist"
#
# @EditEducation
#Scenario Outline: Testcase_9 Edit education details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I navigate to Education Tab
#  When I edit '<College>', '<Country>', '<Title>', '<Degree>' and '<Year>'
#  Then '<College>', '<Country>', '<Title>', '<Degree>' and '<Year>' should be updated
#Examples: 
#   | College                      | Country      | Title     | Degree             | Year |
#   | Amrita School of Engineering | India        | M.Tech    | Power Elecctronics | 2012 |
#   | LBSITW                       | India        | B.Tech    | Instrumentation    | 2005 |
#   | UWA                          | Australia    | PHD       | Electronics        | 2020 |
#   | MVP Studio                   | New Zealand  | Associate | Test Analyst       | 2021 |  
#
#Scenario: Testcase_9.1 Cancel editing education details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I select Year of Graduation and click cancel button
#  Then education edit option should be cancelled
#
#Scenario: Testcase_9.2 Verify error while updating the existing skill data
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When Click edit button and click update button without changing the data
#  Then "This skill is already added to your language list" message should popup
#
#@DeleteexistingEducation
#Scenario: Testcase_10 Delete existing education
# Given I successfully SignIn to the Website
# When I navigate to Profile page
# When I navigate to education tab and delete education
# Then education details should be deleted
# 
# @AddCertifications
#Scenario Outline: Testcase_11 Add Certifications to the profile
#   Given  I successfully SignIn to the Website
#	When I navigate to Profile page
#	When I create certification details '<Certification>', '<Certified>' and '<Year>' to the profile
#	Then The record '<Certification>', '<Certified>' and '<Year>' should add to the profile 
#	Examples: 
#	| Certification  | Certified   | Year |
#	| certification1 | Microsoft   | 2005 |
#   | certification2 | Adobe       | 2010 |
#   | certification3 | Springboard | 2015 |
#   | certification4 | CIW         | 2020 |
#
#Scenario: Testcase_11.1 Add one certification to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I create certification detail to the profile
#   Then New certification record should be created
#   
#Scenario Outline: Testcase_11.2 Add two certifications to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I create certification details '<Certification>', '<Certified>' and '<Year>' to the profile
#   Then ''<Certification>', '<Certified>' and '<Year>' should be added to the profile
#   Examples: 
#   | Certification  | Certified   | Year |
#	| certification1 | Microsoft   | 2005 |
#   | certification2 | Adobe       | 2010 |
#
#Scenario Outline: Testcase_11.3 Add three certifications to the profile
#   Given I Successfully SignIn to the Website
#   When I navigate to Profile page 
#   When I create certification details '<Certification>', '<Certified>' and '<Year>' to the profile
#   Then '<Certification>', '<Certified>' and '<Year>' should be added to the profile
#   Examples: 
#   | Certification  | Certified   | Year |
#	| certification1 | Microsoft   | 2005 |
#   | certification2 | Adobe       | 2010 |
#   | certification3 | Springboard | 2015 |
#
#Scenario: Testcase_11.4 Cancel adding skill details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter Certification text and click cancel button
#  Then certification add option should be cancelled
#
#Scenario: Testcase_11.5 verify error for skill detail
#  Given I Successfully SignIn to the Website
#  When I navigate to Profile page
#  When I leave certification textbox blank 
#  Then "Please enter Certification Name, Certification From and Certification Year" pop up should display
#
#Scenario: Testcase_11.6 Verify error for already existing skill
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter already existing certification details
#  Then Error message should popup "This information is already exist"
#
#Scenario: Testcase_11.7 Verify error for already existing skill
#Given I successfully SignIn to the Website
#When I navigate to Profile page
#When I enter already existing certification but change the year
#Then "Duplicated data" Message should popup 
#
# @EditSkills
#Scenario Outline: Testcase_12 Edit certification details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I navigate to Skill Tab
#  When I edit '<Certification>', '<Certified>' and '<Year>'
#  Then '<Certification>', '<Certified>' and '<Year>' should be updated
#Examples: 
#   | Certification  | Certified   | Year |
#	| certification5 | Microsoft   | 2005 |
#   | certification2 | Tafe        | 2010 |
#   | certification3 | Springboard | 2017 |
#   | certification4 | IEEE        | 2020 |
#
#Scenario: Testcase_12.1 Cancel editing certification details
#  Given I successfully SignIn to the Website
#  When I navigate to Profile page
#  When I enter certification text and click cancel button
#  Then certification edit option should be cancelled
#
#@Deleteexistingskill
#Scenario: Testcase_13 Delete existing certification
# Given I successfully SignIn to the Website
# When I navigate to Profile page
# When I navigate to certification tab and delete certifications
# Then certification details should be deleted
#

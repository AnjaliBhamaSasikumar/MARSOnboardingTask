Feature: OnBoardingProjectMars
As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

Acceptance Criteria
●	Seller is able to add the Profile Details.
●	Seller is able to see the seller’s details on the Profile page. 


@AddDescription
Scenario: Testcase_1 Add description to the profile
	Given I successfully SignIn to the Website
	And I navigate to Profile page
	When I create description details to the profile
	Then Description should added in the profile page successfully
#@AddLanguage
#	Scenario: Testcase_2 Add language to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to language tab in the profile
#	And I create language details to the profile
#	Then Language details should be added in the profile page successfully
#@AddSkills
#	Scenario: Testcase_3 Add skills to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to skills tab in the profile
#	And I create Skills details to the profile
#	Then Skills details should be added in the profile page successfully
#@AddEducation
#	Scenario: Testcase_4 Add skills to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to skills tab in the profile
#	And I create Skills details to the profile
#	Then Skills details should be added in the profile page successfully
#	@AddCertification
#	Scenario: Testcase_5 Add skills to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to skills tab in the profile
#	And I create Skills details to the profile
#	Then Skills details should be added in the profile page successfully
#	@EditLanguage
#	Scenario: Testcase_6 Add skills to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to skills tab in the profile
#	And I create Skills details to the profile
#	Then Skills details should be added in the profile page successfully
#	@DeleteLanguage
#	Scenario: Testcase_7 Add skills to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to skills tab in the profile
#	And I create Skills details to the profile
#	Then Skills details should be added in the profile page successfully
#	@EditSkills
#	Scenario: Testcase_8 Add skills to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to skills tab in the profile
#	And I create Skills details to the profile
#	Then Skills details should be added in the profile page successfully
#	@DeleteSkills
#	Scenario: Testcase_9 Add skills to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to skills tab in the profile
#	And I create Skills details to the profile
#	Then Skills details should be added in the profile page successfully
#	@EditEducation
#	Scenario: Testcase_10 Add skills to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to skills tab in the profile
#	And I create Skills details to the profile
#	Then Skills details should be added in the profile page successfully
#	@DeleteEducation
#	Scenario: Testcase_11 Add skills to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to skills tab in the profile
#	And I create Skills details to the profile
#	Then Skills details should be added in the profile page successfully
#	@EditCertification
#	Scenario: Testcase_12 Add skills to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to skills tab in the profile
#	And I create Skills details to the profile
#	Then Skills details should be added in the profile page successfully
#	@Deletecertification
#	Scenario: Testcase_13 Add skills to the profile
#	Given I successfully SignIn to the Website
#	When I navigate to skills tab in the profile
#	And I create Skills details to the profile
#	Then Skills details should be added in the profile page successfully
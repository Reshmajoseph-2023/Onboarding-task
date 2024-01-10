Feature: SkillFeature

As a user I would be able to show what skills I know.
So that the people seeking for skills can look at what details I hold.

@DELETE_EXISTING_RECORDS
 Scenario: 01 - Delete existing records
	      Given User is logged into ProjectMars and navigate to skills tab successfully
	      When User deletes the existing records
	      Then skill records deleted successfully

@ADD_SKILLS
Scenario: 02 - Add Skill record with valid details
	      Given User is logged into ProjectMars and navigate to skills tab successfully
	      When Adding new '<Skill>' and '<Level>' to the skill list 
	      Then New skill record with '<Skill>' and '<Level>' are added successfully 

	     Examples:   
	     | Skill                                                                        | Level              |
	     | Java                                                                         | Expert             |
	     | Python                                                                       | Choose Skill Level |
	     | @!23Php@                                                                     | Intermediate       |
	     |                                                                              | Choose Skill Level |
	     |                                                                              | Beginner           |
		 | Java                                                                         | Beginner           |
	     | Destructive software testing is a type of software testing which attempts to cause a piece of software to fail in an uncontrolled manner, in order to test its robustness and to help establish range limits, within which the software will operate in a stable and reliable manner. |  Beginner           |
	     

@UPDATE_SKILLS
Scenario: 03-  Update existing Skill records with valid details
		Given User is logged into ProjectMars and navigate to skills tab successfully
		When Update '<Skill>' and '<Level>' on an existing skill record.
		Then The skill record should been updated '<Skill>' and '<Level>' Successfully

		Examples: 
		| Skill         | Level          |
		| Java          | Expert         |
		| PHP           | Beginner       |
		| C#!@#4        | Intermediate   |
		|               | Skill Level    |
		| OOPS          | Skill Level    |


@DELETE_SKILL
Scenario: 04 - Delete the Skill from the skill lists
		Given User is logged into ProjectMars and navigate to skills tab successfully
		When User Delete the record '<Skill>' 
		Then The record '<Skill>' should deleted successfully

		Examples:
		| Skill      | Level		    |
		| C#!@#4     |  Intermediate    |

@CANCEL_SKILL
 Scenario: 05 - Cancel the skill when a recod is Update
       Given User is logged into ProjectMars and navigate to skills tab successfully
	   When click Cancel button when update skill
	   Then User was able to click cancel button successfully
	
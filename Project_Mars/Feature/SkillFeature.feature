Feature: SkillFeature

As a user I would be able to show what skills I know.
So that the people seeking for skills can look at what details I hold.

@DELETE_EXISTING_RECORDS
 Scenario: 01 - Delete existing records
	      Given User is logged into ProjectMars and navigate to skills tab successfully
	      When User deletes the existing records
	      Then skill records deleted successfully

@ADD_SKILLS_VALID
Scenario: 02 - Add Skill record with valid details
	      Given User is logged into ProjectMars and navigate to skills tab successfully
	      When Adding new '<Skill>' and '<Level>' to the skill list 
	      Then New skill record with '<Skill>' and '<Level>' are added successfully 

	     Examples:   
	     | Skill                                                                        | Level              |
	     | Java                                                                         | Expert             |
	     | Python                                                                       | Choose Skill Level |
	  	 |                                                                              | Choose Skill Level |
	     |                                                                              | Beginner           |
		 | Java                                                                         | Beginner           |
	     

@ADD_SKILLS_INVALID
Scenario: 03 - Add Skill record with invalid details
	      Given User is logged into ProjectMars and navigate to skills tab successfully
	      When Adding new '<Skill>' and '<Level>' to the skill list      
		  Then The message '<Message>' should be displayed while adding invalid details

		   Examples:  
         | Skill                                                                                                                                                                                                                                                                                | Level            | Message                                           |
         | @!23Php@                                                                                                                                                                                                                                                                             | Beginner         | Special characters are not allowed                |
         | Destructive software testing is a type of software testing which attempts to cause a piece of software to fail in an uncontrolled manner, in order to test its robustness and to help establish range limits, within which the software will operate in a stable and reliable manner | Intermediate     | The limit for the language field is 30 characters |


@UPDATE_SKILLS
Scenario: 04-  Update existing Skill record 
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
Scenario: 05 - Delete the Skill from the skill lists
		Given User is logged into ProjectMars and navigate to skills tab successfully
		When User Delete the record '<Skill>' 
		Then The record '<Skill>' should deleted successfully

		Examples:
		| Skill      | Level		    |
		| Java       | Expert           |

@CANCEL_SKILL
 Scenario: 06 - Cancel the skill when a recod is Update
       Given User is logged into ProjectMars and navigate to skills tab successfully
	   When click Cancel button when update skill
	   Then User was able to click cancel button successfully
	
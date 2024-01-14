Feature: LanguageFeature

As a user I would be able to show what languages I know.
So that the people seeking for languages can look at what details I hold.

 @DELETE_EXISTING_RECORDS
 Scenario: 01 - Delete existing records
	      Given User is logged into Project Mars and Navigate to language tab successfully
	      When User deletes existing records
	      Then language records deleted successfully
    
 @ADD_LANGUAGES_VALID
 Scenario: 02 - Add language record with valid details
	     Given User is logged into Project Mars and Navigate to language tab successfully
	     When Adding new '<Language>' and '<Level>' to the language list
	     Then New record with '<Language>' and '<Level>' are added successfully

	      Examples:  
	      | Language         | Level             |
	      | Urudu            | Basic             |
	      
		  
@ADD_LANGUAGES_INVALID
 Scenario: 03 - Add language record with invalid details
	     Given User is logged into Project Mars and Navigate to language tab successfully
	     When Adding new '<Language>' and '<Level>' to the language list
		 Then The message '<Message>' should be displayed

         Examples:  
         | Language                                                                                                                                                                                                                                                                             | Level                 | Message                                               |
         | Tamil                                                                                                                                                                                                                                                                                | Choose Language Level | Please enter language and level                       |
         |                                                                                                                                                                                                                                                                                      | Fluent                | Please enter language and level                       |
         |                                                                                                                                                                                                                                                                                      | Choose Language Level | Please enter language and level                       |
         | Urudu                                                                                                                                                                                                                                                                                | Fluent                | Duplicated data                                       |
         | Urudu                                                                                                                                                                                                                                                                                | Basic                 | This language is already exist in your language list. |
		 | @Malayalam#$%                                                                                                                                                                                                                                                                        | Conversational        | Special characters are not allowed                    |
		 | Malayalam1234                                                                                                                                                                                                                                                                        | Conversational        | Numbers are not allowed                               |
         | Destructive software testing is a type of software testing which attempts to cause a piece of software to fail in an uncontrolled manner, in order to test its robustness and to help establish range limits, within which the software will operate in a stable and reliable manner | Native/Bilingual      | The limit for the language field is 100 characters    |

@UPDATE_LANGUAGES
Scenario: 04 - Update existing language record with valid details
	   Given User is logged into Project Mars and Navigate to language tab successfully
	   When Update '<Language>' and '<Level>' on an existing language record
	   Then The record should been updated '<Language>' and '<Level>' successfully

	   Examples: 
	   | Language     | Level				|
	   | Hindi	      | Fluent			    |
	   | Kannada      | Native/Bilingual	|
	   
	
@DELETE_LANGUAGE
Scenario: 05 - Delete an existing language
       Given User is logged into Project Mars and Navigate to language tab successfully
	   When User delete the '<Language>' 
	   Then the record '<Language>' should be deleted successfully

       Examples:  
       | Language    | Level             |
       | Kannada     | Native/Bilingual  |

 @CANCEL_LANGUAGE
 Scenario: 06 - Cancel the language when a recod is Update
       Given User is logged into Project Mars and Navigate to language tab successfully
	   When click Cancel button
	   Then User clicked cancelled successfully
	
	
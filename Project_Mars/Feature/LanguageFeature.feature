Feature: LanguageFeature

As a user I would be able to show what languages I know.
So that the people seeking for languages can look at what details I hold.

 @DELETE_EXISTING_RECORDS
 Scenario: 01 - Delete existing records
	      Given User is logged into Project Mars and Navigate to language tab successfully
	      When User deletes existing records
	      Then language records deleted successfully
    
 @ADD_LANGUAGES
 Scenario: 02 - Add language record with valid details
	     Given User is logged into Project Mars and Navigate to language tab successfully
	     When Adding new '<Language>' and '<Level>' to the language list
	     Then New record with '<Language>' and '<Level>' are added successfully

	      Examples:  
	      | Language                                                                       | Level                 |
	      | Urudu                                                                          | Basic                 |
	      | Tamil                                                                          | Choose Language Level |
	      | @Malayalam#$%                                                                  | Conversational        |
	      |                                                                                | Fluent                |
	      |                                                                                | Choose Language Level |
	      | Urudu                                                                          | Fluent                |
	      | Urudu1234567890!@#$%^&*()lkilllopqwertyuABCabcdefghjikolopiuytreqwe1234567890  | Native/Bilingual      |

@UPDATE_LANGUAGES
Scenario: 03 - Update existing language record with valid details
	   Given User is logged into Project Mars and Navigate to language tab successfully
	   When Update '<Language>' and '<Level>' on an existing language record
	   Then The record should been updated '<Language>' and '<Level>' successfully

	   Examples: 
	   | Language     | Level				|
	   | Urudu        | Basic			    |
	   | Hindi	      | Fluent			    |
	   | @Malai)*&    | Native/Bilingual	|
	   |		      | Language Level		|
	   | French       | Language Level		|
	
@DELETE_LANGUAGE
Scenario: 04 - Delete an existing language
       Given User is logged into Project Mars and Navigate to language tab successfully
	   When User delete the '<Language>' 
	   Then the record '<Language>' should be deleted successfully

       Examples:  
       | Language    | Level             |
       | @Malai)*&   | Native/Bilingual  |

 @CANCEL_LANGUAGE
 Scenario: 05 - Cancel the language when a recod is Update
       Given User is logged into Project Mars and Navigate to language tab successfully
	   When click Cancel button
	   Then User clicked cancelled successfully
	
	
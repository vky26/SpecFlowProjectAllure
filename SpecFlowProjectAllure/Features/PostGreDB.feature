Feature: PostGreSQLDB
	Simple query to make connection and fetch a result

@db
Scenario: Fetch a value from db
	Given I made a connection to db
	Then I fetch a value from table
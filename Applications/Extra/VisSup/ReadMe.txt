This application is to be used in the support/bracelet managment booths.
It's main functionality is to manage the bracelets: assign, issue, deactivate and change the 
	bracelets for certain visitors.

It has two communication directions: 
	PC <-> MySql database
	PC <-> RFID reader

VISITOR INFO =========================================================

a) Visitor information used by this application is: 

	[ATTRIBUTES]
	EMAIL, FNAME, LNAME, SECCODE, BRACELET_ID, STATUS {indicating 
								whether he has 
								entered the event}

b) Visitor information is obtained by searching for a visitor via email/secret code input.
	
	SELECT [Attributes] FROM VISITORS WHERE {SEARCH_TYPE} = {SEARCH_VALUE}
  where 
	{SEARCH_TYPE} is EMAIL or SECCODE

c) Visitor information is to be managed in cases if the new RFID chip should be assigned, or 
	previous should be deactivated: 

	1) Deactivating: 
		
i:		First the RFID should be modified: 

		UPDATE RFIDS
		SET STATUS = DEACTIVATED
		WHERE BRACELET_ID = {BRACELET_ID}

ii:		Second, a new RFID bracelet should be chosen
		
		{NEW_BRACELET_ID}: =
		SELECT BRACELET_ID
		FROM RFIDS
		WHERE STATUS = STAND_BY
		LIMIT 1;

iii: 		Third, this new RFID should be set to ACTIVE

		UPDATE RFIDS
		SET STATUS = ACTIVE
		WHERE BRACELET_ID = {NEW_BRACELET_ID}

iv:		Fourth, visitor should get a new bracelet assigned

		UPDATE VISITORS
		SET BRACELET_ID = {NEW_BRACELET_ID}
		WHERE SECCODE = {VISITOR_SECCODE}

v:		Fifth, all the information in the form should be updated accoringly
		...

RFID INFO =========================================================

a) RFID information used by this application is: 
	
	BRACELET_ID, STATUS {STAND_BY/ACTIVE/DEACTIVATED}
	
b) RFID information is obtained from the database:

	1) SELECT * FROM RFIDS WHERE BRACELET_ID = {BRACELET_ID}, 
  where
	{BRACELET_ID} is either obtained from the visitor's information
			 or from the RFID reader.

FUNCTIONALITY CONSTRAINTS =========================================

In order to proceed with an update, a manager has to scan a new RFID
In order to proceed with anything, the information about both the visitor and the rfid 
	should be available
Logs (listboxes in the form) are to be used for storing the results of the procedures and 
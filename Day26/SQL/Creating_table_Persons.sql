
USE Test; --switch DB usage to the selected one
PRINT('Using the database Test');

--Creating a table called Persons with columns PersonID, LastName, FirstName, Age, Address, City
--PersonID, LastName, FirstName, Age MUST have values (OR it CAN'T be NULL)
--Address, City doesn't have to have a value (OR it CAN be NULL)
CREATE TABLE Persons (
	PersonID INT NOT NULL,
	LastName VARCHAR(255) NOT NULL,
	FirstName VARCHAR(255) NOT NULL,
	Age INT NOT NULL,
	Address VARCHAR(255),
	City VARCHAR(255)
);

--to delete Persons;
DROP TABLE Persons;

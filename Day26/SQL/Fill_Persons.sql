USE Test;

INSERT INTO Persons VALUES (1, 'Humming', 'Peter', 23, 'Main street 1 - 10', 'Riga');
INSERT INTO Persons VALUES (2, 'Trunko', 'Jelly', 7, 'Second street 1 - 20', 'Cesis');

INSERT INTO Persons(PersonID, LastName, FirstName, Age, Address) VALUES (3, 'Talkum', 'Ann', 56, 'Third street 7 - 20'); 

INSERT INTO Persons(PersonID, LastName, FirstName, Age) VALUES (4, 'Mousy', 'Bobby', 27); 

--THIS WILL NOT WORK. Age column is mandatory
INSERT INTO Persons(PersonID, LastName, FirstName) VALUES (5, 'Mousy', 'Bobby'); 

INSERT INTO Persons(PersonID, LastName, FirstName, Age) VALUES (6, 'Darktes', 'Ann', 12); 
INSERT INTO Persons(PersonID, LastName, FirstName, Age) VALUES (7, 'Numtes', 'George', 45); 
INSERT INTO Persons(PersonID, LastName, FirstName, Age) VALUES (8, 'Chair', 'Mudloc', 67); 
INSERT INTO Persons(PersonID, LastName, FirstName, Age) VALUES (9, 'Wonder', 'Alice', 8); 

CREATE DATABASE MondayDB;
USE MondayDB;

--USE MondayDB;
/*
USE MondayDB;
USE MondayDB;
*/

/*
CREATE TABLE TableName(
	column1 datatype,
	column2 datatype,
	column3 datatype,
	column4 datatype,
	column5 datatype,
); 
 */

 CREATE TABLE Tasks(
	TaskId INT NOT NULL,
	Description VARCHAR(100) NOT NULL,
	Priority INT NOT NULL,
	CreatedOn DATETIME,
	Creator VARCHAR(50),
	Done BIT
 );

--SELECT gets the data from table
SELECT TaskId, Description
FROM Tasks

SELECT TaskId, Description, Priority
FROM Tasks

INSERT INTO Tasks (TaskId, Description, Priority) VALUES (1, 'Finish creating the database', 5)
INSERT INTO Tasks (TaskId, Description, Priority) VALUES (2, 'Start working on Final project', 9)
INSERT INTO Tasks (TaskId, Description, Priority) VALUES (3, 'Finish all homework', 6)

INSERT INTO Tasks VALUES (4, 'Clean our room', 7, NULL, NULL, NULL)

INSERT INTO Tasks VALUES (5, 'Take out christmas tree', 3, CONVERT(DATETIME, '04.01.2021', 104), 'Mom', 0)

-- GETDATE - built-in function for getting current date
SELECT GETDATE()
INSERT INTO Tasks VALUES (6, 'Take out trash', 7, GETDATE(), 'Mom', 0)

INSERT INTO Tasks VALUES (7, 'feed fish', 10, GETDATE(), 'Dad', 1)
INSERT INTO Tasks VALUES (8, 'wash the dishes', 8, GETDATE(), 'Mom', 1)
INSERT INTO Tasks VALUES (9, 'get the newspaper', 5, GETDATE(), 'Dad', 1)
INSERT INTO Tasks VALUES (10, 'clean the mirror', 4, GETDATE(), 'Me', 0)
INSERT INTO Tasks VALUES (11, 'play with dolls', 10, GETDATE(), 'Sister', 0)
INSERT INTO Tasks VALUES (12, 'play with monster', 1, GETDATE(), 'Brother', 0)
INSERT INTO Tasks VALUES (13, 'DANCE....', 2, GETDATE(), 'Me', 0)
INSERT INTO Tasks VALUES (14, 'read more....', 2, GETDATE(), 'M', 0)


SELECT * FROM Tasks

SELECT TOP 5 * FROM TASKS

SELECT *
FROM Tasks
ORDER BY Priority ASC

SELECT *
FROM Tasks
ORDER BY Priority DESC, Description ASC

SELECT *
FROM Tasks
ORDER BY CreatedOn

SELECT TOP 5 Description
FROM Tasks
ORDER BY Priority DESC

---------------------------------------------------------
/*
SELECT column1, column2, ...
FROM tableName
WHERE condition
*/

SELECT * FROM Tasks WHERE TaskId = 5
SELECT TOP 1 * FROM Tasks WHERE TaskId = 5

SELECT * FROM Tasks WHERE Creator = 'Mom'

SELECT * 
FROM Tasks 
WHERE Priority > 5
ORDER BY Priority

SELECT * 
FROM Tasks 
WHERE Priority <= 4
ORDER BY Priority

-- <> is NOT EQUAL operator
SELECT * FROM Tasks WHERE Creator <> 'Mom'

SELECT * FROM Tasks WHERE Creator <> 'Mom' OR Priority > 7

SELECT * FROM Tasks WHERE Creator <> 'Mom' AND Done = 1

-- IN is an operator which helps to choose from multiple possible values for a column
SELECT * FROM Tasks WHERE Priority IN (5, 7, 10)
SELECT * FROM Tasks WHERE Priority = 5 OR Priority = 7 OR Priority = 10

SELECT * FROM Tasks WHERE Creator IN ('Mom', 'Me')

SELECT * FROM Tasks WHERE TaskId NOT IN (1,3,5,8,9)


SELECT * FROM Tasks WHERE Priority BETWEEN 8 AND 10

SELECT * FROM Tasks WHERE Priority NOT BETWEEN 3 AND 7



-- LIKE means that we are using a pattern
-- '%' used anywhere in a string to match a sequence of zero or more characters (works only with LIKE and NOT LIKE)
-- '_' used anywhere in a string to match a single character (works only with LIKE and NOT LIKE)
SELECT * FROM Tasks 
SELECT * FROM Tasks WHERE Creator LIKE 'M%' -- all tasks when creator starts with letter M
SELECT * FROM Tasks WHERE Creator LIKE 'M_' -- all tasks when creator starts with letter M and is continued with a single character

SELECT * FROM Tasks WHERE Description LIKE '%out%' -- all the tasks when description contains 'out'

SELECT * FROM Tasks WHERE Description LIKE '%sh' -- all the tasks when description ends with 'sh'

SELECT * FROM Tasks WHERE Creator LIKE 'M__' -- all tasks when creator starts with letter M and is continued with 2 characters
SELECT * FROM Tasks WHERE Creator LIKE 'M_%' -- all tasks when creator starts with letter M and is continued with a single character + anything

-- '%xxx' = ends with xxx
-- 'xxx%' = starts with xxx
-- '%xxx%' = contains xxx

SELECT * FROM Tasks WHERE Description LIKE '%sh_%' 
SELECT * FROM Tasks WHERE Description LIKE '%ish%' OR Description LIKE '%out%'

SELECT * FROM Tasks WHERE Description NOT LIKE '%out%'

--USE WITH CAUTION. to delete EVERYTHING from a table
DELETE FROM Tasks

DELETE FROM Tasks
WHERE TaskId = 8




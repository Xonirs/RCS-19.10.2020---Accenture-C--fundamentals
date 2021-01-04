--*submit all code parts in a single file
--1.1)Create a database ‘Cinema’ and a table called ‘Movies’
CREATE DATABASE Cinema
USE Cinema;
--1.2)Table has the following columns:
--MovieId 
--Title
--Director
--Year
--Genre
--LengthInMinutes
CREATE TABLE Movies (
	MovieId INT NOT NULL,
	Title VARCHAR(100),
	Director VARCHAR(60),
	Year INT,
	Genre VARCHAR(20),
	LengthInMinutes INT
);

--1.3)Fill the table with at least 10 records
INSERT INTO Movies VALUES (1, 'Harry Potter and the table', 'Director1', 1989, 'Adventure', 120);
INSERT INTO Movies VALUES (2, 'Santa claus', 'Director1', 2006, 'Adventure', 60);
INSERT INTO Movies VALUES (3, 'Title3', 'Director1', 2004, 'Adventure', 120);
INSERT INTO Movies VALUES (4, 'Title4', 'Steven Spielberg', 1994, 'Adventure', 150);
INSERT INTO Movies VALUES (5, 'Title5', 'Director1', 1989, 'Adventure', 120);
INSERT INTO Movies VALUES (6, 'proud dog', 'Director1', 1996, 'Adventure', 140);
INSERT INTO Movies VALUES (7, 'Title7', 'Steven Spielberg', 1989, 'Adventure', 110);
INSERT INTO Movies VALUES (8, 'Title8', 'Director1', 2002, 'Adventure', 90);
INSERT INTO Movies VALUES (9, 'peter pan', 'Director1', 2000, 'Adventure', 100);
INSERT INTO Movies VALUES (10, 'Title10', 'Steven Spielberg', 2011, 'Adventure', 130);

--2)Create the following select statements:
--2.1)Find all movie titles and their directors
SELECT Title, Director FROM Movies
--2.2)Find the movie with id = 3
SELECT * FROM Movies WHERE MovieId = 3
--2.3)Find all movies made in the last decade
SELECT * FROM Movies WHERE Year > 2010
--2.4)Find all movies longer than 1h 20min
SELECT * FROM Movies WHERE LengthInMinutes > 80
--2.5)Find all movies directed by Steven Spielberg
SELECT * FROM Movies WHERE Director = 'Steven Spielberg'
--2.6)Find all movies whose title start with ‘p’
SELECT * FROM Movies WHERE Title LIKE 'p%'
--SKIPPING 2.7)Find all directors without duplicates 
--2.8)List the first 5 movies sorted by Title alphabetically
SELECT TOP 5 *
FROM Movies
ORDER BY Title
--2.9)Find all movies made between 1990 and 2000
SELECT * FROM Movies WHERE Year between 1990 and 2000
--2.10)Find all movies except the ones made in 2002, 2004, 2006	
SELECT * FROM Movies WHERE Year NOT IN (2002, 2004, 2006)
--2.11)Find all movies with genre containing letter ‘m’
SELECT * FROM Movies WHERE Genre LIKE '%m%'
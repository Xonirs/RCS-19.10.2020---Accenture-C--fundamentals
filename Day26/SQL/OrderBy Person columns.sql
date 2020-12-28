USE Test;


--by deafult ORDER BY sorts results in ASCENDING order
--we can use ASC/DESC
SELECT *
  FROM [dbo].[Persons]
ORDER BY Age

SELECT *
  FROM [dbo].[Persons]
ORDER BY Age ASC

SELECT *
  FROM [dbo].[Persons]
ORDER BY Age DESC

SELECT TOP (5) *
  FROM [dbo].[Persons]
ORDER BY Age DESC

SELECT *
  FROM [dbo].[Persons]
ORDER BY FirstName ASC, LastName ASC

SELECT LastName 
FROM Persons
ORDER BY Age

SELECT LastName, Age 
FROM Persons
ORDER BY Age




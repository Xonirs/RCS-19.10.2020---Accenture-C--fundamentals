
SELECT TOP (1000) [PersonID]
      ,[LastName]
      ,[FirstName]
      ,[Age]
      ,[Address]
      ,[City]
  FROM [Test].[dbo].[Persons]


USE Test;
SELECT TOP (3) [PersonID]
      ,[LastName]
      ,[FirstName]
      ,[Age]
      ,[Address]
      ,[City]
  FROM [Persons]

SELECT TOP (2) [PersonID]
      ,[LastName]
      ,[Age]
      ,[City]
  FROM [Persons]


SELECT TOP (5) [LastName] FROM [Persons]

SELECT TOP (8) FirstName, LastName 
FROM Persons

--to select all data records and all columns
SELECT * FROM Persons --in text: select everything from table Persons

--to select top 3 records and all columns
SELECT TOP (3) * FROM Persons

CREATE TABLE [dbo].[Table]
(
	[CustomerID] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(100) NULL, 
    [City] NVARCHAR(50) NULL, 
    [State] CHAR(2) NULL, 
    [Country] NVARCHAR(200) NULL
)
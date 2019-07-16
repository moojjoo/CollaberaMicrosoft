CREATE TABLE [dbo].[Order]
(
	[OrderID] INT NOT NULL PRIMARY KEY, 
    [CustomerID] INT NOT NULL, 
    [OrderDate] DATETIME2 NOT NULL
)

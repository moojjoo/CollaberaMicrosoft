CREATE TABLE [dbo].[LineItem]
(
	[LineItem] INT NOT NULL PRIMARY KEY, 
    [OrderID] INT NULL, 
    [ProductID] INT NULL, 
    [Quantity] INT NULL, 
    [ItemPrice] MONEY NULL
)

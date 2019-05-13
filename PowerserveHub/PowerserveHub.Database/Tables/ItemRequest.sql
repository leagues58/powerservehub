CREATE TABLE [dbo].[ItemRequest]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Created] DATETIME NOT NULL, 
    [Updated] DATETIME NULL, 
    [Deleted] DATETIME NULL
)

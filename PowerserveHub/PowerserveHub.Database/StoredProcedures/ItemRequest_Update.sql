CREATE PROCEDURE [dbo].[ItemRequest_Update]
	@id INT,
	@name NVARCHAR(50),
	@updated DATETIME

AS

UPDATE ItemRequest SET [Name] = @name, Updated = @updated WHERE Id = @id
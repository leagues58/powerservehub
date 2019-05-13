CREATE PROCEDURE [dbo].[ItemRequest_Delete]
	@id INT,
	@deleted DATETIME

AS

UPDATE ItemRequest SET Deleted = @deleted WHERE Id = @id
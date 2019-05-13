CREATE PROCEDURE [dbo].[ItemRequest_GetById]
	@id INT

AS

SELECT * FROM ItemRequest WHERE Id = @id
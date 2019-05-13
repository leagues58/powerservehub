CREATE PROCEDURE [dbo].[ItemRequest_Insert]
	@name NVARCHAR(50),
	@created DATETIME

AS

INSERT INTO ItemRequest VALUES (@name, @created, NULL, NULL)
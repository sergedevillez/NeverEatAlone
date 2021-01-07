CREATE PROCEDURE [dbo].[CreateHobby]
(
	@param1 int,
	@param2 int
)
AS
BEGIN
	RETURN @param1 + @param2
END

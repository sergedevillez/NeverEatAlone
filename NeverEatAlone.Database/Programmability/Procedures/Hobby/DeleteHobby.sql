CREATE PROCEDURE [dbo].[DeleteHobby]
	@HobbyId int
AS
BEGIN
	DELETE FROM Hobby
	WHERE HobbyId = @HobbyId
END
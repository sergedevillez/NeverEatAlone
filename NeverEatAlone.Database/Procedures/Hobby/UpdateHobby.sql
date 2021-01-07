CREATE PROCEDURE [dbo].[UpdateHobby]
(
	@HobbyId int,
	@HobbyName NVARCHAR(50)
)
AS
BEGIN
	Update Hobby
	Set HobbyName = @HobbyName
	Where HobbyId = @HobbyId
END

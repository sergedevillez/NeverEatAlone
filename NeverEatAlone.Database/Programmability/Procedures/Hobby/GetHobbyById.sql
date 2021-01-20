CREATE PROCEDURE [dbo].[GetHobbyById]
(
	@HobbyId int
)
AS
BEGIN
	Select HobbyId, HobbyName From Hobby
	Where HobbyId = @HobbyId
END

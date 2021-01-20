CREATE PROCEDURE [dbo].[DeleteHobbyFromUser]
	@UserId int,
	@HobbyId int
AS
Begin
	Delete From User_Hobby
	Where UserId = @UserId and HobbyId = @HobbyId
End
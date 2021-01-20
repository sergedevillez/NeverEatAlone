CREATE PROCEDURE [dbo].[AddHobbyToUser]
	@UserId int,
	@HobbyId int
AS
Begin
	Insert into [User_Hobby] (UserId, HobbyId)
	Values (@UserId, @HobbyId)
End
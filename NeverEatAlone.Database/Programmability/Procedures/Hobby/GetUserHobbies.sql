CREATE PROCEDURE [dbo].[GetUserHobbies]
	@UserId int
AS
Begin
	select Hobby.HobbyId, HobbyName from Hobby
	left join User_Hobby On User_Hobby.HobbyId = Hobby.HobbyId
	where User_Hobby.UserId = @UserId
End
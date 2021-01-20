CREATE PROCEDURE [dbo].[GetUserFoods]
	@UserId int
AS
Begin
	Select * from Food
	Left join User_Food on Food.FoodId = User_Food.FoodId
	where UserId = @UserId
End
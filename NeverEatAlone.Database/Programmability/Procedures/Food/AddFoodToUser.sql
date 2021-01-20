CREATE PROCEDURE [dbo].[AddFoodToUser]
	@UserId int,
	@FoodId int
AS
Begin
	Insert into User_Food (UserId, FoodId)
	Values (@UserId, @FoodId)
End
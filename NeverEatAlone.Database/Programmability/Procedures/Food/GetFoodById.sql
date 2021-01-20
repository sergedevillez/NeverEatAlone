CREATE PROCEDURE [dbo].[GetFoodById]
	@FoodId int
AS
Begin
	SELECT * From Food
	Where FoodId = @FoodId
End
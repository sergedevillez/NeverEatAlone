CREATE PROCEDURE [dbo].[UpdateFoodType]
	@FoodTypeId int = 0,
	@FoodTypeName int
AS
Begin
	Update FoodType
	Set FoodTypeName = @FoodTypeName
	where FoodTypeId = @FoodTypeId
End
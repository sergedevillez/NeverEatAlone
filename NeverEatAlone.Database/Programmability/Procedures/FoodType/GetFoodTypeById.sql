CREATE PROCEDURE [dbo].[GetFoodTypeById]
	@FoodTypeId int
AS
Begin
	SELECT * From FoodType
	where FoodTypeId = @FoodTypeId
End
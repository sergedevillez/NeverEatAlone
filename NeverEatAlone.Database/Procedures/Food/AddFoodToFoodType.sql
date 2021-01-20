CREATE PROCEDURE [dbo].[AddFoodToFoodType]
	@FoodId int,
	@FoodTypeId int
AS
Begin
	Insert into Food_FoodType (FoodId, FoodTypeId)
	Values (@FoodId, @FoodTypeId)
End
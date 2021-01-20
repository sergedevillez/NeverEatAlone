CREATE PROCEDURE [dbo].[DeleteFoodType]
	@FoodTypeId int
AS
Begin
	Delete from FoodType 
	where FoodTypeId = @FoodTypeId
End
CREATE PROCEDURE [dbo].[CreateFoodType]
	@FoodTypeName Varchar(50)
AS
Begin
	Insert into FoodType (FoodTypeName)
	Values (@FoodTypeName)
End
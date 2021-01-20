CREATE PROCEDURE [dbo].[CreateFood]
	@FoodName Varchar(50)
AS
Begin
	Insert into Food (FoodName)
	Values (@FoodName)
End
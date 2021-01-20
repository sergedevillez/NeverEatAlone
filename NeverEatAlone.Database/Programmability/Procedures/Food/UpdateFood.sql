CREATE PROCEDURE [dbo].[UpdateFood]
	@FoodId int,
	@FoodName NVarchar(50)
AS
Begin
	Update Food
	Set FoodName = @FoodName
	where FoodId = @FoodId
End
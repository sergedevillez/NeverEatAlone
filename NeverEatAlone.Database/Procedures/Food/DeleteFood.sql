CREATE PROCEDURE [dbo].[DeleteFood]
	@FoodId int
AS
Begin
	Delete from Food
	where FoodId = @FoodId
End
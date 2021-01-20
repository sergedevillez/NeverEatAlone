CREATE PROCEDURE [dbo].[GetUserById]
	@UserId int 
AS
Begin
	Select UserId, Email, FirstName, LastName, IdPhoto from [User]
	Where UserId = @UserId
End
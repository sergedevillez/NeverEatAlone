CREATE PROCEDURE [dbo].[GetAllUsers]
AS
Begin
	Select UserId, Email, FirstName, LastName, IdPhoto from [User]
End
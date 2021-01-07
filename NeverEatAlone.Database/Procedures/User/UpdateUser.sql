CREATE PROCEDURE [dbo].[UpdateUser]
	@UserId int,
	@FirstName NVARCHAR(75),
	@LastName NVARCHAR(75),
	@IdPhoto NVARCHAR(50),
	@CurrentDate date = getDate
AS

BEGIN
	Update [User]
	SET [FirstName] = @FirstName, 
		[LastName] = @LastName, 
		[IdPhoto] = @IdPhoto,
		[UpdatedAt] = @CurrentDate
	WHERE [User]([UserId]) = @UserId
END

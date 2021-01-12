CREATE PROCEDURE [dbo].[UpdateUser]
	@FirstName NVARCHAR(75),
	@LastName NVARCHAR(75),
	@Email NVARCHAR(75),
	@Password NVARCHAR(20),
	@IdPhoto NVARCHAR(50)
AS

BEGIN
	Update [User]
	SET [FirstName] = @FirstName, 
		[LastName] = @LastName,
		[Password] = HASHBYTES('SHA2_512', dbo.GetPreSalt() + @Password + dbo.GetPostSalt()),
		[IdPhoto] = @IdPhoto,
		[UpdatedAt] = (select getDate())
	WHERE [Email] = @Email
END

CREATE PROCEDURE [dbo].[CheckUser]
	@Email NVARCHAR(320),
	@Password VARCHAR(20)
AS
BEGIN
	SELECT [UserId], [LastName], [FirstName], [Email]
	FROM [User] 
	WHERE [Email] = @Email and [Password] = HASHBYTES('SHA2_512', dbo.GetPreSalt() + @Password + dbo.GetPostSalt()) AND [IsActive] = 0;
END
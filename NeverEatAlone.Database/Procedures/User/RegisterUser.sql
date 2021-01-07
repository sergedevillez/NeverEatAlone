CREATE PROCEDURE [dbo].[RegisterUser]
	@FirstName NVARCHAR(75),
	@LastName NVARCHAR(75),
	@Email NVARCHAR(320),
	@Password VARCHAR(20),
	@IdPhoto NVARCHAR(50),
	@CurrentDate date = getDate
AS

BEGIN
	INSERT INTO [User] ([FirstName], [LastName], [Email], [Password], [IdPhoto], [CreatedAt])
	VALUES (@LastName, @FirstName, @Email, HASHBYTES('SHA2_512', dbo.GetPreSalt() + @Password + dbo.GetPostSalt()), @IdPhoto, @CurrentDate);
END

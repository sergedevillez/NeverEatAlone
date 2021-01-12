CREATE PROCEDURE [dbo].[FreezeUnfreezeUser]
	@UserId int
AS
BEGIN
	Update [User]
	Set [IsActive] = 
		(CASE
			WHEN ([IsActive] = 0)
				THEN 1 ELSE 0
		END)
	WHERE [UserId] = @UserId
END


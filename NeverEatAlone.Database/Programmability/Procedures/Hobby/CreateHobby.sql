CREATE PROCEDURE [dbo].[CreateHobby]
(
	@HobbyName NVARCHAR(50)
)
AS
BEGIN
	Insert into Hobby (HobbyName)
	Values (@HobbyName)
END
CREATE PROCEDURE [dbo].[CreateMeeting]
	@UserId int,
	@MeetingDateTime DateTime,
	@MeetingPlace Varchar(50)
AS
Begin
	DECLARE @InsertedId INT;
	Insert into Meeting (MeetingDateTime, MeetingPlace)
	Values (@MeetingDateTime, @MeetingPlace)
	SET @InsertedId = SCOPE_IDENTITY()
End

Begin
	Insert into User_Meeting (UserId, MeetingId, [Role])
	Values (@UserId, @InsertedId, 0)
End
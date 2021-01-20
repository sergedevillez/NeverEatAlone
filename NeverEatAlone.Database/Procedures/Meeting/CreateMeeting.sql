CREATE PROCEDURE [dbo].[CreateMeeting]
	@UserId int,
	@MeetingDate Date,
	@MeetingPlace Varchar(50),
	@MeetingHour Time(7)
AS
Begin
	DECLARE @InsertedId INT;
	Insert into Meeting (MeetingDate, MeetingPlace, MeetingHour)
	Values (@MeetingDate, @MeetingPlace, @MeetingHour)
	SET @InsertedId = SCOPE_IDENTITY()
End

Begin
	Insert into User_Meeting (UserId, MeetingId, [Role])
	Values (@UserId, @InsertedId, 0)
End
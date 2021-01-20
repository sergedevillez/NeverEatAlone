CREATE PROCEDURE [dbo].[UpdateMeeting]
	@MeetingId int,
	@MeetingDateTime DateTime,
	@MeetingPlace varchar(50)
AS
Begin
	Update Meeting
	Set MeetingDateTime = @MeetingDateTime,
	MeetingPlace = @MeetingPlace
	where MeetingId = @MeetingId
End
CREATE PROCEDURE [dbo].[GetMeeting]
	@MeetingId int
AS
Begin
	SELECT * from Meeting
	where MeetingId = @MeetingId
End
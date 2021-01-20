CREATE PROCEDURE [dbo].[GetUserMeetings]
	@UserId int
AS
Begin
	SELECT m.MeetingId, MeetingDateTime, MeetingPlace from Meeting m
	Left join User_Meeting um on m.MeetingId = um.MeetingId
	where um.UserId = @UserId
End
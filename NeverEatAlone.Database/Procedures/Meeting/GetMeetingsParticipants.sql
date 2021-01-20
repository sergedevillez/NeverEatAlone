CREATE PROCEDURE [dbo].[GetMeetingsParticipants]
	@MeetingId int
AS
Begin
	SELECT [User].UserId, FirstName, LastName, Email, IdPhoto From [User]
	Left join User_Meeting on [User].UserId = User_Meeting.UserId
	where MeetingId = @MeetingId
End
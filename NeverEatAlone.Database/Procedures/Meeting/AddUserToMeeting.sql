CREATE PROCEDURE [dbo].[AddUserToMeeting]
	@UserId int,
	@MeetingId int
AS
Begin
	Insert into User_Meeting (UserId, MeetingId)
	Values (@UserId, @MeetingId)
End
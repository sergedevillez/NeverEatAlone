CREATE TABLE [dbo].[UserMeeting]
(
	[UserId] INT NOT NULL , 
    [MeetingId] INT NOT NULL, 
    CONSTRAINT [PK_UserMeeting] PRIMARY KEY ([UserId], [MeetingId]),
    CONSTRAINT [FK_UserMeeting_User] FOREIGN KEY ([UserId]) REFERENCES [User]([UserId]),
    CONSTRAINT [FK_UserMeeting_Meeting] FOREIGN KEY ([MeetingId]) REFERENCES [Meeting]([MeetingId])
)

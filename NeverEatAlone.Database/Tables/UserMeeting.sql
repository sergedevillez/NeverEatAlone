CREATE TABLE [dbo].[User_Meeting]
(
	[UserId] INT NOT NULL , 
    [MeetingId] INT NOT NULL, 
    [Role] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [PK_UserMeeting] PRIMARY KEY ([UserId], [MeetingId]),
    CONSTRAINT [FK_UserMeeting_User] FOREIGN KEY ([UserId]) REFERENCES [User]([UserId]),
    CONSTRAINT [FK_UserMeeting_Meeting] FOREIGN KEY ([MeetingId]) REFERENCES [Meeting]([MeetingId])
)

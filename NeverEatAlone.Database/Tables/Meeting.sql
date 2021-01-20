CREATE TABLE [dbo].[Meeting]
(
	[MeetingId] INT NOT NULL IDENTITY , 
    [MeetingDateTime] DATETIME NOT NULL,
	[MeetingPlace] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Meeting] PRIMARY KEY ([MeetingId])
)

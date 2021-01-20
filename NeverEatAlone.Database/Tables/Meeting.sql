CREATE TABLE [dbo].[Meeting]
(
	[MeetingId] INT NOT NULL IDENTITY , 
    [MeetingDate] DATE NOT NULL,
	[MeetingPlace] VARCHAR(50) NOT NULL, 
    [MeetingHour] TIME NOT NULL, 
    CONSTRAINT [PK_Meeting] PRIMARY KEY ([MeetingId])
)

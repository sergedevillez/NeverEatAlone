CREATE TABLE [dbo].[User_Hobby]
(
	[UserId] INT NOT NULL, 
    [HobbyId] INT NOT NULL,
	CONSTRAINT [PK_UserHobby] PRIMARY KEY ([UserId], [HobbyId]),
	CONSTRAINT [FK_UserHobby_User] FOREIGN KEY ([UserId]) REFERENCES [User]([UserId]),
	CONSTRAINT [FK_UserHobby_Hobby] FOREIGN KEY ([HobbyId]) REFERENCES [Hobby]([HobbyId])
)

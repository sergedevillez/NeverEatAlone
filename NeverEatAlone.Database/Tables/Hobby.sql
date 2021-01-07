CREATE TABLE [dbo].[Hobby]
(
	[HobbyId] INT NOT NULL IDENTITY, 
    [HobbyName] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [UK_Hobby_Name] UNIQUE ([HobbyName]),
    CONSTRAINT [PK_Hobby] PRIMARY KEY ([HobbyId])
)

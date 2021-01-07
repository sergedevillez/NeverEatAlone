CREATE TABLE [dbo].[User_Food]
(
	[FoodId] INT NOT NULL, 
    [UserId] INT NOT NULL,
	CONSTRAINT [PK_UserFood] PRIMARY KEY ([FoodId],[UserId]),
	CONSTRAINT [FK_UserFood_User] FOREIGN KEY ([UserId]) REFERENCES [User]([UserId]),
	CONSTRAINT [FK_UserFood_Food] FOREIGN KEY ([FoodId]) REFERENCES [Food]([FoodId])
)

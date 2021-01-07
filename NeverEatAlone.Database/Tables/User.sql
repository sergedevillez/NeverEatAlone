CREATE TABLE [dbo].[User]
(
	[UserId] INT NOT NULL IDENTITY, 
    [Email] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Password] BINARY(64) NOT NULL, 
    [IdPhoto] NVARCHAR(50) NULL, 
    [CreatedAt] DATE NULL, 
    [UpdatedAt] DATE NULL, 
    [IsActive] BIT NULL DEFAULT 0, 
    CONSTRAINT [PK_User] PRIMARY KEY ([UserId]),
    CONSTRAINT [UK_User_Email] UNIQUE ([Email])
)

CREATE TABLE [dbo].[FoodType]
(
	[FoodTypeId] INT NOT NULL IDENTITY, 
    [FoodTypeName] NVARCHAR(50) NOT NULL,
	CONSTRAINT [PK_FoodType] PRIMARY KEY ([FoodTypeId]),
	CONSTRAINT [UK_FoodType] UNIQUE ([FoodTypeName])
)

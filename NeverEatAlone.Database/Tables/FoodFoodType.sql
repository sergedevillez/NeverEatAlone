CREATE TABLE [dbo].[FoodFoodType]
(
	[FoodTypeId] INT NOT NULL,
	[FoodId] INT NOT NULL,
	CONSTRAINT [PK_FoodFoodType] PRIMARY KEY ([FoodTypeId], [FoodId]),
	CONSTRAINT [FK_FoodFoodType_Food] FOREIGN KEY ([FoodId]) REFERENCES [Food]([FoodId]),
	CONSTRAINT [FK_FoodFoodType_FoodType] FOREIGN KEY ([FoodTypeId]) REFERENCES [FoodType]([FoodTypeId]),
)

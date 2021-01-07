﻿CREATE TABLE [dbo].[Food]
(
	[FoodId] INT NOT NULL IDENTITY,
	[FoodName] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Food] PRIMARY KEY ([FoodId]),
    CONSTRAINT [UK_Food] UNIQUE ([FoodName])
)

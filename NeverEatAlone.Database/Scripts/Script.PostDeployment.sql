/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

USE [NeverEatAlone.Database]
GO

EXEC [dbo].[RegisterUser]
	@FirstName = N'string',
	@LastName = N'string',
	@Email = N'string',
	@Password = N'string',
	@IdPhoto = N'string/string'
GO

EXEC [dbo].[RegisterUser]
	@FirstName = N'string2',
	@LastName = N'string2',
	@Email = N'string2',
	@Password = N'string2',
	@IdPhoto = N'string2/string2'
GO

Exec [dbo].[CreateMeeting]
	@UserId = 1,
	@MeetingDate = '2020-11-11',
	@MeetingPlace ='La place des perdus',
	@MeetingHour = '11:30:00'
GO

Exec [dbo].[AddUserToMeeting]
	@UserId = 2,
	@MeetingId = 1
GO

Insert into Food (FoodName) Values 
('bread'), ('pasta'), ('ketchup'),
('soup'), ('beer'), ('love'),
('banana'), ('water'), ('apple')


Exec [dbo].[AddFoodToUser]
	@UserId = 1,
	@FoodId = 1
GO

Exec [dbo].[AddFoodToUser]
	@UserId = 1,
	@FoodId = 2
GO

Exec [dbo].[AddFoodToUser]
	@UserId = 1,
	@FoodId = 3
GO

Exec [dbo].[AddFoodToUser]
	@UserId = 2,
	@FoodId = 2
GO

Exec [dbo].[AddFoodToUser]
	@UserId = 2,
	@FoodId = 6
GO

Exec [dbo].[CreateFoodType]
	@FoodTypeName = 'Vegetable'
GO

Exec [dbo].[CreateFoodType]
	@FoodTypeName = 'Drink'
GO

Exec [dbo].[CreateFoodType]
	@FoodTypeName = 'Meat'
GO

Exec [dbo].[AddFoodToFoodType]
	@FoodTypeId = 1,
	@FoodId = 7
GO

Exec [dbo].[AddFoodToFoodType]
	@FoodTypeId = 1,
	@FoodId = 9
GO

using System;
using System.Data;
using NeverEatAlone.Models.Global.Entities;


namespace NeverEatAlone.Models.Global.Repositories.Mappers
{
    internal static class DataRecordExtensions
    {
        internal static User ToUser(this IDataRecord dataRecord)
        {
            return new User()
            {
                UserId = (int)dataRecord["UserId"],
                FirstName = (string)dataRecord["FirstName"],
                LastName = (string)dataRecord["LastName"],
                Email = (string)dataRecord["Email"],
                IdPhoto = (string)dataRecord["IdPhoto"]
            };
        }

        internal static Food ToFood(this IDataRecord dataRecord)
        {
            return new Food()
            {
                FoodId = (int)dataRecord["FoodId"],
                FoodName = (string)dataRecord["FoodName"]
            };
        }

        internal static FoodType ToFoodType(this IDataRecord dataRecord)
        {
            return new FoodType()
            {
                FoodTypeId = (int)dataRecord["FoodTypeId"],
                FoodTypeName = (string)dataRecord["FoodTypeName"]
            };
        }

        internal static Meeting ToMeeting(this IDataRecord dataRecord)
        {
            return new Meeting()
            {
                MeetingId = (int)dataRecord["MeetingId"],
                MeetingDateTime = (DateTime)dataRecord["MeetingDateTime"],
                MeetingPlace = (string)dataRecord["MeetingPlace"]
            };
        }

        internal static Hobby ToHobby(this IDataRecord dataReacord)
        {
            return new Hobby()
            {
                HobbyId = (int)dataReacord["HobbyId"],
                HobbyName = (string)dataReacord["HobbyName"]
            };
        }


    }
}

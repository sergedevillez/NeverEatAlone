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
    }
}

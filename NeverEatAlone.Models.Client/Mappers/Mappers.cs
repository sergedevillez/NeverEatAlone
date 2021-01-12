using NeverEatAlone.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Text;

#region Alias
using GlobalUser = NeverEatAlone.Models.Global.Entities.User;
#endregion

namespace NeverEatAlone.Models.Client.Mappers
{
    public static class Mappers
    {
        #region User
        public static GlobalUser ToGlobal(this User entity)
        {
            return new GlobalUser()
            {
                UserId = entity.UserId,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                Password = entity.Password,
                IdPhoto = entity.IdPhoto,
            };
        }

        public static User ToClient(this GlobalUser entity)
        {
            //No password
            return new User(entity.UserId, entity.FirstName, entity.LastName, entity.Email, entity.IdPhoto);
        }
        #endregion
    }
}

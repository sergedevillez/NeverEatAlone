using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Common.Interfaces
{
    public interface IHobbyRepository<TEntity> : ICrudRepository<TEntity>
    {

        void AddHobbyToUser(int userId, int HobbyId);
        void DeleteHobbyFromUser(int userId, int HobbyId);
        IEnumerable GetUserHobbies(int userId);
    }
}

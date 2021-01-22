using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Common.Interfaces
{
    public interface IFoodRepository<TEntity> : ICrudRepository<TEntity>
    {
        void AddFoodToFoodType(int foodId, int foodTypeId);
        IEnumerable<TEntity> GetUserFoods(int id);
        void AddFoodToUser(int userId, int foodId);

    }
}

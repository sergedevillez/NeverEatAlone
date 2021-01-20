using System;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Common.Interfaces
{
    public interface IFoodTypeRepository<TEntity> : ICrudRepository<TEntity>
    {
    }
}

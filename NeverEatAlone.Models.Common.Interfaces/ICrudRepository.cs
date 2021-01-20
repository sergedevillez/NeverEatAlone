using System;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Common.Interfaces
{
    public interface ICrudRepository<TEntity>
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(int id);
        void Create(TEntity entity);
    }
}

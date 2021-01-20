using System;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Common.Interfaces
{
    public interface IAuthRepository<TEntity>
    {
        void Register(TEntity entity);
        void Update(TEntity entity);
        TEntity Login(string email, string password);
        void FreezeUnfreeze(int userId);
        TEntity GetById(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Common.Interfaces
{
    public interface IMeetingRepository<TEntity> : ICrudRepository<TEntity>
    {
        void AddUserToMeeting(int userId, int meetingId);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(int id);
        new void Create(TEntity entity, int userId);
    }
}

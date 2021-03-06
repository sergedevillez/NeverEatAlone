﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Common.Interfaces
{
    public interface IMeetingRepository<TEntity> : ICrudRepository<TEntity>
    {
        void AddUserToMeeting(int userId, int meetingId);
        IEnumerable<TEntity> GetUserMeetings(int userId);
        //void Create(TEntity entity, int userId);
    }
}

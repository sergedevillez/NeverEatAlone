using NeverEatAlone.Models.Client.Entities;
using NeverEatAlone.Models.Common.Interfaces;
using NeverEatAlone.Models.Client.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using GlobalMeeting = NeverEatAlone.Models.Global.Entities.Meeting;
using System.Linq;

namespace NeverEatAlone.Models.Client.Repositories
{
    public class MeetingRepository : IMeetingRepository<Meeting>
    {
        private IMeetingRepository<GlobalMeeting> _repository;

        public MeetingRepository(IMeetingRepository<GlobalMeeting> repository)
        {
            _repository = repository;
        }

        public void AddUserToMeeting(int userId, int meetingId)
        {
            _repository.AddUserToMeeting(userId, meetingId);
        }

        public void Create(Meeting entity, int userId)
        {
            _repository.Create(entity.ToGlobal(), userId);
        }

        public void Create(Meeting entity)
        {
            _repository.Create(entity.ToGlobal());
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Meeting> GetAll()
        {
            return _repository.GetAll().Select(c => c.ToClient());
        }

        public Meeting GetById(int id)
        {
            return _repository.GetById(id)?.ToClient();
        }

        public IEnumerable<Meeting> GetUserMeetings(int userId)
        {
            return _repository.GetUserMeetings(userId).Select(m => m.ToClient());
        }

        public void Update(Meeting entity)
        {
            _repository.Update(entity.ToGlobal());
        }
    }
}

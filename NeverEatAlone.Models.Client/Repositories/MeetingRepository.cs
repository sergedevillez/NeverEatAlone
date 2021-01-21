using NeverEatAlone.Models.Client.Entities;
using NeverEatAlone.Models.Common.Interfaces;
using NeverEatAlone.Models.Client.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using GlobalMeeting = NeverEatAlone.Models.Global.Entities.Meeting;

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
            //TODO Modify the whole branch to allow automatic add
            //_repository.Create(entity, userId);
        }

        public void Create(Meeting entity)
        {
            //_repository.Create(entity.ToGlobal());
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        //public IEnumerable<Meeting> GetAll()
        //{
        //    return _repository.GetAll().ToClient();
        //}

        public Meeting GetById(int id)
        {
            return _repository.GetById(id)?.ToClient();
        }

        public IEnumerable<Meeting> GetUserMeetings(int userId)
        {
            return _repository.GetById(userId);
        }

        public void Update(Meeting entity)
        {
            throw new NotImplementedException();
        }
    }
}

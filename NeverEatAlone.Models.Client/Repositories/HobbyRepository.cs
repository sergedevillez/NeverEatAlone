using NeverEatAlone.Models.Client.Entities;
using NeverEatAlone.Models.Client.Mappers;
using NeverEatAlone.Models.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalHobby = NeverEatAlone.Models.Global.Entities.Hobby;

namespace NeverEatAlone.Models.Client.Repositories
{
    public class HobbyRepository : IHobbyRepository<Hobby>
    {
        private IHobbyRepository<GlobalHobby> _repository;
        public void AddHobbyToUser(int userId, int hobbyId)
        {
            _repository.AddHobbyToUser(userId, hobbyId);
        }

        public void Create(Hobby entity)
        {
            _repository.Create(entity.ToGlobal());
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void DeleteHobbyFromUser(int userId, int hobbyId)
        {
            _repository.DeleteHobbyFromUser(userId, hobbyId);
        }

        public IEnumerable<Hobby> GetAll()
        {
            return _repository.GetAll().Select(h => h.ToClient());
        }

        public Hobby GetById(int id)
        {
            return _repository.GetById(id)?.ToClient();
        }

        public IEnumerable<Hobby> GetUserHobbies(int userId)
        {
            return _repository.GetUserHobbies(userId).Select(h => h.ToClient());
        }

        public void Update(Hobby entity)
        {
            _repository.Update(entity.ToGlobal());
        }
    }
}

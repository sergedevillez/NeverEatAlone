using NeverEatAlone.Models.Client.Entities;
using NeverEatAlone.Models.Client.Mappers;
using NeverEatAlone.Models.Common.Interfaces;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public void DeleteHobbyFromUser(int userId, int HobbyId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hobby> GetAll()
        {
            throw new NotImplementedException();
        }

        public Hobby GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hobby> GetUserHobbies(int userId)
        {
            throw new NotImplementedException();
        }

        public void Update(Hobby entity)
        {
            throw new NotImplementedException();
        }
    }
}

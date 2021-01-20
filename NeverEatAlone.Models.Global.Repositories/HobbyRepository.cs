using NeverEatAlone.Models.Common.Interfaces;
using NeverEatAlone.Models.Global.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Global.Repositories
{
    public class HobbyRepository : IHobbyRepository<Hobby>
    {
        public void AddHobbyToUser(int userId, int HobbyId)
        {
            throw new NotImplementedException();
        }

        public void Create(Hobby entity)
        {
            throw new NotImplementedException();
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

        public IEnumerable GetUserHobbies(int userId)
        {
            throw new NotImplementedException();
        }

        public void Update(Hobby entity)
        {
            throw new NotImplementedException();
        }
    }
}

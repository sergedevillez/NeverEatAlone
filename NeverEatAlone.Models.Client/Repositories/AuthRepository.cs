using NeverEatAlone.Models.Client.Entities;
using NeverEatAlone.Models.Client.Mappers;
using NeverEatAlone.Models.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GlobalUser = NeverEatAlone.Models.Global.Entities.User;

namespace NeverEatAlone.Models.Client.Repositories
{
    public class AuthRepository : IAuthRepository<User>
    {
        private IAuthRepository<GlobalUser> _repository;

        public AuthRepository(IAuthRepository<GlobalUser> repository)
        {
            _repository = repository;
        }

        public void FreezeUnfreeze(int userId)
        {
            _repository.FreezeUnfreeze(userId);
        }

        public User GetById(int id)
        {
            return _repository.GetById(id)?.ToClient();
        }

        public User Login(string email, string password)
        {
            return _repository.Login(email, password)?.ToClient();
        }

        public void Register(User entity)
        {
            _repository.Register(entity.ToGlobal());
        }

        public void Update(User entity)
        {
            _repository.Update(entity.ToGlobal());
        }
    }
}

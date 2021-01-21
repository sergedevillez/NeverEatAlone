using System;
using System.Collections.Generic;
using System.Text;
using Tools.Connection;
using NeverEatAlone.Models.Global.Entities;
using NeverEatAlone.Models.Global.Repositories.Mappers;
using NeverEatAlone.Models.Common.Interfaces;
using System.Linq;

namespace NeverEatAlone.Models.Global.Repositories
{
    public class AuthRepository : IAuthRepository<User>
    {
        private readonly IConnection _connection;

        public AuthRepository(IConnection connection)
        {
            _connection = connection;
        }

        public void FreezeUnfreeze(int userId)
        {
            Command command = new Command("FreezeUnfreezeUser", true);
            command.AddParameter("UserId", userId);

            _connection.ExecuteNonQuery(command);
        }

        public User GetById(int id)
        {
            Command command = new Command("GetUserById", true);
            command.AddParameter("UserId", id);

            return _connection.ExecuteReader(command, dataReader => dataReader.ToUser()).SingleOrDefault();
        }

        public User Login(string email, string password)
        {
            Command command = new Command("CheckUser", true);
            command.AddParameter("Email", email);
            command.AddParameter("Password", password);

            return _connection.ExecuteReader(command, dataReader => dataReader.ToUser()).SingleOrDefault();
        }

        public void Register(User entity)
        {
            Command command = new Command("RegisterUser", true);
            command.AddParameter("LastName", entity.LastName);
            command.AddParameter("FirstName", entity.FirstName);
            command.AddParameter("Email", entity.Email);
            command.AddParameter("Password", entity.Password);
            command.AddParameter("IdPhoto", entity.IdPhoto);

            _connection.ExecuteNonQuery(command);
        }

        public void Update(User entity)
        {
            Command command = new Command("UpdateUser", true);
            command.AddParameter("UserId", entity.LastName);
            command.AddParameter("LastName", entity.LastName);
            command.AddParameter("FirstName", entity.FirstName);
            command.AddParameter("Email", entity.Email);
            command.AddParameter("Password", entity.Password);
            command.AddParameter("IdPhoto", entity.IdPhoto);

            _connection.ExecuteNonQuery(command);
        }
    }
}

using NeverEatAlone.Models.Common.Interfaces;
using NeverEatAlone.Models.Global.Entities;
using NeverEatAlone.Models.Global.Repositories.Mappers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools.Connection;

namespace NeverEatAlone.Models.Global.Repositories
{
    public class HobbyRepository : IHobbyRepository<Hobby>
    {
        private readonly IConnection _connection;

        public HobbyRepository(IConnection connection)
        {
            _connection = connection;
        }

        public void AddHobbyToUser(int userId, int hobbyId)
        {
            Command command = new Command("AddHobbyToUser", true);
            command.AddParameter("UserId", userId);
            command.AddParameter("HobbyId", hobbyId);

            _connection.ExecuteNonQuery(command);
        }

        public void Create(Hobby entity)
        {
            Command command = new Command("CreateHobby", true);
            command.AddParameter("HobbyName", entity.HobbyName);

            _connection.ExecuteNonQuery(command);
        }

        public void Delete(int id)
        {
            Command command = new Command("DeleteHobby", true);
            command.AddParameter("HobbyId", id);

            _connection.ExecuteNonQuery(command);
        }

        public void DeleteHobbyFromUser(int userId, int hobbyId)
        {
            Command command = new Command("DeleteHobbyFromUser", true);
            command.AddParameter("UserId", userId);
            command.AddParameter("HobbyId", hobbyId);
        }

        public IEnumerable<Hobby> GetAll()
        {
            Command command = new Command("GetAllHobbies", true);

            return _connection.ExecuteReader(command, dataReader => dataReader.ToHobby());
        }

        public Hobby GetById(int id)
        {
            Command command = new Command("GetHobbyById", true);
            command.AddParameter("HobbyId", id);

            return _connection.ExecuteReader(command, dataReader => dataReader.ToHobby()).SingleOrDefault();
        }

        public IEnumerable<Hobby> GetUserHobbies(int userId)
        {
            Command command = new Command("GetUserHobbies", true);
            command.AddParameter("UserId", userId);

            return _connection.ExecuteReader(command, dataReader => dataReader.ToHobby());
        }

        public void Update(Hobby entity)
        {
            Command command = new Command("UpdateHobby", true);
            command.AddParameter("HobbyId", entity.HobbyId);
            command.AddParameter("HobbyName", entity.HobbyName);

            _connection.ExecuteNonQuery(command);
        }
    }
}

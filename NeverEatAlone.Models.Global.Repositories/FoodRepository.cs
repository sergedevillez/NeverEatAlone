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
    public class FoodRepository : IFoodRepository<Food>
    {
        private readonly IConnection _connection;

        public FoodRepository(IConnection connection)
        {
            _connection = connection;
        }

        public void AddFoodToFoodType(int foodId, int foodTypeId)
        {
            Command command = new Command("AddFoodToFoodType", true);
            command.AddParameter("FoodId", foodId);
            command.AddParameter("FoodTypeId", foodTypeId);

            _connection.ExecuteNonQuery(command);
        }

        public void AddFoodToUser(int userId, int foodId)
        {
            Command command = new Command("AddFoodToUser", true);
            command.AddParameter("UserId", userId);
            command.AddParameter("FoodId", foodId);

            _connection.ExecuteNonQuery(command);
        }

        public void Create(Food entity)
        {
            Command command = new Command("CreateFood", true);
            command.AddParameter("FoodName", entity.FoodName);

            _connection.ExecuteNonQuery(command);
        }

        public void Delete(int id)
        {
            Command command = new Command("DeleteFood", true);
            command.AddParameter("FoodId", id);

            _connection.ExecuteNonQuery(command);
        }

        public IEnumerable<Food> GetAll()
        {
            Command command = new Command("GetAllFoods", true);

            return _connection.ExecuteReader(command, dataReader => dataReader.ToFood());
        }

        public Food GetById(int id)
        {
            Command command = new Command("GetFoodById", true);
            command.AddParameter("FoodId", id);

            return _connection.ExecuteReader(command, dataReader => dataReader.ToFood()).SingleOrDefault();
        }

        public IEnumerable<Food> GetUserFoods(int id)
        {
            Command command = new Command("GetUserFoods", true);
            command.AddParameter("UserId", id);

            return _connection.ExecuteReader(command, dataReader => dataReader.ToFood());
        }

        public void Update(Food entity)
        {
            Command command = new Command("UpdateFood", true);
            command.AddParameter("FoodName", entity.FoodName);
            command.AddParameter("FoodId", entity.FoodId);

            _connection.ExecuteNonQuery(command);
        }
    }
}

using NeverEatAlone.Models.Common.Interfaces;
using NeverEatAlone.Models.Global.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
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

        public void AddFoodToFoodType(int FoodId, int FoodTypeId)
        {
            throw new NotImplementedException();
        }

        public void AddFoodToUser(int userId, int FoodId)
        {
            throw new NotImplementedException();
        }

        public void Create(Food entity)
        {
            throw new NotImplementedException();
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

            return _connection.ExecuteReader(command, dataReader => dataReader.)
        }

        public Food GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetUserFood(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Food entity)
        {
            throw new NotImplementedException();
        }
    }
}

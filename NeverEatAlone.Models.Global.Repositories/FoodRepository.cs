using NeverEatAlone.Models.Common.Interfaces;
using NeverEatAlone.Models.Global.Entities;
using System;
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

        public void Delete(int id)
        {
            Command command = new Command("DeleteFood", true);
            command.AddParameter("FoodId", id);

            _connection.ExecuteNonQuery(command);
        }

        public IEnumerable<Food> getAll()
        {
            Command command = new Command("GetAllFoods")
        }

        public Food getById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Food entity)
        {
            throw new NotImplementedException();
        }
    }
}

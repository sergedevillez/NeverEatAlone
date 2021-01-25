using NeverEatAlone.Models.Common.Interfaces;
using NeverEatAlone.Models.Global.Entities;
using NeverEatAlone.Models.Global.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools.Connection;

namespace NeverEatAlone.Models.Global.Repositories
{
    public class FoodTypeRepository : IFoodTypeRepository<FoodType>
    {

        private readonly IConnection _connection;

        public FoodTypeRepository(IConnection connection)
        {
            _connection = connection;
        }

        public void Create(FoodType entity)
        {
            Command command = new Command("CreateFoodType", true);
            command.AddParameter("FoodTypeName", entity.FoodTypeName);

            _connection.ExecuteNonQuery(command);
        }

        public void Delete(int id)
        {
            Command command = new Command("DeleteFoodType", true);
            command.AddParameter("FoodTypeId", id);

            _connection.ExecuteNonQuery(command);
        }

        public IEnumerable<FoodType> GetAll()
        {
            Command command = new Command("GetAllFoodTypes", true);

            return _connection.ExecuteReader(command, dataReader => dataReader.ToFoodType());
        }

        public FoodType GetById(int id)
        {
            Command command = new Command("GetFoodTypeById", true);
            command.AddParameter("FoodTypeId", id);

            return _connection.ExecuteReader(command, dataReader => dataReader.ToFoodType()).SingleOrDefault();
        }

        public void Update(FoodType entity)
        {
            Command command = new Command("UpdateFoodType", true);
            command.AddParameter("FoodTypeName", entity.FoodTypeName);
            command.AddParameter("FoodTypeId", entity.FoodTypeId);

            _connection.ExecuteNonQuery(command);
        }
    }
}

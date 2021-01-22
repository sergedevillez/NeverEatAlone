using NeverEatAlone.Models.Client.Entities;
using NeverEatAlone.Models.Client.Mappers;
using NeverEatAlone.Models.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalFood = NeverEatAlone.Models.Global.Entities.Food;

namespace NeverEatAlone.Models.Client.Repositories
{
    public class FoodRepository : IFoodRepository<Food>
    {
        private IFoodRepository<GlobalFood> _repository;

        public FoodRepository(IFoodRepository<GlobalFood> repository)
        {
            _repository = repository;
        }

        public void AddFoodToFoodType(int foodId, int foodTypeId)
        {
            _repository.AddFoodToFoodType(foodId, foodTypeId)
        }

        public void AddFoodToUser(int userId, int foodId)
        {
            _repository.AddFoodToUser(userId, foodId);
        }

        public void Create(Food entity)
        {
            _repository.Create(entity.ToGlobal());
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Food> GetAll()
        {
            return _repository.GetAll().Select(f => f.ToClient());
        }

        public Food GetById(int id)
        {
            return _repository.GetById(id)?.ToClient();
        }

        public IEnumerable<Food> GetUserFoods(int id)
        {
            return _repository.GetUserFoods(id).Select(f => f.ToClient());
        }

        public void Update(Food entity)
        {
            _repository.Update(entity.ToGlobal());
        }
    }
}

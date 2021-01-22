using NeverEatAlone.Models.Client.Entities;
using NeverEatAlone.Models.Client.Mappers;
using NeverEatAlone.Models.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GlobalFoodType = NeverEatAlone.Models.Global.Entities.FoodType;

namespace NeverEatAlone.Models.Client.Repositories
{
    public class FoodTypeRepository : IFoodTypeRepository<FoodType>
    {
        private IFoodTypeRepository<GlobalFoodType> _repository;

        public FoodTypeRepository(IFoodTypeRepository<GlobalFoodType> repository)
        {
            _repository = repository;
        }

        public void Create(FoodType entity)
        {
            _repository.Create(entity.ToGlobal());
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<FoodType> GetAll()
        {
            return _repository.GetAll().Select(ft => ft.ToClient());
        }

        public FoodType GetById(int id)
        {
            return _repository.GetById(id)?.ToClient();
        }

        public void Update(FoodType entity)
        {
            _repository.Update(entity.ToGlobal());
        }
    }
}

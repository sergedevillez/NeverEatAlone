using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeverEatAlone.Api.Infrastructure.Attributes;
using NeverEatAlone.Models.Client.Entities;
using NeverEatAlone.Models.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeverEatAlone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AuthRequired]
    public class FoodController : ControllerBase
    {
        private readonly IFoodRepository<Food> _repository;

        public FoodController(IFoodRepository<Food> repository)
        {
            _repository = repository;
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] Food entity)
        {
            _repository.Create(entity);
            return Ok();
        }

        [HttpGet("Get/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpPost("Update")]
        public IActionResult Update([FromBody] Food entity)
        {
            _repository.Update(entity);

            return Ok();
        }

        [HttpPost("Delete")]
        public IActionResult Delete([FromBody] int id)
        {
            _repository.Delete(id);

            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost("AddFoodToFoodType")]
        public IActionResult AddFoodToFoodType([FromBody]int foodId, int foodTypeId)
        {
            _repository.AddFoodToFoodType(foodId, foodTypeId);

            return Ok();
        }

        [HttpGet("GetUserFoods/{userId}")]
        public IActionResult GetUserFoods(int userId)
        {
            return Ok(_repository.GetUserFoods(userId));
        }

        [HttpPost("AddFoodToUser")]
        public IActionResult AddFoodToUser([FromBody] int userId, int foodId)
        {
            _repository.AddFoodToUser(userId, foodId);

            return Ok();
        }
    }
}

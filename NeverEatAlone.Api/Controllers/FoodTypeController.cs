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
    public class FoodTypeController : ControllerBase
    {
        private readonly IFoodTypeRepository<FoodType> _repository;

        public FoodTypeController(IFoodTypeRepository<FoodType> repository)
        {
            _repository = repository;
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] FoodType entity)
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
        public IActionResult Update([FromBody] FoodType entity)
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
    }
}
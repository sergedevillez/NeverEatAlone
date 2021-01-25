using Microsoft.AspNetCore.Mvc;
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
    public class HobbyController : ControllerBase
    {
        private readonly IHobbyRepository<Hobby> _repository;

        public HobbyController(IHobbyRepository<Hobby> repository)
        {
            _repository = repository;
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] Hobby entity)
        {
            _repository.Create(entity);
            return Ok();
        }

        [HttpGet("Read")]
        public IActionResult GetById([FromBody] int id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpPost("Update")]
        public IActionResult Update([FromBody] Hobby entity)
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

        [HttpGet("GetUserHobbies")]
        public IActionResult GetUserHobbies([FromBody] int userId)
        {
            return Ok(_repository.GetUserHobbies(userId));
        }

        [HttpPost("AddHobbyToUser")]
        public IActionResult AddHobbyToUser([FromBody] int userdId, int hobbyId)
        {
            _repository.AddHobbyToUser(userdId, hobbyId);

            return Ok();
        }

        [HttpPost("DeleteHobbyFromUser")]
        public IActionResult DeleteHobbyFromUser([FromBody] int userId, int hobbyId)
        {
            _repository.DeleteHobbyFromUser(userId, hobbyId);

            return Ok();
        }
    }
}

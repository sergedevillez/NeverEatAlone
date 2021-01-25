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
    public class MeetingController : ControllerBase
    {
        private readonly IMeetingRepository<Meeting> _repository;

        public MeetingController(IMeetingRepository<Meeting> repository)
        {
            _repository = repository;
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] Meeting entity)
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
        public IActionResult Update([FromBody] Meeting entity)
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

        [HttpPost("AddUserToMeeting")]
        public IActionResult AddUserToMeeting([FromBody] int meetingId, int userId)
        {
            _repository.AddUserToMeeting(meetingId, userId);

            return Ok();
        }

        [HttpGet("GetMeetingParticipants/{meetingId}")]
        public IActionResult GetMeetinParticipants(int meetingId)
        {
            return Ok(_repository.GetUserMeetings(meetingId));
        }

        [HttpGet("GetUserMeeting/{userId}")]
        public IActionResult GetUserMeeting(int userId)
        {
            return Ok(_repository.GetUserMeetings(userId));
        }

    }
}

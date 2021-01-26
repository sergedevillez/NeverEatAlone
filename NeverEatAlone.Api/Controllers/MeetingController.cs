using Microsoft.AspNetCore.Mvc;
using NeverEatAlone.Api.Infrastructure.Attributes;
using NeverEatAlone.Api.Models.Meeting;
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
    public class MeetingController : ControllerBase
    {
        private readonly IMeetingRepository<Meeting> _repository;

        public MeetingController(IMeetingRepository<Meeting> repository)
        {
            _repository = repository;
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] CreateMeetingForm meetingForm)
        {
            if (ModelState.IsValid)
            {
                //Todo : Add userS in the creation of a meeting.
                _repository.Create(new Meeting(meetingForm.MeetingDateTime, meetingForm.MeetingPlace));
                return Ok();
            }
            return BadRequest();
            
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

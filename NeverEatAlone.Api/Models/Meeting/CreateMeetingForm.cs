using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NeverEatAlone.Api.Models.Meeting
{
    public class CreateMeetingForm
    {
        //Todo : Make hobbyInt a table []
        [Required]
        public int[] UserId { get; set; }

        [Required]
        public DateTime MeetingDateTime { get; set; }

        [Required]
        public String MeetingPlace { get; set; }
    }
}

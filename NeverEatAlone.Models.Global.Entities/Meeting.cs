using System;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Global.Entities
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public DateTime MeetingDateTime { get; set; }
        public string MeetingPlace {get; set;}
    }
}

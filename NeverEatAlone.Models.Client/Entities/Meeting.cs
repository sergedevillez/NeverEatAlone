using System;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Client.Entities
{
    public class Meeting
    {
        public int MeetingId { get; private set; }
        public DateTime MeetingDateTime { get; private set; }
        public string MeetingPlace { get; private set; }

        public Meeting(DateTime meetingDateTime, string meetingPlace)
        {
            MeetingDateTime = meetingDateTime;
            MeetingPlace = meetingPlace;
        }

        internal Meeting(int meetingId, DateTime meetingDateTime, string meetingPlace)
            :this(meetingDateTime, meetingPlace)
        {
            MeetingId = meetingId;
        }
    }
}

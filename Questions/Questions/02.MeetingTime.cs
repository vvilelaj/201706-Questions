using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Questions
{
    /*
	Your company built an in-house calendar tool called HiCal. 
	You want to add a feature to see the times in a day when everyone is available.
	To do this, you’ll need to know when any team is having a meeting. 
	In HiCal, a meeting is stored as an object of a Meeting class with integer properties StartTime and EndTime. 
	These integers represent the number of 30-minute blocks past 9:00am.

	For example:

	var meeting1 = new Meeting(2, 3); // meeting from 10:00 – 10:30 am
	var meeting2 = new Meeting(6, 9); // meeting from 12:00 – 1:30 pm

	Write a function MergeRanges() that takes a list of meeting time ranges and returns a list of condensed ranges.

	For example, given:

		  [Meeting(0, 1), Meeting(3, 5), Meeting(4, 8), Meeting(10, 12), Meeting(9, 10)]

	your function would return:

		  [Meeting(0, 1), Meeting(3, 8), Meeting(9, 12)]

		 */
    public class HiCal
    {
        public List<Meeting> MergeRanges(List<Meeting> meetings)
        {
            if (meetings == null)
                return meetings;

            if (meetings.Count <= 1)
                return meetings;

            meetings = meetings.OrderBy(m => m.StartTime).ToList();
            var mergedMeetings = new List<Meeting>();

            var mergedMeeting = (Meeting)null;
            foreach (var meeting in meetings)
            {
                if (mergedMeeting == null)
                {
                    mergedMeeting = meeting;
                    continue;
                }

                if (meeting.StartTime >= mergedMeeting.StartTime &&
                    meeting.StartTime <= mergedMeeting.EndTime)
                {
                    mergedMeeting.EndTime = meeting.EndTime;
                }
                else
                {
                    mergedMeetings.Add(mergedMeeting);
                    mergedMeeting = meeting;
                }
            }
            mergedMeetings.Add(mergedMeeting);

            return mergedMeetings;
        }
    }

    public class Meeting
    {
        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }
    }
}

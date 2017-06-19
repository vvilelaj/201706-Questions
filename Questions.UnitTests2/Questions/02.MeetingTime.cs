
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questions.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.UnitTests2.Questions
{
    [TestClass]
    public class HiCalUnitTests
    {
        [TestClass]
        public class MergeRanges
        {
            [TestMethod]
            public void MergeRanges_RecibeListaNula_DevuelveNulo()
            {
                var meetings = (List<Meeting>)null;
                var hiCal = new HiCal();

                var result = hiCal.MergeRanges(meetings);

                Assert.IsNull(result);
            }

            [TestMethod]
            public void MergeRanges_ReceivesOneMeeting_ReturnsTheSameMeeting()
            {
                var meetings = new List<Meeting>() { new Meeting(1,2) };
                var hiCal = new HiCal();

                var result = hiCal.MergeRanges(meetings);

                Assert.AreEqual(meetings,result);
            }

            [TestMethod]
            public void MergeRanges_ReceivesTwoMeetings_ReturnsTheOneMeeting()
            {
                var meetings = new List<Meeting>() {
                    new Meeting(1, 2),
                    new Meeting(2, 3)
                };
                var hiCal = new HiCal();

                var result = hiCal.MergeRanges(meetings);

                Assert.AreEqual(1, result.Count);
                Assert.AreEqual(1, result[0].StartTime);
                Assert.AreEqual(3, result[0].EndTime);
            }

            [TestMethod]
            public void MergeRanges_Receives5Meetings_ReturnsTheOneMeeting()
            {
                var meetings = new List<Meeting>() {
                    new Meeting(0, 1),
                    new Meeting(3, 5),
                    new Meeting(4, 8),
                    new Meeting(10, 12),
                    new Meeting(9, 10)
                };
                var hiCal = new HiCal();

                var result = hiCal.MergeRanges(meetings);

                Assert.AreEqual(3, result.Count);
                //
                Assert.AreEqual(0, result[0].StartTime);
                Assert.AreEqual(1, result[0].EndTime);
                //
                Assert.AreEqual(3, result[1].StartTime);
                Assert.AreEqual(8, result[1].EndTime);
                //
                Assert.AreEqual(9, result[2].StartTime);
                Assert.AreEqual(12, result[2].EndTime);
            }
        }
    }
}

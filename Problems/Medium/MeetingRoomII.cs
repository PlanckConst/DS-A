using System;

namespace Problems.Medium
{
    public class MeetingRoomII
    {
        public static int MinMeetingRooms(int[][] intervals)
        {
            /*
                Given an array of meeting time intervals
                Merge time intervals?
                Overlapping time intervals will merit an additional conference room 

                Question: How many overlapping time intervals are there?
                case 1:
                    5 ----- 10 15 ---20
                0 ---------------------- 30
                expected: 2

                case 2:
                0----4 5-------10
                expected: 1

                case 3:
                 1------5
                   3-----6
                0----4 5-------10
                expected: 3 - overlaps at 3--5 with 3 arrays

                so as we iterate through the meetings
                [[0,30],[5,10],[15,20]]
                current start = 0

                Intervals are not sorted**
                should we sort the intervals by the start time?

                if two intervals can merge then that is +1 conference room
                store the merged intervals.
                check next interval if it can be merged then +1 conference room, if not then move starting pointer  to new interval

                ultimately we want to see how many times we can merge all intervals until you cannot merge anymore
                each merge

            */
            if (intervals == null || intervals.Length == 0)
            {
                return 0;
            }

            int n = intervals.Length;
            int[] start = new int[n];
            int[] end = new int[n];

            for (int i = 0; i < n; i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];
            }

            Array.Sort(start);
            Array.Sort(end);

            int rooms = 0;
            int maxRooms = 0;
            int s_ptr = 0, e_ptr = 0;

            while (s_ptr < n)
            {
                if (start[s_ptr] < end[e_ptr])
                {
                    rooms++;
                    maxRooms = Math.Max(maxRooms, rooms);
                    s_ptr++;
                }
                else
                {
                    rooms--;
                    e_ptr++;
                }
            }

            return maxRooms;
        }
    }
}

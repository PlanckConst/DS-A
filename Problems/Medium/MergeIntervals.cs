using System;
using System.Collections.Generic;

namespace Problems.Medium
{
    public class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1)
                return intervals;

            // Sort intervals based on the start time
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            var merged = new List<int[]>();
            var currentInterval = intervals[0];
            merged.Add(currentInterval);

            foreach (var interval in intervals)
            {
                int currentEnd = currentInterval[1];
                int nextStart = interval[0];
                int nextEnd = interval[1];

                // Check if intervals overlap
                if (currentEnd >= nextStart)
                {
                    // Merge the intervals
                    currentInterval[1] = Math.Max(currentEnd, nextEnd);
                }
                else
                {
                    // Move to the next interval
                    currentInterval = interval;
                    merged.Add(currentInterval);
                }
            }

            return merged.ToArray();
        }
    }
}

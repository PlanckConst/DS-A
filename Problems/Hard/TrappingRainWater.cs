using System;

namespace Problems.Hard
{
    public class Leet42
    {
        public static int Trap(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int ans = 0;
            int left_max = 0, right_max = 0;
            while (left < right)
            {
                if (height[left] < height[right])
                {
                    left_max = Math.Max(left_max, height[left]);
                    ans += left_max - height[left];
                    ++left;
                }
                else
                {
                    right_max = Math.Max(right_max, height[right]);
                    ans += right_max - height[right];
                    --right;
                }
            }
            return ans;
        }
    }
}

using System.Collections.Generic;

namespace Problems.Easy
{
    public class Leet1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = [];

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    return [map[target - nums[i]], i];
                }
                map[nums[i]] = i;
            }
            return [];
        }
    }
}

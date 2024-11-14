namespace Problems.Easy
{
    public class Leet217
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            bool hasDuplicates = false;

            // Loop through the array starting from the second element
            for (int i = 1; i < nums.Length; i++)
            {
                int key = nums[i]; // The current element to be inserted in the sorted portion
                int j = i - 1;

                // Move elements of nums[0..i-1] that are greater than 'key' to one position ahead of their current position
                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }

                // Check if the current element is equal to the element before it (duplicate found)
                if (j >= 0 && nums[j] == key)
                {
                    hasDuplicates = true;
                    break;
                }

                // Insert 'key' into the correct sorted position
                nums[j + 1] = key;
            }

            return hasDuplicates;
        }
        //Hashset Solution
        //HashSet<int> seen = new HashSet<int>();
        //foreach (int num in nums)
        //{
        //    if (seen.Contains(num))
        //    {
        //        return true;
        //    }
        //    seen.Add(num);
        //}
        //return false;
    }
}

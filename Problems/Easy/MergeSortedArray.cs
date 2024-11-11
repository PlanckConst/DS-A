namespace Problems.Easy
{
    public class Leet88
    {
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //given two integer arrays: nums1 nums2 (sorted in decreasing order)
            //Output: array of nums1 and nums2 merged

            //Example: nums1 = [1, 2, 3, 0, 0, 0], nums2 = [2, 5, 6]
            //Expected output: return nums1 = [1, 2, 2, 3, 5, 6]

            /*
            Approach: Three Pointers
                         j2|    i|
            nums1 = [1, 2, 3, 0 0, 6]
            nums2 = [2, 5, 6]
                 j1| = -1

                     [1, 2, 2, 3, 5, 6]     
            */

            // Initialize pointers for nums1 and nums2
            //Three points -> nums1 end, nums2 end, and nums1 true end
            int nums1EndPointer = m - 1; //indexing starts 0
            int nums2EndPointer = n - 1; //
            int movingPointer = m + n - 1;

            while (nums1EndPointer >= 0 && nums2EndPointer >= 0)
            {
                if (nums1[nums1EndPointer] > nums2[nums2EndPointer])
                {
                    nums1[movingPointer] = nums1[nums1EndPointer];
                    nums1EndPointer--;
                }
                else
                {
                    nums1[movingPointer] = nums2[nums2EndPointer];
                    nums2EndPointer--;
                }
                movingPointer--;
            }
            //If nums2 is not empty
            while (nums2EndPointer >= 0)
            {
                nums1[movingPointer] = nums2[nums2EndPointer];
                movingPointer--;
                nums2EndPointer--;
            }

            return nums1;
        }
    }
}

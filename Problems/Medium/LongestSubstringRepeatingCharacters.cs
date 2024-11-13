using System;

namespace Problems.Medium
{
    public class LongestSubstringRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            // Stack-allocated boolean array to track characters (256 ASCII characters)
            Span<bool> isCharInWindow = stackalloc bool[256];

            int leftPointer = 0; // Left pointer for the sliding window
            int maxLength = 0; // To store the maximum length of a substring found

            // Iterate over each character with the right pointer
            for (int rightPointer = 0; rightPointer < s.Length; rightPointer++)
            {
                char currentChar = s[rightPointer];

                // If the character is already in the current window, adjust the left pointer
                while (isCharInWindow[currentChar])
                {
                    // Remove the character at the left pointer from the window
                    isCharInWindow[s[leftPointer]] = false;
                    leftPointer++;
                }

                // Mark the current character as seen
                isCharInWindow[currentChar] = true;

                // Calculate the length of the current substring and update maxLength
                int currentLength = rightPointer - leftPointer + 1;
                maxLength = Math.Max(maxLength, currentLength);
            }

            return maxLength;
        }
    }
}

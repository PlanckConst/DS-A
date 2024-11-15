using System;
using System.Text;

namespace Problems.Medium
{
    public class LongestPalindromicString
    {
        public static string LongestPalindrome(string s)
        {
            // Step 1: Transform the input string
            string transformedString = TransformString(s);
            int n = transformedString.Length;

            // Step 2: Find palindrome lengths using Manacher's algorithm
            int[] palindromeLengths = CalculatePalindromeLengths(transformedString, n);

            // Step 3: Find the longest palindrome based on the calculated lengths
            int[] maxPalindrome = FindLongestPalindrome(palindromeLengths);

            // Step 4: Extract the longest palindromic substring from the original string
            return ExtractLongestPalindrome(s, maxPalindrome);
        }

        // Helper function to transform the input string by inserting '#' between characters
        private static string TransformString(string s)
        {
            StringBuilder sb = new("#");
            foreach (char c in s)
            {
                _ = sb.Append(c);
                _ = sb.Append('#');
            }
            return sb.ToString();
        }

        // Helper function to calculate the palindrome lengths using Manacher's algorithm
        private static int[] CalculatePalindromeLengths(string transformedString, int n)
        {
            int[] palindromeLengths = new int[n];
            int currentCenter = 0;
            int currentRightBoundary = 0;

            for (int i = 0; i < n; i++)
            {
                // Calculate the mirror index relative to the current center
                int mirrorIndex = (2 * currentCenter) - i;

                // Initialize the palindrome length if within the current boundary
                if (i < currentRightBoundary)
                {
                    palindromeLengths[i] = Math.Min(currentRightBoundary - i, palindromeLengths[mirrorIndex]);
                }

                // Expand the palindrome centered at i
                ExpandPalindrome(transformedString, palindromeLengths, i, n);

                // Update the current center and right boundary if necessary
                if (i + palindromeLengths[i] > currentRightBoundary)
                {
                    currentCenter = i;
                    currentRightBoundary = i + palindromeLengths[i];
                }
            }

            return palindromeLengths;
        }

        // Helper function to expand the palindrome centered at index i
        private static void ExpandPalindrome(string s, int[] lengths, int center, int n)
        {
            while (center + 1 + lengths[center] < n &&
                   center - 1 - lengths[center] >= 0 &&
                   s[center + 1 + lengths[center]] == s[center - 1 - lengths[center]])
            {
                lengths[center]++;
            }
        }

        // Helper function to find the maximum palindrome length and its center
        private static int[] FindLongestPalindrome(int[] palindromeLengths)
        {
            int maxLength = 0;
            int centerIndex = 0;

            for (int i = 0; i < palindromeLengths.Length; i++)
            {
                if (palindromeLengths[i] > maxLength)
                {
                    maxLength = palindromeLengths[i];
                    centerIndex = i;
                }
            }

            return [maxLength, centerIndex];
        }

        // Helper function to extract the longest palindromic substring from the original string
        private static string ExtractLongestPalindrome(string s, int[] maxPalindrome)
        {
            int maxLength = maxPalindrome[0];
            int centerIndex = maxPalindrome[1];
            int startIndex = (centerIndex - maxLength) / 2;

            return s.Substring(startIndex, maxLength);
        }
    }
}

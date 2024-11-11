using System;
using System.Text;

namespace Problems.Easy
{
    public class Leet
    {
        public static string MergeAlternately(string word1, string word2)
        {
            //Instantiate a StringBuilder Class result string, capacity = word2 + word1 length, but maximum capacity is the max constraint which is 200
            StringBuilder resultString = new(word1.Length + word2.Length, 200);

            int maxLength = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < word1.Length)
                {
                    resultString.Append(word1[i]);
                }
                if (i < word2.Length)
                {
                    resultString.Append(word2[i]);
                }
            }
            return resultString.ToString();
        }
    }
}

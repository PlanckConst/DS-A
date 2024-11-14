using System.Collections.Generic;

namespace Problems.Medium
{
    public class Leet49
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dict = [];

            for (int i = 0; i < strs.Length; i++)
            {
                string str = strs[i];
                char[] charArray = new char[26];

                for (int j = 0; j < str.Length; j++)
                {
                    charArray[str[j] - 'a']++;
                }

                string key = new(charArray);

                if (!dict.TryGetValue(key, out IList<string>? value))
                {
                    value = ([]);
                    dict[key] = value;
                }
                value.Add(str);
            }
            return [.. dict.Values];
        }
    }
}

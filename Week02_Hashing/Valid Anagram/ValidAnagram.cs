using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week02_Hashing.Valid_Anagram
{
    public  class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!freq.ContainsKey(c))
                    freq[c] = 0;

                freq[c]++;
            }

            foreach (char c in t)
            {
                if (!freq.ContainsKey(c))
                    return false;

                freq[c]--;

                if (freq[c] < 0)
                    return false;
            }

            return true;
        }


    }
}

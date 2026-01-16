using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week02_Hashing.Group_Anagrams
{
    public  class Group_Anagrams
    {

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> map =new Dictionary<string, List<string>>();

            foreach (string word in strs)
            {
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }

                map[key].Add(word);
            }

            return map.Values.ToList<IList<string>>();
        }

    }
}

using System.Collections.Generic;
using System.Linq;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    // 2020-04-06: https://leetcode.com/explore/challenge/card/30-day-leetcoding-challenge/528/week-1/3288/
    // 0049. https://leetcode.com/problems/group-anagrams/
    public class GroupAnagrams
    {
        public IList<IList<string>> Resolve(string[] strs)
        {
            var dictionary = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                var m = new int[26];
                foreach (var current in str.ToCharArray())
                    m[current - 'a']++;

                var key = string.Join(",", m);
                if (dictionary.ContainsKey(key))
                    dictionary[key].Add(str);
                else
                    dictionary.Add(key, new List<string> { str });
            }

            return dictionary.Values.ToList();
        }
    }
}

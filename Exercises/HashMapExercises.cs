using System.Collections.Generic;

namespace DataStructures.Exercises
{
    public class HashMapExercises
    {
        //public int MostFrequentNumber(int[] nums) { }

        //public char MostFrequentCharacter(string str) { }

        //public bool ContainsDuplicate(int[] nums) { }

        //public bool IsAnagram(string first, string second) { }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();

            int[] res = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (seen.ContainsKey(complement)) return new[] { seen[complement], i };
                seen[complement] = i;
            }

            return null;
        }

        //public int FirstRepeatedNumber(int[] nums) { }

        //public int CountDistinctNumbers(int[] nums) { }

        //public Dictionary<int, int> FrequencyMap(int[] nums) { }

        //public char FirstNonRepeatingCharacter(string str) { }

        //public string GroupAnagrams(string[] words) { }

        //public int LongestConsecutiveSequence(int[] nums) { }

        //public int CountPairsWithSum(int[] nums, int target) { }

        //public bool CanConstructRansomNote(string ransom, string magazine) { }

        //public int SubarraySumEqualsK(int[] nums, int k) { }
    }
}

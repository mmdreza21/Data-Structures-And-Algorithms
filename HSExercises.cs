using System.Collections.Generic;

namespace DataStructures
{
    internal class HSExercises
    {
        public int MostFrequentNum(int[] arr)
        {
            Dictionary<int, int> intFrequency = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (intFrequency.ContainsKey(i)) intFrequency[i]++;
                else intFrequency.Add(i, 1);
            }
            int mf = arr[0];
            int count = 0;
            foreach (var item in intFrequency)
            {
                if (item.Value > count)
                {
                    count = item.Value;
                    mf = item.Key;
                }

            }
            return mf;

        }

        public char MostFrequentChInWord(string str)
        {
            Dictionary<char, int> intFrequency = new Dictionary<char, int>();

            foreach (char i in str)
            {
                if (intFrequency.ContainsKey(i)) intFrequency[i]++;
                else intFrequency.Add(i, 1);
            }

            char mf = str[0];
            int count = 0;
            foreach (var item in intFrequency)
            {
                if (item.Value > count)
                {
                    count = item.Value;
                    mf = item.Key;
                }

            }
            return mf;


        }
        public int CountPairsWithDiff(int[] array, int k)
        {
            if (k == 0) throw new System.Exception("k can not be zero! k != 0");

            HashSet<int> list = new HashSet<int>(array);
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            foreach (var item in list)
            {
                if (list.Contains(item + k))
                {
                    pairs.Add(item, item + k);
                }
            }

            return pairs.Count;

        }
        /**
    * Given an array of numbers and a target value,
    * find the indices of the two numbers that add up to the target.
   *
    * Example:
    *   Input: nums = [2, 7, 11, 15], target = 9
    *   Output: [0, 1] // because nums[0] + nums[1] === 9
   *
    * @param nums - An array of integers
    * @param target - The target sum to find
    * @returns An array of two indices if a pair is found, otherwise null
   */
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (seen.ContainsKey(complement)) return new[] { seen[complement], i };
                seen[nums[i]] = i;
            }

            return null;
        }

        /**
        * Given an array of integers,
        * return the largest number in the array.
       *
        * Example:
        *   Input: [2, 7, 11, 15]
        *   Output: 15
       *
        * @param nums - Array of integers
        * @returns The largest number
       */
        //Easy

        public int FindMax(int[] nums)
        {
            int max = int.MinValue;

            foreach (var item in nums)
                if (item > max) max = item;

            return max;
        }
        /**
            * Given an array of integers,
            * return the smallest number in the array.
         *
            * Example:
            *   Input: [2, 7, 11, 15]
            *   Output: 2
         *
            * @param nums - Array of integers
            * @returns The smallest number
         */
        public int FindMin(int[] nums)
        {
            int min = int.MaxValue;

            foreach (var item in nums)
                if (item < min) min = item;

            return min;
        }
        /**
            * Given an array of integers,
            * calculate the sum of all elements.
         *
            * Example:
            *   Input: [1, 2, 3, 4]
            *   Output: 10
         *
            * @param nums - Array of integers
            * @returns Sum of all numbers
         */
        public int SumArray(int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
                sum += item;

            return sum;
        }
        /**
            * Given a string,
            * count the number of vowels.
         *
            * Example:
            *   Input: "hello"
            *   Output: 2
         *
            * @param str - Input string
            * @returns Number of vowels
         */
        public int CountVowels(string str)
        {
            int count = 0;
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            foreach (var item in str)
                if (vowels.Contains(char.ToLowerInvariant(item))) count++;

            return count;

            // ToLowerInvariant() → data processing, programming logic, parsing, comparisons.This is usually the safer default.
            // ToLower() → when formatting text for people according to their language and culture.
        }
        /**
            * Given a string,
            * determine whether it is a palindrome.
         *
            * Example:
            *   Input: "racecar"
            *   Output: true
         *
            * @param str - Input string
            * @returns True if palindrome, otherwise false
         */
        public bool IsPalindrome(string str)
        {
            Stack<char> stack = new Stack<char>(str);

            foreach (var c in str)
            {
                if (stack.Pop() != c) return false;
            }
            return true;
            // Time O(n)
            // Space O(n)
        }
        public bool IsPalindrome2(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {

                if (str[left] != str[right]) return false;
                left++;
                right--;
            }

            return true;
            // Time O(n)
            // Space O(1)
        }
        /**
            * Given an array of integers,
            * reverse the array.
         *
            * Example:
            *   Input: [1,2,3,4]
            *   Output: [4,3,2,1]
         *
            * @param nums - Array of integers
            * @returns Reversed array
         */
        public int[] ReverseArray(int[] nums)
        {
            //add to Stack and pop (O(n+2))
            //add to and othe array(t:O(n^2) s:O(n)) Bad
            //add revesed to othe array(t:O(n) s:O(n)) Bad
            int[] result = new int[nums.Length];
            for (int i = 0; i < result.Length; i++)
                result[i] = nums[nums.Length - i - 1];

            return result;
        }

        //Easy-Medium
        /**
            * Given an array of integers,
            * find the second largest number.
         *
            * Example:
            *   Input: [4, 2, 7, 9, 1]
            *   Output: 7
         *
            * @param nums - Array of integers
            * @returns Second largest number
         */
        public int SecondLargest(int[] nums)
        {
            int secMax = int.MinValue;
            int max = int.MinValue;

            foreach (int i in nums)
            {
                if (max < i)
                {
                    secMax = max;
                    max = i;
                }
                else if (secMax < i && max != i)
                    secMax = i;

            }
            return secMax;
            // Time: O(n) 
            // Space: O(1) 
        }
        /**
            * Given an array of integers,
            * remove duplicate values.
         *
            * Example:
            *   Input: [1,1,2,2,2,3,4]
            *   Output: [1,2,3,4]
         *
            * @param nums - Array of integers
            * @returns Array without duplicates
         */
        public int[] RemoveDuplicates(int[] nums)
        {

            //HashSet<int> result = new HashSet<int>(nums);
            //return result.ToArray<int>();
            //if (seen.Add(num)) -> true → number wasn't in the set
            //Time: O(n)(average)
            //Space: O(n)


            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1]) result.Add(nums[i]);
            }
            return result.ToArray();
            //Time: O(n)
            //Space: O(n)(because you're returning a new array)
        }
        public int RemoveDuplicates2(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int write = 1;

            for (int read = 1; read < nums.Length; read++)
            {
                if (nums[read] != nums[read - 1])
                {
                    nums[write] = nums[read];
                    write++;
                }
            }

            return write;//new Length;
        }



        /**
            * Given two strings,
            * determine whether they are anagrams.
         *
            * Example:
            *   Input: "listen", "silent"
            *   Output: true
         *
            * @param first - First string
            * @param second - Second string
            * @returns True if anagrams
         */
        //public bool AreAnagrams(string first, string second) { }

        /**
            * Given an array of integers,
            * find the first repeating number.
         *
            * Example:
            *   Input: [2,5,1,2,3,5,1]
            *   Output: 2
         *
            * @param nums - Array of integers
            * @returns First repeated number
         */
        //public int FirstRepeatedNumber(int[] nums) { }
        /**
            * Given an array of integers,
            * move all zeros to the end while maintaining order.
         *
            * Example:
            *   Input: [0,1,0,3,12]
            *   Output: [1,3,12,0,0]
         *
            * @param nums - Array of integers
            * @returns Modified array
         */
        //public int[] MoveZeros(int[] nums) { }

        //Medium
        /**
            * Given an array of integers,
            * find the longest consecutive sequence length.
         *
            * Example:
            *   Input: [100,4,200,1,3,2]
            *   Output: 4
            *   Explanation: [1,2,3,4]
         *
            * @param nums - Array of integers
            * @returns Length of longest sequence
         */
        //public int LongestConsecutive(int[] nums) { }
        /**
            * Given a string,
            * find the first non-repeating character.
         *
            * Example:
            *   Input: "aabbcdde"
            *   Output: 'c'
         *
            * @param str - Input string
            * @returns First unique character
         */
        //public char FirstUniqueCharacter(string str) { }
        /**
            * Given an array of integers and a target,
            * determine if any pair sums to the target.
         *
            * Example:
            *   Input: [1,2,4,4], target = 8
            *   Output: true
         *
            * @param nums - Array of integers
            * @param target - Target sum
            * @returns True if pair exists
         */
        //public bool HasPairWithSum(int[] nums, int target) { }
        /**
            * Given a string,
            * return the longest substring without repeating characters.
         *
            * Example:
            *   Input: "abcabcbb"
            *   Output: "abc"
         *
            * @param str - Input string
            * @returns Longest unique substring
         */
        //public string LongestUniqueSubstring(string str) { }
        /**
            * Given an array of integers,
            * find all pairs with difference K.
         *
            * Example:
            *   Input: [1,5,3,4,2], k = 2
            *   Output: 3
            *   Explanation: (1,3), (3,5), (2,4)
         *
            * @param nums - Array of integers
            * @param k - Difference value
            * @returns Number of pairs
         */
        //public int CountPairsWithDifference(int[] nums, int k) { }
        //Medium Hard
        /**
            * Given an array of integers,
            * return the majority element.
         *
            * Example:
            *   Input: [2,2,1,1,1,2,2]
            *   Output: 2
         *
            * @param nums - Array of integers
            * @returns Majority element
         */
        //public int MajorityElement(int[] nums) { }
        /**
            * Given a string,
            * find the longest palindromic substring.
         *
            * Example:
            *   Input: "babad"
            *   Output: "bab"
         *
            * @param str - Input string
            * @returns Longest palindrome substring
         */
        //public string LongestPalindrome(string str) { }
        /**
            * Given an array of integers,
            * find the maximum sum subarray.
         *
            * Example:
            *   Input: [-2,1,-3,4,-1,2,1,-5,4]
            *   Output: 6
            *   Explanation: [4,-1,2,1]
         *
            * @param nums - Array of integers
            * @returns Maximum subarray sum
         */
        //public int MaxSubArray(int[] nums) { }
        /**
            * Given an array of integers,
            * find the product of all elements except self.
         *
            * Example:
            *   Input: [1,2,3,4]
            *   Output: [24,12,8,6]
         *
            * @param nums - Array of integers
            * @returns Product array
         */
        //public int[] ProductExceptSelf(int[] nums) { }

        //Hard
        /**
            * Given an array of integers,
            * find the median of the array without sorting the entire array.
         *
            * Example:
            *   Input: [3,2,1,5,6,4]
            *   Output: 3.5
         *
            * @param nums - Array of integers
            * @returns Median value
         */
        //public double FindMedian(int[] nums) { }
        /**
            * Given a string and a dictionary of words,
            * determine whether the string can be segmented
            * into valid dictionary words.
         *
            * Example:
            *   Input: "leetcode"
            *   Dictionary: ["leet", "code"]
            *   Output: true
         *
            * @param str - Input string
            * @param words - Dictionary words
            * @returns True if segmentation exists
         */
        //public bool WordBreak(string str, string[] words) { }
        /**
            * Given an array of integers,
            * find the length of the longest increasing subsequence.
         *
            * Example:
            *   Input: [10,9,2,5,3,7,101,18]
            *   Output: 4
         *
            * @param nums - Array of integers
            * @returns Length of LIS
         */
        //public int LongestIncreasingSubsequence(int[] nums) { }
        /**
            * Given a matrix of integers,
            * find the shortest path from top-left to bottom-right.
         *
            * Example:
            *   Input:
            *   [
            *     [0,0,0],
            *     [1,1,0],
            *     [0,0,0]
            *   ]
         *
            * @param grid - Matrix
            * @returns Length of shortest path
         */
        //public int ShortestPath(int[][] grid) { }
        /**
            * Implement an LRU (Least Recently Used) Cache.
         *
            * Example:
            *   Put(1,1)
            *   Put(2,2)
            *   Get(1) => 1
            *   Put(3,3)
            *   Get(2) => -1
         *
            * @param capacity - Cache size
         */
        //public class LRUCache
        //{
        //public LRUCache(int capacity) { }
        //public int Get(int key) { }
        //public void Put(int key, int value) { }
        //}

    }
}

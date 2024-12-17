using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOccurrence
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string haystack1 = "sadbutsad";
            string needle1 = "sad";
            int result1 = solution.StrStr(haystack1, needle1);
            Console.WriteLine($"Input: haystack = \"{haystack1}\", needle = \"{needle1}\""); 
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine($"Explanation: \"{needle1}\" occurs at index 0 and 6 in \"{haystack1}\". The first occurrence is at index {result1}.\n");


            string haystack2 = "leetcode";
            string needle2 = "leeto";
            int result2 = solution.StrStr(haystack2, needle2);
            Console.WriteLine($"Input: haystac = \"{haystack1}\", needle = \"{needle2}\"");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine($"Explanation: \"{needle2}\"  did not occur in \"{haystack2}\", so we return {result2}.\n");

            Console.ReadKey();

        }

        public class Solution
        {
            public int StrStr(string haystack, string needle)
            {
                if (needle.Length == 0) return 0;

                for (int i = 0; i <= haystack.Length - needle.Length; i++)
                {
                    if (haystack.Substring(i, needle.Length) == needle)
                    {
                        return i;
                    }
                }

                return -1;
            }

        }
    }
}

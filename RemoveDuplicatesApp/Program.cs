using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesApp
{

    public class Solution
    {

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int uniqueIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[uniqueIndex])
                {
                    uniqueIndex++;
                    nums[uniqueIndex] = nums[i];
                }
            }
            return uniqueIndex + 1;
        }

        static void Main(string[] args)
        {
            Solution solution = new Solution();

  
            Console.WriteLine("Example 1:");
            int[] nums1 = { 1, 1, 2 };
            Console.WriteLine("Input: " + string.Join(", ", nums1));
            int k1 = solution.RemoveDuplicates(nums1);
            Console.WriteLine($"Output: {k1}, nums = [{string.Join(", ", nums1.Take(k1))}]");

            
            Console.WriteLine("\nExample 2:");
            int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine("Input: " + string.Join(", ", nums2));
            int k2 = solution.RemoveDuplicates(nums2);
            Console.WriteLine($"Output: {k2}, nums = [{string.Join(", ", nums2.Take(k2))}]");

            Console.ReadKey();
        }
    }
}

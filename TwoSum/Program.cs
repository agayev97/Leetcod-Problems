using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;
            Solution solution1 = new Solution();
            int[] result1 = solution1.TwoSum(nums1, target1);
            Console.WriteLine("nums1 =  " + string.Join(", ", nums1));
            

            if(result1.Length > 0)
            {
                Console.WriteLine($"Result for Test Case 1: [{result1[0]}, {result1[1]}]");
                Console.WriteLine("Sum1 = " + target1);

            }
            else
            {
                Console.WriteLine("No solution found.");
            }
            

           
            int[] nums2 = { 3, 2, 4 };
            int target2 = 6;
            Solution solution2 = new Solution();
            int[] result2 = solution2.TwoSum(nums2, target2);
            Console.WriteLine("nums2 = " + string.Join(", ", nums2));

            if (result1.Length > 0)
            {
                Console.WriteLine($"Result for Test Case 2: [{result2[0]}, {result2[1]}]");
                Console.WriteLine("Sum2 = " + target2);

            }
            else
            {
                Console.WriteLine("No solution found.");
            }


            int[] nums3 = { 3, 3 };
            int target3 = 6;
            Solution solution3 = new Solution();
            int[] result3 = solution3.TwoSum(nums3, target3);
            Console.WriteLine("nums3 = "  + string.Join(", ", nums3));

            if (result1.Length > 0)
            {
                Console.WriteLine($"Result for Test Case 3: [{result3[0]}, {result3[1]}]");
                Console.WriteLine("Sum3 =  " + target3);

            }
            else
            {
                Console.WriteLine("No solution found.");
            }

            Console.ReadKey();

        }
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
                return new int[0];
            }
        }
    }
}

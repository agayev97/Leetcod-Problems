using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Example 1:");
            int[] nums1 = { 3, 2, 2, 3 };
            int val1 = 3;

            Console.WriteLine("Orginal arry: " + string.Join(", ", nums1));
            Solution solution = new Solution();
            int newLength1 = solution.RemoveElement(nums1, val1);

            Console.WriteLine("New array:" + string.Join(", ", nums1.Take(newLength1)));
            Console.WriteLine("New length: " + newLength1);

            Console.WriteLine("\nExample 2:");
            int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val2 = 2;

            Console.WriteLine("Orginal arry: " + string.Join(", ", nums2));
            int newLength2 = solution.RemoveElement(nums2, val2);

            Console.WriteLine("New array: " + string.Join(", ", nums2.Take(newLength2)));
            Console.WriteLine("New length: " + newLength2);

            Console.ReadKey();


        }

        public class Solution { 
            public int RemoveElement(int[] nums, int val)
            {
                int newIndex = 0;

                for(int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != val)
                    {
                        nums[newIndex] = nums[i];
                        newIndex++;
                    }
                }

                return newIndex;
            }
        
        }

    }
}

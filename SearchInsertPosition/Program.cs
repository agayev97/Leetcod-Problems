using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    internal class Program
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while(left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                    right = mid - 1;
            }
            return left;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 5;


            Console.WriteLine("Nums: [" + string.Join(", ", nums) + "]");
            Console.WriteLine("Target: " + target);
            Console.WriteLine("Insert Position: " + SearchInsert(nums, target));
            Console.WriteLine("\n");

            target = 2;
            Console.WriteLine("Target: " + target);
            Console.WriteLine("Insert Position: " + SearchInsert(nums, target));
            Console.WriteLine("\n");

            target = 7;
            Console.WriteLine("Target: " + target);
            Console.WriteLine("Insert Position: " + SearchInsert(nums, target));


            Console.ReadKey();


        }
    }
}

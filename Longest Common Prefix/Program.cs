using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            string[] strs1 = { "flower", "flow", "flight" };
            Console.WriteLine("Longest Common Prefix: " +program.LongestCommonPrefix(strs1));

            string[] strs2 = { "dog", "racecar", "car" };
            Console.WriteLine("Longest Common Prefix: " + program.LongestCommonPrefix(strs2));

            Console.ReadKey();
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            string prefix = strs[0];

            for(int i =1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if(prefix == "")
                    {
                        return "";
                    }
                }
            }
            return prefix;

        }
    }  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            string strX = x.ToString();
            for (int i = 0; i < strX.Length / 2; i++) 
            {
                if (strX[i] != strX[strX.Length - 1 -i])
                    return false;
            }
            return true;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string continueProgram;

            do
            {
                Console.WriteLine("Bir eded daxil edin");
                int a;

                while (!int.TryParse(Console.ReadLine(), out a)) ;
                {
                    Console.WriteLine();
                }

                bool result = solution.IsPalindrome(a);

                if (result)
                    Console.WriteLine($"{a}  palindromdur.");

                else
                    Console.WriteLine($"{a} palindrom deyil.");


                Console.WriteLine("Yeniden eded daxil etmek isteyirsinizmi? (beli/xeyir)");
                continueProgram = Console.ReadLine().ToLower();
            } while (continueProgram == "beli");

            Console.WriteLine("Proqramdan çıxılır. Sağ olun");
            Console.ReadKey();
        }
        
    }

}

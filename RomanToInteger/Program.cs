using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Rum reqemini daxil edin (çıxış üçün 'exit' yazin):");
                string romanInput = Console.ReadLine();

                if (romanInput.ToLower() == "exit")
                {
                    Console.WriteLine("Proqramdan çıxılır. Sağ olun!");
                    break;
                }



                try
                {
                    int result = RomanToInt(romanInput);
                    Console.WriteLine($"Tam eded deyeri: {result}");
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Xəta: {ex.Message}");
                }
                Console.ReadKey();
            }

        }

        public static int RomanToInt(string s)
        {
            var romanMap = new Dictionary<char, int>
            {

                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }

            };

            int total = 0;
            
            for(int i =0; i<s.Length; i++)
            {
                if(i + 1 < s.Length && romanMap[s[i]] < romanMap[s[i+1]])
                {
                    total -= romanMap[s[i]];
                }
                else
                {
                    total += romanMap[s[i]];
                }

            }
            return total;
        }
    }
}


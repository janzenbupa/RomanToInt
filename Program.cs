using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanToInt
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a roman numeral:");
            var x = Console.ReadLine();
            Console.WriteLine(RomanInt(x.ToUpper()));
        }

        static int RomanInt(string x)
        {
            Dictionary<char, int> list = new Dictionary<char, int>
            {
                {'I',1 },{'V',5 },{'X',10 },{'L',50 },{'C',100 },{'D',500 },{'M',1000 }
            };

            int temp = 0;

            for (int i = 0; i <= x.Count() - 1; i++)
            {
                if (i + 1 < x.Length && list[x[i]] < list[x[i + 1]])
                {
                    temp -= list[x[i]];
                }

                else
                {
                    temp += list[x[i]];
                }
            }

            return temp;
        }
    }
}

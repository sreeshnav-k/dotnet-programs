using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int a ;
            int s = 0;
            int sum = 0;

            while (s <= 10)
            {
               a=Convert.ToInt32( Console.ReadLine());
                s++;
                sum += a;
            }

        }
    }
}

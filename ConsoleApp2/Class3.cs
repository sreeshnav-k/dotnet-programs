using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int a = 0;

            /*
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 10);

            */

            //while loop

            /*
             while(a<10)             //for while loop no semi colon
                                       //for do while semi is needed as it ids outside the loop
            {
            cosole.writeline(a);
            a++
            }
            */

            //-----------For loop--------------------


                for(a=0;a<10;a++)
            {
                Console.WriteLine(a);
            }
        }
    }
}

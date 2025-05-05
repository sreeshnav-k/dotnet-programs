using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int a;
            int s = 0;
            int c = 0;
            int b = 0;


            while (s <= 10)
            {
                a = Convert.ToInt32(Console.ReadLine());
                s++;
                if (a % 2 == 0)
                {
                    c++;
                }
                else 
                        {
                    b++;

                }
            }

            Console.WriteLine("no of odd" + c);
            Console.WriteLine("no of even" + b);
        }
    }
}
    
            
  

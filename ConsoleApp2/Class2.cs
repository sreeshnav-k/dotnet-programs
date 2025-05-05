using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class2
    {
        public void checkevenodd()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the no is odd");
            }
        }
        static void Main(string[] args)
        {
            Class2 c = new Class2();
            c.checkevenodd();
        }
    }
}



    


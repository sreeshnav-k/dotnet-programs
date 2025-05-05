using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class polys
    {
        public void calc()
        {
            Console.WriteLine("calling the first calc function");
        }
            public void calc(string a)
        { 
            Console.WriteLine("the value of A"+a);

        }
        public bool calc(int b)
        { 
          
            if (b < 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int calc(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            polys p=new polys();
            p.calc();
            Console.WriteLine("enter name");
            string s = Console.ReadLine();
            p.calc(s);
            Console.WriteLine("enter a no");
            int x=Convert.ToInt32(Console.ReadLine());
            bool c;
            c=p.calc(x);
            Console.WriteLine("its" + c);
            Console.WriteLine("enter  1 st no");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd no");
            int z = Convert.ToInt32(Console.ReadLine());
           
            int sum=p.calc(y,z);
            Console.WriteLine("the sum is" + sum);
        }
    }
}

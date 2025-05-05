using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
        abstract class shapes
        {
            public abstract void areas();
            public void showdata()
            {
                System.Console.WriteLine("show function");
            }
        }
        class circles : shapes
        {
            public override void areas()
            {
                int r;
                const double pi = 3.14 ;
            Console.WriteLine("enterb radius");
            r= Convert.ToInt32(Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine("area"+area);
            }
        }
    class rectangles : shapes
    {
        public override void areas()
        {
            int l;
            int b;
            
            
        }
    }
    internal class abstracts
    {
        static void Main(string[] args)
        {
            circles c = new circles(); 
            c.areas();
            c.showdata();
        }
    }
    
}

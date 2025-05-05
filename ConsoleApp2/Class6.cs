using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp2
{
     class Class6
    {
        protected string color="red";

        static void Main(string[] args)
        {
            program2 x = new program2();
            Console.WriteLine("brand" + x.brand);
            x.show();

            Console.WriteLine("color" + x.color);
        }
    }

    class program2 : Class6
    {
        public string brand = "xyz";

        public void show()
        {
            Console.WriteLine("showing things");

        }
        
    }
}

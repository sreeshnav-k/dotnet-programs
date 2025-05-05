using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("both are equal");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("a is greater");

                }
                else { 
             
                    Console.WriteLine("b is greater");
                }
            } 
            }
           
           
        }
    }


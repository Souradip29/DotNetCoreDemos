using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the value of a: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b: ");
            b= Convert.ToInt32(Console.ReadLine());           
            if (a  > b)
            {
                while (a >= b)
                {
                    a -= b;
                }
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}

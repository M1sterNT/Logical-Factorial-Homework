using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Factorial_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Fac : ");
            int fac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum  :" + Factorial(fac));
            Console.ReadLine();
        }
        static int Factorial(int fac) {
            if (fac == 1 || fac == 0)
            {
                return 1;
            }
            else
            {
                return fac * Factorial(fac - 1);
            }
            
        }
    }
}

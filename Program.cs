using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    class Program
    {
        public static double findfactor(double input)
        {
            double sum = 0;
            for (double i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    sum = sum + i;
                }

            }

            return sum;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Start Number");

            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter The End Number");

            double n2 = double.Parse(Console.ReadLine());

            for (double i = n1; i < n2; i++)
            {
                double result = findfactor(i);
                if (i == result)
                {
                    Console.WriteLine(i + " is a perfect number");
                }
            }

            Console.ReadKey();
        }

}   }

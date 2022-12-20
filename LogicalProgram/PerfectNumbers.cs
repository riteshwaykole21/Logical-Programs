using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumbers
    {
        public static void PerfectNum()
        {
            int number,n;
            int sum = 0;
            
            Console.WriteLine("Enter the number :");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
                if (sum == n)
                {
                    Console.WriteLine("\n Enter number is perfect number ");
                }
                else
                {
                    Console.WriteLine("\n Enter number is not a perfect number ");
                }
            
        }
    }
}

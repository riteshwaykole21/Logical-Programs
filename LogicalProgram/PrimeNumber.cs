using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrimeNumber
    {
        public static void PrimeNum()
        {
            int n;
            int i;
            int m=0;
            int flag =0;
            Console.WriteLine("Enter the number to check to prime");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for(i = 2; i <= m; i++)
            {
                if(n%i ==0)
                {
                    Console.WriteLine("Number is not a Prime");
                    flag = 1;
                    break;
                }
            }
                    if (flag == 0)
                    Console.WriteLine("Number is a prime");
        }
    }
}

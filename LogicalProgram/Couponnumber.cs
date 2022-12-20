using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Couponnumber
    { 
        public static void displayCoupnNum()
        {

            int n;
            Console.WriteLine("how many coupon numbers are required ?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("genrated coupon number");
            for ( int i = 0; i < n; i++)
            {
                Random number = new Random();
                int coupon = number.Next(10000, 100000);
                Console.WriteLine(coupon);
            }
        }
    }
}

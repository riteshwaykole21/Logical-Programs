using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNumbers
    { 
        public static void DisplayReverseNum()
        {
            int n;
            int reverse = 0;
            int rem;
            Console.WriteLine("enter a number :");
            n = Convert.ToInt32(Console.ReadLine());
            while(n!= 0)
            {
                rem = n % 10;
                reverse=reverse*10+rem;
                n/=10;  
            }
            Console.WriteLine("reverse Number:" + reverse);
        }
    }
}

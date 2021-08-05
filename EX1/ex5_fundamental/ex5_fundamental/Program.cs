using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex5_fundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int n= Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp;
        
            while(n!=0)
            {
                 temp = n % 10;
                n = n / 10;
                sum = sum * 10 + temp;
            }
            Console.WriteLine("The number in reverse order is : " +sum);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex3
{
    class ex3
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (y == 0)
            {
                Console.WriteLine("You cannot divide by 0");
                return;
            }
            int division = x / y;
            int rest = x % y;
            Console.WriteLine("The division is "+division);
            Console.WriteLine("The rest is "+rest);
            Console.ReadLine();
        }
    }
}

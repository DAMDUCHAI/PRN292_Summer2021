using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex2
{
    class ex2
    {
        static void Main(string[] args)
        {
            int i =1;
            while (i <= 500)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex1
{
    class ex1

    {

        public static int Sum(int x)
        {
         
            return (x*x)-(2*x)+1;
        }
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            for(int i = from; i <= to; i++)
            {
                Console.Write(Sum(i)+"  ");
            }
            Console.ReadKey();




        }
    }
}

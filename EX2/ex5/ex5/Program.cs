using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex5
{
    class ex5
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x >= y)
            {
                Console.Write("x must than y");
                return;
            }
            do
            {
                Console.Write(x+" ");
                        x++;
            } while (x<=y);
            Console.ReadLine();

        }
    }
}

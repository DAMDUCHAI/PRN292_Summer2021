using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex6
{
    class ex6
    {
        static void Main(string[] args)

        {
            int[] arr = new int[5];
            int sum = 0;
            int max =0,min=0;
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
               
           
            }
            double arithmetic = sum / 5;
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < 5; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }

            }
                Console.WriteLine("-The sum of the 5 numbers "+ sum);
            Console.WriteLine("-The arithmetic mean " + arithmetic);
            Console.WriteLine("-The maximum number " + max);
            Console.WriteLine("-The minimum number " + min);
            Console.ReadLine();
        }
    }
}

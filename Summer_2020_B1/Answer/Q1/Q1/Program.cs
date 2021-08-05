using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Q1
{
    class Program
    {
        static bool checkCode(string code)
        {
            Regex reg = new Regex(@"^[a-zA-z]{2}\d{6}$");
            if (reg.IsMatch(code))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string inputCode()
        {
            string s = null;
            do
            {
                Console.WriteLine("New Code :");
                s = Console.ReadLine();
                if (checkCode(s) == false)
                {
                    Console.WriteLine("The student's code is not in the right format");
                    Console.WriteLine("Input again,pls.");
                    continue;
                }
                else
                {
                    return s;
                }
            } while (true); ;
            
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s.ToString());
            while (true)
            {
                Console.WriteLine("\nInfut new infor for student:");
                try
                {
                    
                    s.Code = inputCode(); 
                    Console.WriteLine("New Name :");
                    s.Name = Console.ReadLine();
                    Console.WriteLine("New DOB :");
                    s.Dob = Convert.ToDateTime(Console.ReadLine()) ;
                    break;
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
               
            }
            Console.WriteLine(s.ToString());
            Console.ReadLine();
        }
    }
}

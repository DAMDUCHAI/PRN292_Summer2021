using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    class Student
    {
        private string code;
        private string name;
        private DateTime dob;

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Dob { get => dob; set => dob = value; }

        public Student(string code, string name, DateTime dob)
        {
            this.code = code;
            this.name = name;
            this.dob = dob;
        }

        public Student()
        {
            code = "HE141462";
            name = "Dam Duc Hai";
            dob = DateTime.Parse("4/5/2000") ;
        }

        public override string ToString()
        {
            return "Student infor :\n Code :" +code+" ,Name :"+name +",DOB :"+dob;
        }
    }
}

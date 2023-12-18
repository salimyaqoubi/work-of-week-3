using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace week3_day09
{
    class Employee
    {
        //class members 

        public int id;
        public string FName;
        public string LName;
        public int age;
        public decimal salary;
        public int loggedHour;
        public int wage;

        public Employee(int _id, string _FName, string _LName, int _age)
        {
            id = _id;
            FName = _FName;
            LName = _LName;
            age = _age;

            //Console.WriteLine($ 'emp with id {id} is Created ');
        }
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day11
{
    internal class Employee
    {
        int Id;

        private string Fname;
        private string Lname;
        private int age;
        private string address;
        
        public Employee() { }

        public Employee(string Fname, string Lname, int age, string address)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.age = age;
            this.address = address;
            

        }   


        public string Fname()
        {
            get { return this.Fname; }
        }

        private string GetFname() => this.Fname;
        private string GetLname() => this.Lname;
        private string GetFname() => this.Fname;
        private string GetFname() => this.Fname;




    }
}

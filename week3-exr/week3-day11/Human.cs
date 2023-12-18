using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day11
{
    internal class Human
    {
        int cnt = 0;

        private int id;
        private string name;
        private int age;
        private string address;
        private string email;

        public Human()
        {

        }

        public Human(string name, int age, string address, string email)
        {
            cnt += 1;
            this.id = id;
            this.name = name;
            this.age = age;
            //this.age = validateage() ? age : 0;
            this.address = address;
            this.email = email;
        }

        public string Greatingbyname() => $"Hello {this.name} \n" + $"your email address: {this.email}\n"
            + $"Your age is: {this.age}\n" + $"Yor are from: {this.address}";




        public int Name()
        {
            set { name = value; }
            get { return name; }
        }
        public int Age()
        {
            set{ age = value; }
            get { return age; }
        }

        public int Address()
        {
            set{ address = value; }
            get { return address; }
        }

        public int Email()
        {
            set{ email = value; }
            get { return email; }
        }

        //public bool validateage(int age)
        //{
        //if (age <= 0 || age >= 10)
        //    {
        //        return false;
        //    }
        //return true;
        //}


        //public static void calculate(int x, int y, out int)
        //{

        //}


    }
    
}

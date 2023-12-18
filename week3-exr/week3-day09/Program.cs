using System.Runtime.InteropServices;

namespace week3_day09
{
    class program
    {
        static decimal CalculateNetSalary(int loggedHour, int wage)
        {
            int totalsalary = loggedHour * wage;
            decimal textCalculated = (decimal)totalsalary * 0.03m;
            decimal total = totalsalary - textCalculated;
            return total;
        }
       


            static void Main(string[] args)
            {
              Employee emp1 = new Employee(1, "akram", "juma", 27);
              Employee emp2 = new Employee(2, "salim", "juma", 22);
              Employee emp3 = new Employee(3, "nader", "saeed", 23);
              Employee[] employees = { emp1, emp2, emp3 };

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"Hello Mr {emp.FName} {emp.LName} \n that has id: {emp.id} with age is {emp.age} ");
            }





           // Employee emp1 = new Employee()
                Console.WriteLine("Hello to our system: ");
                emp1.id = 1;

                Console.WriteLine("please enter employee first name: ");
                emp1.FName = Console.ReadLine();

                Console.WriteLine("please enter employee last name: ");
                emp1.LName = Console.ReadLine();

                Console.WriteLine("please enter your age: ");
                emp1.age = int.Parse(Console.ReadLine());

                Console.WriteLine("please enter your LoggedHours: ");
                emp1.loggedHour = int.Parse(Console.ReadLine());

               Console.WriteLine("please enter employee wage : ");
               emp1.wage = int.Parse(Console.ReadLine());

               emp1.salary = CalculateNetSalary(emp1.loggedHour, emp1.wage);
               Console.WriteLine($"Hello Emp: {emp1.FName} {emp1.LName} your age is: {emp1.age} your wage is: {emp1.wage} your logged hours: {emp1.loggedHour} so your nesalary is {emp1.salary}" );
        }
        }
    }

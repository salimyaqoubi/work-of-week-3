using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Orgnization
{
    internal class Employee : Human
    {
        public string Role { get; set; }
        public string Department { get; set; }
        public int WorkingHours { get; set; }
        public int Wage { get; set; }


        public void Employee(string Role, string Department, string WorkingHours)
        {

            this.Role = Role;
            this.Department = Department;
            this.WorkingHours = WorkingHours;
        }
        public override void Describe()
        {
            base.Describe();
            Console.WriteLine($"Role: {this.Role}," +
                $" Department: {this.Department}, " +
                $"Working Hours: {this.WorkingHours}, " +
                $"Wage: {this.Wage}");
        }

        public void CalculateSalary()
        {
            // Your salary calculation logic goes here
            Console.WriteLine($"Salary calculated for {this.Name}");
        }


    }


    
   

    public void Employee(string Role, string Department, string WorkingHours)
    {
        
        this.Role = Role;
        this.Department = Department;
        this.WorkingHours = WorkingHours;
    }
        public override void Describe()
        {
            base.Describe();
            Console.WriteLine($"Role: {this.Role}," +
                $" Department: {this.Department}, " +
                $"Working Hours: {this.WorkingHours}, " +
                $"Wage: {this.Wage}");
        }

        public void CalculateSalary()
        {
            // Your salary calculation logic goes here
            Console.WriteLine($"Salary calculated for {this.Name}");
        }
    
}

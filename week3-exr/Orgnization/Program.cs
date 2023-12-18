namespace Orgnization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Id = 1,
                Name = "John",
                HasJob = false,
                Age = 20,
                IsMarried = false,
                Qualification = "High School",
                IsIntern = true,
                TotalGrade = 90,
                StudyingHours = 25
            };

            Employee employee = new Employee
            {
                Id = 2,
                Name = "Alice",
                HasJob = true,
                Age = 30,
                IsMarried = true,
                Role = "Developer",
                Department = "IT",
                WorkingHours = 40,
                Wage = 50000
            };

            Console.WriteLine("Student Information:");
            student.Describe();

            Console.WriteLine("\nEmployee Information:");
            employee.Describe();
            employee.CalculateSalary();
        }
    }
}
    }
}
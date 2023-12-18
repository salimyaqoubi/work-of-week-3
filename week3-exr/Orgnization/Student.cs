using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orgnization
{
    internal class Student : Human
    {
        public string Qualification { get; set; }
        public bool IsIntern { get; set; }
        public int TotalGrade { get; set; }
        public int StudyingHours { get; set; }


    }


    public string Student(string Qualification, bool IsIntern, int TotalGrade, int StudyingHours)
    {
        this.Qualification = Qualification;
        this.IsIntern = IsIntern;
        this.TotalGrade = TotalGrade;

    }
    public override void Describe()
    {
        base.Describe();
        Console.WriteLine($"Qualification: {this.Qualification}," +
            $" Is Intern: {this.IsIntern}," +
            $" Total Grade: {this.TotalGrade}," +
            $" Studying Hours: {this.StudyingHours}");
    }
}

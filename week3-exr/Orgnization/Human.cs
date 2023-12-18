using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Orgnization
{
    internal class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasJob { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
    }

    

    public string Human(int )
    {

    }
    public virtual void Describe()
    {
        Console.WriteLine($"ID: {this.Id}, " +
            $"Name: {this.Name}, " +
            $"Has Job: {this.HasJob}, " +
            $"Age: {this.Age}, " +
            $"Is Married: {this.IsMarried}");
    }

}

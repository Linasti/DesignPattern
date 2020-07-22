using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public int Salary { get; set; }

        public string Dept { get; set; }

        public List<Employee> Subordinates { get; set; }
    }
}

using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Factory.Interfaces;
using DesignPattern.Factory.Models;
using DesignPattern.Factory;
using DesignPattern.Composite.Models;

namespace DesignPattern.Test.Factory
{
    [TestFixture]
    public class EmployeeCompositeTest
    {
        Employee Jul;
        Employee Yan;
        Employee Ma;
        Employee Lo;
        Employee Emi;
        Employee Adr;
        Employee Bap;
        Employee Vin;
        Employee Chris;

        List<Employee> Employees;

        [SetUp]
        public void Initialize()
        {
            Jul = new Employee { Name = "Jul", LastName = "SomeOne", Dept = "CTO My Ass", Salary = 1000000 };
            Yan = new Employee { Name = "Yan", LastName = "SomeBody", Dept = "Ultra Manager of shit", Salary = 80000 };
            Ma = new Employee { Name = "Ma", LastName = "Capi", Dept = "Scrum?", Salary = 45000 };
            Lo = new Employee { Name = "Lo", LastName = "NO SE", Dept = "Old Perf Infra Guy ", Salary = 70000 };
            Emi = new Employee { Name = "Emi", LastName = "", Dept = "LeadDev", Salary = 20000 };
            Adr = new Employee { Name = "Adr", LastName = "", Dept = "LeadDev", Salary = 20000 };
            Bap = new Employee { Name = "Bap", LastName = "", Dept = "Dev Presta", Salary = 20000 };
            Vin = new Employee { Name = "Vin", LastName = "", Dept = "Dev in reflection", Salary = 20000 };
            Chris = new Employee { Name = "Chris", LastName = "", Dept = "Another dev in reflection", Salary = 15000 };

            Jul.Subordinates = new List<Employee>();
            Jul.Subordinates.Add(Yan);
            Jul.Subordinates.Add(Ma);
            Jul.Subordinates.Add(Lo);
            Jul.Subordinates.Add(Emi);
            Jul.Subordinates.Add(Adr);
            Jul.Subordinates.Add(Vin);
            Jul.Subordinates.Add(Chris);

            Yan.Subordinates = new List<Employee>();
            Yan.Subordinates.Add(Ma);
            Yan.Subordinates.Add(Lo);

            Ma.Subordinates = new List<Employee>();
            Ma.Subordinates.Add(Emi);
            Ma.Subordinates.Add(Adr);
            Ma.Subordinates.Add(Bap);
            Ma.Subordinates.Add(Vin);
            Ma.Subordinates.Add(Chris);

            Employees = new List<Employee>();
            Employees.Add(Jul);
            Employees.Add(Yan);
            Employees.Add(Ma);
            Employees.Add(Lo);
            Employees.Add(Emi);
            Employees.Add(Adr);
            Employees.Add(Vin);
            Employees.Add(Chris);
        }

        [Test]
        public void EmployeeTest()
        {
            Assert.AreEqual(7, Jul.Subordinates.Count);
            Assert.AreEqual(1000000, Jul.Salary);
            Assert.IsTrue(Employees.Any(e => e.Subordinates == null || e.Subordinates.Any(s => s.Name == "Jul")));
        }
    }
}

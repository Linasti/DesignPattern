using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Filter.Criteria;
using DesignPattern.Filter.Models;
using DesignPattern.Filter.Interfaces;

namespace DesignPattern.Test.Filter
{
    [TestFixture]
    public class FilterTest
    {
        private List<Person> persons;
        ICriteria male ;
        ICriteria female;
        ICriteria single;
        ICriteria singleMale;
        ICriteria singleOrFemale;


        [SetUp]
        public void init()
        {
            persons = new List<Person>
                {
                    new Person("Robert", "Male", "Single"),
                    new Person("John", "Male", "Married"),
                    new Person("Laura", "Female", "Married"),
                    new Person("Diana", "Female", "Single"),
                    new Person("Mike", "Male", "Single"),
                    new Person("Bobby", "Male", "Single")
                };
            male = new CriteriaMale();
            female = new CriteriaFemale();
            single = new CriteriaSingle();
            singleMale = new AndCriteria(single, male);
            singleOrFemale = new OrCriteria(single, female);
        }


        [Test]
        public void TestMaleCriteria()
        {
            List<Person> malesList = male.MeetCriteria(persons);
            foreach (Person person in malesList)
            {
                Assert.AreEqual("Male",person.GetGender());
            }
        }

        [Test]
        public void TestFemaleCriteria()
        {
            List<Person> femalesList = female.MeetCriteria(persons);
            foreach (Person person in femalesList)
            {
                Assert.AreEqual("Female",person.GetGender());
            }
        }

        [Test]
        public void TestSingleMalCriteria()
        {
            List<Person> singleMalesList = singleMale.MeetCriteria(persons);
            foreach (Person person in singleMalesList)
            {
                Assert.AreEqual("Single",person.GetMaritalStatus());
                Assert.AreEqual("Male",person.GetGender());
            }
        }

        [Test]
        public void TestSingleOrFemalCriteria()
        {
            List<Person> singleOrFemalList = singleOrFemale.MeetCriteria(persons);
            foreach (Person person in singleOrFemalList)
            {
                Assert.True(person.GetMaritalStatus() == "Single" || person.GetGender() == "Female");
            }
        }

    }
}

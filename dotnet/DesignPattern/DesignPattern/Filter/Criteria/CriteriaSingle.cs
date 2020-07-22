using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Filter.Interfaces;
using DesignPattern.Filter.Models;

namespace DesignPattern.Filter.Criteria
{
    public class CriteriaSingle :ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach(Person person in persons) {
                if(person.GetMaritalStatus().ToUpper() == "SINGLE"){
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}

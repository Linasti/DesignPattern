using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Filter.Interfaces;
using DesignPattern.Filter.Models;

namespace DesignPattern.Filter.Criteria
{
    public class CriteriaFemale :ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach(Person person in persons) {
                if(person.GetGender().ToUpper() == "FEMALE"){
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}

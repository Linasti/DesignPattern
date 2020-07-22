using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Filter.Interfaces;
using DesignPattern.Filter.Models;

namespace DesignPattern.Filter.Criteria
{
    public class OrCriteria :ICriteria
    {
        private readonly ICriteria _criteria;
        private readonly ICriteria _otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
        }
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = _criteria.MeetCriteria(persons);
            List<Person> otherCriteriaItems = _otherCriteria.MeetCriteria(persons);

            foreach (Person person in otherCriteriaItems) {
                if(!firstCriteriaItems.Contains(person)){
                    firstCriteriaItems.Add(person);
                }
            }	
            return firstCriteriaItems;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Filter.Interfaces;
using DesignPattern.Filter.Models;

namespace DesignPattern.Filter.Criteria
{
    public class AndCriteria :ICriteria
    {
        private readonly ICriteria _criteria;
        private readonly ICriteria _otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
        }
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = _criteria.MeetCriteria(persons);		
            return _otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }
}

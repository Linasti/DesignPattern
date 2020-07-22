using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Filter.Models;

namespace DesignPattern.Filter.Interfaces
{
    public interface ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons);
    }
}

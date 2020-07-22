using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Filter.Models
{
    public class Person
    {
        
        private readonly string _name;
        private readonly string _gender;
        private readonly string _maritalStatus;

        public Person(string name, string gender, string maritalStatus){
            this._name = name;
            this._gender = gender;
            this._maritalStatus = maritalStatus;		
        }

        public string GetName() {
            return _name;
        }
        public string GetGender() {
            return _gender;
        }
        public string GetMaritalStatus() {
            return _maritalStatus;
        }	
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Iterator.Interfaces;

namespace DesignPattern.Iterator.Models
{
    public class NameContainer : Container
    {

        private readonly string[] _names;

        public NameContainer(string[] names)
        {
            _names = names;
        }

        public Interfaces.Iterator GetIterator()
        {
            return new NameIterator(_names);
        }

        private class NameIterator : Interfaces.Iterator
        {
            private int index;
            private string[] _names;

            public NameIterator(string[] names)
            {
                _names = names;
            }

            public bool HasNext()
            {
                return (index < _names.Length);
            }

            public object Next()
            {
                if(this.HasNext()){
                    return _names[index++];
                }
                return null;
            }
        }
    }
}

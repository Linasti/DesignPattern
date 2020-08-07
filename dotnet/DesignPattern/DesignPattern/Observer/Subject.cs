using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    public class Subject
    {
        private List<Interfaces.Observer> observers = new List<Interfaces.Observer>();
        private int _state;

        public int GetState()
        {
            return _state;
        }

        public string SetState(int state)
        {
            _state = state;
            return NotifyAllObservers();
        }

        public void Attach(Interfaces.Observer observer)
        {
            observers.Add(observer);
        }

        public string NotifyAllObservers()
        {
            string result = string.Empty;
            foreach (Interfaces.Observer observer in observers) {
                result += observer.Update()+ " ";
            }
            return result;
        } 	
    }
}

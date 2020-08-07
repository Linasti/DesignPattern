using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    public class User
    {
        private string _name;

        public User(string name)
        {
            SetName(name);
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public string SendMessage(string message)
        {
            return ChatRoom.ShowMessage(this, message);
        }
    }
}

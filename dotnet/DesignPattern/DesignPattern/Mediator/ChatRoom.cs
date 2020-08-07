using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    public class ChatRoom
    {
        public static string ShowMessage(User user, string message)
        {
            return $"{DateTime.Now.ToShortTimeString()} [{user.GetName()}] : {message}";
        }
    }
}

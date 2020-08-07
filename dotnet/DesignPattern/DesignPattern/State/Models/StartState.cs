using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State.Models
{
    public class StartState : Interfaces.State
    {
        public string DoAction(Context context)
        {
            context.SetState(this);
            return "Player is in start state";
        }

        public override string ToString()
        {
            return "Start State";
        }
    }
}

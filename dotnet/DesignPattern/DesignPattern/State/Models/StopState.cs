using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State.Models
{
    public class StopState : Interfaces.State
    {
        public string DoAction(Context context)
        {
            context.SetState(this);
            return "Player is in stop state";
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}

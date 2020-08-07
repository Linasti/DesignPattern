using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    public class Context
    {
        private Interfaces.State _state;

        public Context()
        {
            _state = null;
        }
        public void SetState(Interfaces.State state){
            _state = state;		
        }

        public Interfaces.State GetState(){
            return _state;
        }
    }
}

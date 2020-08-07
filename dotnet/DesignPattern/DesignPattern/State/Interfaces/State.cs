using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State.Interfaces
{
    public interface State
    {
        string DoAction(Context context);
    }
}

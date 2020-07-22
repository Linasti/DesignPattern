using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge.Interfaces
{
    public interface DrawAPI
    {
        public string DrawCircle(int radius, int x, int y);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Bridge.Interfaces;

namespace DesignPattern.Bridge.Models
{
    public class GreenCircle : DrawAPI
    {
        public string DrawCircle(int radius, int x, int y)
        {
            return $"Drawing Circle[ color: green, radius: {radius}, x: {x}, {y}]";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Bridge.Interfaces;

namespace DesignPattern.Bridge.Models
{
    public class RedCircle : DrawAPI
    {
        public string DrawCircle(int radius, int x, int y)
        {
            return $"Drawing Circle[ color: red, radius: {radius}, x: {x}, {y}]";
        }
    }
}

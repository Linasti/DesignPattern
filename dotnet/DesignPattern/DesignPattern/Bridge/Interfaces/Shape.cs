using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge.Interfaces
{
    public abstract class Shape
    {
        protected DrawAPI drawAPI;
   
        protected Shape(DrawAPI drawAPI){
            this.drawAPI = drawAPI;
        }
        public abstract string Draw();	
    }
}

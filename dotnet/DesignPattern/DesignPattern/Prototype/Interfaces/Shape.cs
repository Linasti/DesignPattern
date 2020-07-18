using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype.Interfaces
{
    public abstract class Shape: ICloneable
    {
        protected String Id;
        protected String Type;

        public abstract string Draw();
   
        public string GetShapeType(){
            return Type;
        }
   
        public string GetId() {
            return Id;
        }
   
        public void SetId(string id) {
            this.Id = id;
        }
        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}

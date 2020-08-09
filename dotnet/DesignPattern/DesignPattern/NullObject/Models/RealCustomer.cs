using DesignPattern.NullObject.Interfaces;

namespace DesignPattern.NullObject.Models
{
    public class RealCustomer: AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }

        public override bool IsNil()
        {
            return false;
        }

        public override string GetName()
        {
            return name;
        }
    }
}

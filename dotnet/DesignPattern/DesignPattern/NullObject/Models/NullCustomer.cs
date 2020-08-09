using DesignPattern.NullObject.Interfaces;

namespace DesignPattern.NullObject.Models
{
    public class NullCustomer: AbstractCustomer
    {
        public override bool IsNil()
        {
            return true;
        }

        public override string GetName()
        {
            return "Not Available in Customer Database";
        }
    }
}

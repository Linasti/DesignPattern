

using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.Models
{
    public class Cat : IPet
    {
        string IPet.Eat()
        {
            return "Mouse";
        }

        int IPet.MoveSpeed()
        {
            return 20;
        }
    }
}

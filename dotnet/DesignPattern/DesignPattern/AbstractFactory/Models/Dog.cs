
using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.Models
{
    public class Dog : IPet
    {
        string IPet.Eat()
        {
            return "Bones";
        }

        int IPet.MoveSpeed()
        {
            return 10;
        }
    }
}

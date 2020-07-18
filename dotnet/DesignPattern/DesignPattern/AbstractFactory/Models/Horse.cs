

using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.Models
{
    public class Horse : IPet
    {
        string IPet.Eat()
        {
            return "Grass";
        }

        int IPet.MoveSpeed()
        {
            return 15;
        }
    }
}

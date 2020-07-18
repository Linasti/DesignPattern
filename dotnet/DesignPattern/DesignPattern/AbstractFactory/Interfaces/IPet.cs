namespace DesignPattern.AbstractFactory.Interfaces
{
    public interface IPet
    {
        /// <summary>
        /// Return the speed in kilometers
        /// </summary>
        /// <returns>the speed</returns>
        int MoveSpeed();

        /// <summary>
        /// Return the prefered food 
        /// </summary>
        /// <returns>the prefered food </returns>
        string Eat();
    }
}

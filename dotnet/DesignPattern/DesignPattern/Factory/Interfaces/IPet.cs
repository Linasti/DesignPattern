using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory.Interfaces
{
    public interface IPet
    {
        /// <summary>
        /// Return the speed in kilometers
        /// </summary>
        /// <returns>the speed</returns>
        int Walk();

        /// <summary>
        /// Return the prefered food 
        /// </summary>
        /// <returns>the prefered food </returns>
        string Eat();
    }
}

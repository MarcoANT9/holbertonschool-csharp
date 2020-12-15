using System;

namespace Enemies
{
    /// <summary>This class represents a zombie enemy. </summary>
    public class Zombie
    {

        /// <values>This is the value that represents the hit points of the enemy. </values>
        public int health;

        /// <summary>This is the constructor of the class. </summary>
        public Zombie()
        {
            health = 0;
        }
        ///<summary>
        ///This is another constructor for the class, it verifies that the health is >= 0.
        ///</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException ("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }
}
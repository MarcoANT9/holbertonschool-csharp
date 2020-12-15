using System;

namespace Enemies
{
    /// <summary>This class represents a zombie enemy. </summary>
    public class Zombie
    {
        /// <values>This is the value that represents the hit points of the enemy. </values>
        private int health;
        /// <values>This is the name of the zombie.</values>
        private string name = "(No name)";
        /// <values>This a public property, called name.</values>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>This is the constructor of the class. </summary>
        public Zombie()
        {
            health = 0;
            name = "(No name)";
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

        ///<summary>This is a public method that returns the current health of the enemy.</summary>
        public int GetHealth()
        {
            return this.health;
        }

        ///<summary>This is an overide of the ToString method.</summary>
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }

    }
}
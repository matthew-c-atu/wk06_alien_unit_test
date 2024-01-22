using System;

public class Class1
{
		public class Alien
    {
        // Data members
        private bool dead;
        private bool dodging;
        private int alienHealth;

        // Class constructors
        public Alien(bool dodging, int alienHealth)
        {
            // Construct the Alien object and initialize the data members appropriately.
            this.dodging = dodging;
            this.alienHealth = alienHealth;
        }

        // Properties (equivalent to getters and setters in Java)
        public bool Dodging
        {
            get { return dodging; }
            set { dodging = value; }
        }

        public int AlienHealth
        {
            get { return alienHealth; }
            set
            {
                // Minimum Alien health should be 0.
                alienHealth = Math.Max(value, 0);
            }
        }

        public bool Dead
        {
            get { return dead; }
        }

        // Methods
        public void Dodge()
        {
            // Set dodging to true if the alien is alive
            if (!dead)
            {
                dodging = true;
            }
        }

        public void Hit()
        {
            // Reduces the alien health by 1. Minimum Alien health should be 0.
            alienHealth = Math.Max(alienHealth - 1, 0);

            // If health is 0, mark the alien as dead
            dead = (alienHealth == 0);
        }

        public void Miss()
        {
            // Sets dodging to false
            dodging = false;
        }
    }

}
}

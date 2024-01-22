using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace wk06_alien_unit_test
{
    public class Raygun
    {
        private int mChrg; //The maximum charge the Raygun can hold
        private int cChrg; //The current level of charge the Raygun has

        //Class constructors
        public Raygun(int mChrg, int cChrg)
        {
            //TODO: Construct the Raygun object and initialise the attributes
        }

        // Methods
        //TODO: Implement appropriate getters and setters for the class

        public void fireAt(Alien a)
        {
            //TODO: Implement the method
            /*The gun should only fire if it is charged. Firing the gun will reduce the charge by 1. If the alien isDodging
            * alien.miss() should be called, otherwise alien.hit */

        }

        public void recharge()
        {
            //TODO: Implement the method
            /*Increases the current charge by 1*/
        }

        public static bool IsCharged()
        {
            //TODO: Implement the method
            /*Returns true if the gun has a charge*/

        }

        public bool isFullyCharged()
        {
            //TODO: Implement the method
            /*Returns true if the gun is fully charged*/
        }
    }
}

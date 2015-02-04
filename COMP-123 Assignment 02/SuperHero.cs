using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_Assignment_02
{
    class SuperHero:Hero
    {
        //create private properties
        private string[] superPowers;

        //create constructor
        public SuperHero(string name, int strength, int speed, int health):base(name)
        {
            generateRandomPowers();
        }

        //private Method
        private void generateRandomPowers()
        {
            superPowers[0] = "Super Speed";
            superPowers[1] = "Super Strength";
            superPowers[2] = "Body Armour";
            superPowers[3] = "Flight";
            superPowers[4] = "Fire Generation";
            superPowers[5] = "Weather Control";
        }
    }
}

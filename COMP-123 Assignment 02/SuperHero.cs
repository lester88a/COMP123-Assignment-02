using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_Assignment_02
{
    class SuperHero:Hero
    {
        //create private properties+++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string[] superPowers;
        
        //create rdmNumber
        private int rdmNumber;

        //create constructor++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public SuperHero(string name):base(name)
        {
            generateRandomPowers();
        }

        //private Method++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void generateRandomPowers()
        {
            //create 6 powers array
            string[] listOf6Powers ={"Super Speed","Super Strength","Body Armour",
                                        "Flight","Fire Generation","Weather Control"};
            //create random 5 numbers 
            Random rdmNumber = new Random();
            this.rdmNumber = rdmNumber.Next(0,6);

            //pick up three random powers
            for (int i = 0; i < 3; i++)
            {
                //assign results to superPowers array
                this.superPowers[this.rdmNumber] = listOf6Powers[this.rdmNumber];
            }
        }

        //public method++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void showPowers()
        { 
        
        }

    }
}

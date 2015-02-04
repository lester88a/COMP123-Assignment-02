using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_Assignment_02
{
    class Hero
    {
        //creats properties++++++++++++++++++++++++++++++++++++++++++++++++++++

        //creats private properties 
        private int strength;
        private int speed;
        private int health;
        private int rdmNumber;


        //creats public properties 
        public string name;

        //Constructor methods++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(string name)
        {
            this.name = name;//pass the this.name value to the name properties

            generateAbilities(); //call generateAbilities() method
        }

        // creats the private generateAbilities method
        public void generateAbilities()
        {
            //generates random numbers of strength, speed ,health between 1 to 100
            Random rnm = new Random();
            this.strength = rnm.Next(1, 101);


            Random speed = new Random();
            this.speed = rnm.Next(1, 101);


            Random health = new Random();
            this.health = rnm.Next(1, 101);

        }

        //generates the public fight Method
        public void fight()
        {
            if (hitAttempt() == true) //If hitAttempt returns true, then it will call the hitDamage method
            {
                hitDamage();
            }

        }

        //cerat a private hitAttempt method
        private bool hitAttempt()
        {

            Random rdmNumber = new Random();
            this.rdmNumber = rdmNumber.Next(1, 101);

            if (this.rdmNumber >= 1 && this.rdmNumber <= 20) //if the hero hits, the health will be between 1-20
            {
                Console.WriteLine("Hero attempt to hit!");
                return true;
            }
            else // if not, will return false.
            {
                Console.WriteLine("Hero did not hit!");
                Console.WriteLine("generates the this.rdmNumber number which is {0} is more than 20.", this.rdmNumber);
                return false;
            }
        }

        //cerat a private hitDamage method
        private int hitDamage()
        {
            Random randomNumber = new Random();//generates a random number.
            this.rdmNumber = randomNumber.Next(1, 6) + 1;
            int damages = this.strength * this.rdmNumber;// multiply the strength by a random number
            Console.WriteLine("The hit damage score is {0}, randomNumber{1}.", damages, this.rdmNumber);// display the damage value
            return damages;

        }

        //display hero's ability score
        public void show()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("--------Strength: {0}--------", this.strength);
            Console.WriteLine("--------Speed: {0}-----------", this.speed);
            Console.WriteLine("--------Health: {0}----------", this.health);
            Console.WriteLine("+++++++++++++++++++++++++++++");
        }
    }
}

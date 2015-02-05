using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Student Name: LI XU
 * Student ID: 300735072
 * Assignment 01
 * COMP-123
 */
namespace COMP_123_Assignment_02
{
    class SuperHero:Hero
    {
        //create private properties+++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string[] superPowers = new string[3];

        //create a list of 6 powers array
        private string[] listOf6Powers ={"Super Speed","Super Strength","Body Armour",
                                        "Flight","Fire Generation","Weather Control"};
        //create random numbers 
        Random rnd = new Random();
        private int randomElement;


        //create constructor++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public SuperHero(string name):base(name)
        {
            generateRandomPowers();
        }

        //private Method++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void generateRandomPowers()
        {
            
           
            //create a temPowers
            string[] temPowers = new string[listOf6Powers.Length];

            // Copy each element of the listOf6Powers to temPowers
            for (int i = 0; i < listOf6Powers.Length; i++)
            {
                temPowers[i] = listOf6Powers[i];
            }

            //pick up three random powers
            int index = 0;
            while (index < superPowers.Length)
            {
                //generate random number
                this.randomElement = generateRandomElement(rnd, listOf6Powers.Length);
                
                //assign the results to superPowers array
                if (temPowers[randomElement]!="Unavailable")
                {
                    this.superPowers[index] = temPowers[this.randomElement];
                    temPowers[this.randomElement] = "Unavailable";
                    index++;
                } 
            }

            /*
            //pick up three random powers
            for (int i = 0; i < superPowers.Length; i++)
            {
                //generate random number
                this.randomElement = generateRandomElement(rnd, listOf6Powers.Length);

                //assign the results to superPowers array
                if (temPowers[randomElement]!="Unavailable")
                {
                    this.superPowers[i] = temPowers[this.randomElement];
                    temPowers[this.randomElement] = "Unavailable";
                } 
            }*/

        }

        //public method++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void showPowers()
        {
            //display a list of six powers
            Console.WriteLine("++++++++a list of six powers++++++++++++");
            for (int i = 0; i < this.listOf6Powers.Length; i++)
            {
                Console.WriteLine("  {0}'s  power is: {1}  ", this.name, this.listOf6Powers[i]);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine();//create a new line

            //display superPowers
            Console.WriteLine("+++++++++Random 3 superPowers+++++++++++");
            for (int i = 0; i < superPowers.Length; i++)
            {
                Console.WriteLine("  {0}'s superHero power is: {1}  ", this.name,this.superPowers[i]);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
        
        }

        //
        public static int generateRandomElement(Random rnd, int max)
        {
            int randomNumber = rnd.Next(max);
            //Console.WriteLine("My random number is {0}", randomNumber);
            return randomNumber;
        }

    }
}

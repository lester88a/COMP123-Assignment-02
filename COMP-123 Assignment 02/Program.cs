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
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero newSuperHero = new SuperHero("Super Man");
            newSuperHero.showPowers();


            Hero h1 = new Hero("King");
            h1.fight();
        }
    }
}

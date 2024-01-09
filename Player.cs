using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopexample
{
    public class Player
    {
        string firstName;
        string lastName;
        int health;
        int powerLevel;

        //Constructor = a special method with the same name of the class and is 
        //called automatically during object creation
        //Constructor does not have a return type

        public Player(string fname, string lname, int healthValue, int powerLevelValue)
        {
            firstName = fname;
            lastName = lname;
            health = healthValue;
            powerLevel = powerLevelValue; 
        }

        public string GetGreeting()
        {
            return "Hello " + firstName;
        }
    }

    
}



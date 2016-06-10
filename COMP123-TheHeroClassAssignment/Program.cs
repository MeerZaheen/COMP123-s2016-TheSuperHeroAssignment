using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* COMP123-The Super Hero Class Assignment
* Author: Meer Zaheen Nazmul
* Student ID: 300522487
* Date Last Modified: June 10th 2016
* Program Description: Using MS Visual Studio, Build and Implement a Hero Class. 
* Build and Implement a SuperHero class. The SuperHero class is a subclass for the Hero superclass from Assignment1
* GitHub Link: https://github.com/MeerZaheen/COMP123-s2016-TheSuperHeroAssignment.git
*
* Revision History:
* a) Initial commit to add default .gitIgnore and .gitAttribute files.
*       Date: May 31st, 2016
* b) Initial Commit
*       Date: May 31st, 2016
* c) Part a complete
*       Date: May 31st 2016
* d) Part 1b, c, d done
*       Date: May 31st 2016
* e) working on 1e
*       Date: May 31st, 2016
* f) finished. added and tried to do unit test but confused with generalability method
*       Date: June 2nd, 2016
* g) Added revision comment
*       Date: June 2nd, 2016
* h) Initial Commit and added SuperHero Class
*       Date: June 5th, 2016
* i) Added private instance variable: _superPowers
*       Date: June 5th, 2016
* j) added a List of string SuperPowers in private method : _generateRandomPowers
*       Date: June 6th, 2016
* k) Implemented a forloop for _generateRandomPowers
*       Date: June 6th, 2016
* j) Created a public method ShowPowers
*       Date: June 6th, 2016
* k) Added new superhero in program driver class
*       Date: June 7th, 2016
* l) Created and edited ShowPower method
*       Date: June 7th, 2016
* m) Added a loop for different rounds
*       Date: June 8th, 2016
* m) No changes to coding but changes to revision and comments
*       Date: June 10th, 2016
* 
*/

namespace COMP123_TheHeroClassAssignment
{
    /**
    * <summary>
    * This is the "DRIVER" for the SuperHero program
    * </summary>
    *
    * @class Program
    */

    public class Program
    {
        /**
        * <summary>
        * This is the main method for our SuperHero class plus a do/while loop for the player to play again if wanted
        * </summary>
        *
        * @Method Main
        * @param {string[]} args
        */

        public static void Main(string[] args)
        {
            // Create a new instance for the SuperHero Class
            string playerReply = " ";
            int round = 0;
            do
            {
                SuperHero MeerZ = new SuperHero("MeerZ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("---------------------------------");
                Console.WriteLine("*     Your are in round: {0}      *",++round);
                MeerZ.Show();
                MeerZ.ShowPowers();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                MeerZ.Fight();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*         Type 'yes' to play again!          *");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                playerReply = Console.ReadLine();
            } while (playerReply == "yes");
            Console.WriteLine();
        }
    }
}
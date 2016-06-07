using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* COMP123-The Hero Class Assignment
* Author: Meer Zaheen Nazmul
* Student ID: 300522487
* Date Last Modified: June 5nd 2016
* Program Description: Using MS Visual Studio, Build and Implement a Hero Class. 
* Build and Implement a SuperHero class. The SuperHero class is a subclass for the Hero superclass from Assignment1
* GitHub Link: 
*
* Revision History:
* a) Initial commit to add default .gitIgnore and .gitAttribute files.
*       Date: May 31st, 2016, 8:27pm
* b) Initial Commit
*       Date: May 31st, 2016
* c) Part a complete
*       Date: May 31st 2016, 8:40pm
* d) Part 1b, c, d done
*       Date: May 31st 2016, 9:30pm
* e) working on 1e
*       Date: May 31st, 2016, 9:30pm
* f) finished. added and tried to do unit test but confused with generalability method
*       Date: June 2nd, 2016, 4:40pm
* 
*/

namespace COMP123_TheHeroClassAssignment
{
    /**
    * <summary>
    * This is the "DRIVER" for the Hero program
    * </summary>
    *
    * @class Program
    */

    public class Program
    {
        /**
        * <summary>
        * This is the main method for our Hero class plus a do/while loop for the player to play again if wanted
        * </summary>
        *
        * @Method Main
        * @param {string[]} args
        */

        public static void Main(string[] args)
        {
            // Create a new instance for the Hero Class
            string playerReply = " ";
            do
            {
                SuperHero MeerZ = new SuperHero("MeerZ");
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
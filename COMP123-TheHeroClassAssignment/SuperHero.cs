using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_TheHeroClassAssignment
{
    /**
    * <summary>
    * This is the SuperHero class. It is derived from the Hero Class
    * </summary>
    *
    * @class SuperHero
    * @extends Hero
    */

    class SuperHero : Hero
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++

        private string[] _superPowers;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This property, SuperPowers, includes a getter and setter for the private
         * instance variable _superPowers
         * </summary>
         *
         * @property SuperPowers
         */

        public string[] SuperPowers
        {
            get
            {
                return this._superPowers;
            }
            set
            {
                this._superPowers = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is the empty default Constructor for the SuperHero class
         * This calls the _generateAbilities method
         * </summary>
         * @constructor SuperHero
         * @extends Hero
         * @params {string}name        
         */

        public SuperHero(string name)
            :base(name)
        {
            _generateRandomPowers();
            ShowPowers();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        * This is a private _generateRandomPowers method that randomly 
        * generates three random superpowers from the following list of 6 powers
        * </summary>
        *
        * @method _generateRandomPowers
        * @param {int} SuperStrength
        * @param {int} SuperSpeed
        * @param {int} BodyArmour
        * @param {int} Flight
        * @param {int} FireGeneration
        * @param {int} WeatherControl
        */

        private void _generateRandomPowers()
        {
            Random power = new Random();
            List<string> SuperPowers = new List<string>();
            SuperPowers.Add("Super Strength");
            SuperPowers.Add("Super Speed");
            SuperPowers.Add("Body Armour");
            SuperPowers.Add("Flight");
            SuperPowers.Add("Fire Generation");
            SuperPowers.Add("Weather Control");

            for (int i = 0; i < 3; i++)
            {
                int randomPower = power.Next(0, SuperPowers.Count); // random power from 1 to 6
                _superPowers[i] = SuperPowers[randomPower]; // or SuperPowers.ElementAt(randomPower): Returns the element at a specified index in a sequence.
                SuperPowers.RemoveAt(randomPower); // RemoveAt prevents duplication          // square-bracket syntax more preferrable?
                Console.WriteLine(_superPowers[i]);
            }
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        * This method will display the SuperHero’s super powers	to the console
        * </summary>
        *
        * @return {void}
        * @field {string} superPower
        */
        public void ShowPowers()
        {
            Console.WriteLine(_superPowers);
        }
    }
}

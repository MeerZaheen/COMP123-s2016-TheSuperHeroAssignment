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
            _generateRandomPowers;
        }
    }
}

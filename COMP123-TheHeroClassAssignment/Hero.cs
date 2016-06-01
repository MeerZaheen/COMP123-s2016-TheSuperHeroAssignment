using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_TheHeroClassAssignment
{
    /**
    * This class defines a Hero
    *
    * @class Hero
    * @field _name {string}
    * @field _strength {int}
    * @field _speed {int}
    * @field _health {int}
    */
    class Hero
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _strength;
        private int _speed;
        private int _health;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        * This is a property for our _name field
        * </summary>
        *
        * @property {string} Name
        */

        private string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }
        }

        /**
        * <summary>
        * This is a property for our _strength field
        * </summary>
        *
        * @property {int} Strength
        */

        private int Strength
        {
            get
            {
                return _strength;
            }
            set
            {
                this._strength = value;
            }
        }

        /**
        * <summary>
        * This is a property for our _speed field
        * </summary>
        *
        * @property {int} Speed
        */

        private int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                this._speed = value;
            }
        }

        /**
        * <summary>
        * This is a property for our _health field
        * </summary>
        *
        * @property {int} Health
        */

        private int Health
        {
            get
            {
                return _health;
            }
            set
            {
                this._health = value;
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        * This is the default empty constructor method for the Hero class
        * </summary>
        * 
        * @constructor Hero
        */

        public Hero()
        {
            this.Name = "Unknown Name";
        }

        /**
        * <summary>
        * This is a constructor that takes name as a parameter and passes it to the _name private instance variable.
        * This constructor also calls the _generateAbilities method 
        * </summary>
        *
        * @constructor Hero
        * @param {string} name
        */
        public Hero(string name)
        {
            this._name = name;
            _generateAbilities();
        }

        /**
        * <summary>
        * This is a private _generateAbilities method that randomly generates the ability numbers for the following fields
        * from the private instance variables
        * </summary>
        *
        * @method _generateAbilities
        * @param {int} Strength
        * @param {int} Health
        * @param {int} Speed
        */
        private void _generateAbilities()
        {
            Random numbers = new Random();
            this._strength = numbers.Next(1, 100);
            this._health = numbers.Next(1, 100);
            this._speed = numbers.Next(1, 100); 
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    }
}

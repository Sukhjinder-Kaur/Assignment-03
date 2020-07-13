using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_03
{
    public class TerrestrialPlanet : Planet, IHasMoons,IHabitable
    {
        //private instance Variable
        private bool _oxygen;
        //property
        public bool Oxygen
        {
            get
            {
                return _oxygen;
            }
        }
        /// <summary>
        /// TerrestrialPlanet constructor take 3 parameters from the base planet class it also has its parameter which is oxygen.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }

        //Public methods
        public bool HasMoons()
        {
            if(MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Habitable()
        {
            if (Oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// String method return the output of Terrestrial  Planet to the console
        /// </summary>
        public override string ToString()
        {
            return $"name= {Name},diameter= {Diameter} Km,Mass={Mass}kg,Habitable={Habitable()}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name=Sukhjinder Kaur
Student number= 301087895
Date last Modified = 13 / 07 / 2020
Program description=TerrestrialPlanet is the subclass of planet */

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
            return Convert.ToBoolean((MoonCount > 0) ? "True" : "False");
        }

        public bool Habitable()
        {
            return Convert.ToBoolean((Oxygen == true) ? "True" : "False");
        }
        /// <summary>
        /// String method return the output of Terrestrial  Planet to the console
        /// </summary>
        public override string ToString()
        {
            return $"Terrestrial Planet name is = {Name}\n" +
                   $"{Name} has a diameter of = {Diameter} Km \n" +
                   $"Mass of {Name} is = {Mass} Kg \n" +
                   $"Does {Name} have any moons True/False ? {HasMoons()} \n" +
                   $"Is terrestrial planet {Name} habitable True/False ? {Habitable()}";
        }
    }
}
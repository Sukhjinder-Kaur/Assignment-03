using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
/*Name=Sukhjinder Kaur 
 *Student number= 301087895
 *Date last Modified= 13/07/2020
 *Program description=GiantPlanet is a subclass of abstract class-Planet.It has Ice and Gas its planets.
 */
namespace Assignment_03
{/// <summary>
/// This is the derived class of Planet
/// </summary>
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //private instance variable
        private string _type;
        //property
        public string Type
        {
            get
            {
                return _type;
            }
        }
        /// <summary>
        /// GiantPlanet constructor take 3 parameters from the base
        /// planet class it also has its parameter which is type that decides planet is an Ice or Gas giant.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name,diameter,mass)
        {

            if (type == "Ice"||type== "Gas")
            {
                _type = type;
            }
        }
        //Public methods
        public bool HasMoons()
        {
            return Convert.ToBoolean((MoonCount > 0) ? "True" : "False");
        }
        public bool HasRings()
        {
            return Convert.ToBoolean((RingCount > 0) ? "True" : "False");
        }
        /// <summary>
        /// String method return the output of Giant Planet to the console
        /// </summary>
        public override string ToString()
        {
            return $"Giant Planet name is = {Name}\n" +
                   $"{Name} has a diameter of = {Diameter} Km \n" +
                   $"Mass of {Name} is = {Mass} Kg \n" +
                   $"And {Name} is an {Type} giant \n" +
                   $"Does {Name} have any moons True/False ? {HasMoons()} \n" +
                   $"Does {Name} have any rings True/False ? {HasRings()}";
        }
    }
}
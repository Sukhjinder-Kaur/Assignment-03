using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name=Sukhjinder Kaur 
 *Student number= 301087895
 *Date last Modified= 13/07/2020
 *Program description=This is an abstract class-Planet
 */
namespace Assignment_03
{/// <summary>
/// This is an abstract class
/// </summary>
    public abstract class Planet
    {
        // Fields

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        ///Public properties
        public double Diameter
        {
            get
            {
                return _diameter;
            }
        }

        public double Mass
        {
            get
            {
                return _mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return _moonCount;

            }
            set
            {
                _moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }
            set
            {
                _orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return _ringCount;
            }
            set
            {
                _ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }
            set
            {
                _rotationPeriod = value;
            }
        }/// <summary>
         /// This is the constructor of Planet abstract class and it takes 3 parameters
         /// </summary>
         /// <param name="name"></param>
         /// <param name="diameter"></param>
         /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            _name = name;
            _diameter = diameter;
            _mass = mass;
        }
        /// <summary>
        /// String method return name ,diameter and mass
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Planet name is = {Name}\n" +
                   $"{Name} has a diameter of = {Diameter} Km \n" +
                   $"Mass of {Name} is = {Mass} Kg ";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_03
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("         Giant Planet description \n");

            GiantPlanet giantPlanet = new GiantPlanet("Neptune", 49244,1.024, "Ice");
            Console.WriteLine(giantPlanet.ToString());

            Console.WriteLine("\n\n   Terrestrial Planet description \n ");

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mars", 6779, 6.39, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            WaitForAnyKey();
        }
        static void WaitForAnyKey()
        {
            Console.WriteLine("\n\n\n************ Result Displayed ************\n\n\n");
            Console.Write("Press any key to exit this window.............");
            Console.ReadKey();
        }
    }
}
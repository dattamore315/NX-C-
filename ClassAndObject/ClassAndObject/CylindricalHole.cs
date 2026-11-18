using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class CylindricalHole
    {
        public double Diameter;
        public double Depth;
        public string HoleType;

        public double CalculateRadius()
        {
            return Diameter / 2;
        }
        public double CalculateVolume()
        {
            return Math.PI * Diameter * Depth;
        }

        public void DisplayHoleDetails()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Diameter of hole: "+Diameter+" mm");
            Console.WriteLine("Depth of the hole: "+ Depth+ " mm");
            Console.WriteLine("Hole Type: "+HoleType);
            Console.WriteLine("Radius of Hole is: "+CalculateRadius()+" mm");
            Console.WriteLine("Volume of hole is: "+CalculateVolume()+" mm3");
            Console.WriteLine("------------------------------------------");
        }
    }
}

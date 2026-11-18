using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class ShaftDesign
    {
        public double ShaftDiameter;
        public double ShaftLength;
        public string Material;

        public double Calculatevolume()
        {
            return Math.PI * ShaftDiameter * ShaftLength;
        }
        public double CalculateRadius()
        {
            return ShaftDiameter / 2;
        }
        public void ShaftDetails()
        {
            Console.WriteLine("\nMaterial: "+Material);
            Console.WriteLine("Shaft Radius: "+CalculateRadius()+" mm");
            Console.WriteLine("Shaft Volume: "+Calculatevolume()+" mm3");
            Console.WriteLine("------------------------------------------");
        }
    }
}

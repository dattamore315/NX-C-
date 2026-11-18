using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class MechanicalPlate
    {
        // Fields
        public double Length; 
        public double Width;
        public double Thickness;
        public string MaterialName;

        // Parametric constructor
        public MechanicalPlate(double length, double width, double thickness, string materialName)
        {
            Length = length;
            Width = width;
            Thickness = thickness;
            MaterialName = materialName;
        }

        // Instance Method
        public double CalculateArea()
        {
            return Length * Width;
        }

        // Instance Method
        public double CalculateVolume()
        {
            return Thickness * Width * Length;
        }

        // Instance Method
        public void DisplayPlateDetails()
        {
            
            Console.WriteLine("Material: "+MaterialName);
            Console.WriteLine("Area: "+CalculateArea()+" mm2");
            Console.WriteLine("Volume: "+CalculateVolume()+" mm3");
            Console.WriteLine("------------------------------------");
        }
    }
}

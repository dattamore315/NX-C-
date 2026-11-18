using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class PipeDesign
    {
        public double OuterDiameter;
        public double InnerDiameter;
        public double PipeLength;

        public PipeDesign(double outerDiameter, double innerDiameter, double pipeLength)
        {
            OuterDiameter = outerDiameter;
            InnerDiameter = innerDiameter;
            PipeLength = pipeLength;
        }

        public double CalculateWallThickness()
        {

            return OuterDiameter - InnerDiameter;
        }
        public double CalculateCrossSectionalArea()
        {
            return Math.PI/4 *(OuterDiameter*OuterDiameter - InnerDiameter*InnerDiameter);
        }
        public double CalculatePipeVolume()
        {
            return Math.PI/4 * (OuterDiameter*OuterDiameter -InnerDiameter*InnerDiameter)*PipeLength;
        }

        public void DisplayPipeDetails()
        {
            Console.WriteLine("Outer Diameter: "+OuterDiameter+" mm");
            Console.WriteLine("Inner Diameter: "+InnerDiameter+" mm");
            Console.WriteLine("Pipe length: "+PipeLength+" mm");
            Console.WriteLine("Pipe Wall Thickness: "+CalculateWallThickness()+" mm");
            Console.WriteLine("Cross sectional Area: "+CalculateCrossSectionalArea()+" mm2");
            Console.WriteLine("Pipe volume: "+CalculatePipeVolume()+" mm3");
            Console.WriteLine("----------------------------------------------");
        }
    }
}

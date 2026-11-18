using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutParameters
{
    internal class Program
    {
        public void UpdateDimensions(ref double length, ref double width,  ref double thickness)
        {
            
            Console.WriteLine($"Original Values are: length= {length}, Width= {width}, Thickness={thickness}");
            length = 20 + length;
            width = 10 + width;
            thickness = 5 + thickness;

        }

        public void CalculateHoleDetails(double diameter, out double radius, out double area, out double circumference)
        {
            area = Math.PI * diameter * diameter/4;
            radius = diameter / 2;
            circumference = Math.PI * diameter;

        }
        static void Main(string[] args)
        {

            // ref parameter
            double len = 100;
            double wid = 50;
            double thick = 10;

            Program program =new Program();
            program.UpdateDimensions(ref len,ref wid, ref thick);
            Console.WriteLine($"Updated Values are: length= {len}, Width= {wid}, Thickness={thick}");


            //Out parameter
            program.CalculateHoleDetails(50,out double radius,out double area, out double circumference);
            Console.WriteLine("\nRadius of circle: " + radius + " mm");
            Console.WriteLine("Area of circle: "+area+" mm2");
            Console.WriteLine("Circumference of circle: "+circumference+" mm2");
        }
    }
}

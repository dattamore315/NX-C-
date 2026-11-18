using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndMethodOverloading
{
    internal class VolumeCalulator
    {
        //public double Length;
        //public double side;
        //public double Radius;
        //public double Width;
        //public double Height;


        public double CalculateVolume(double length,double width,double height)
        {
            return length * width * height;
        }

        public double CalculateVolume(double radius, double height)
        {
            return Math.PI * radius * radius * height;
        }

        public double CalculateVolume(double sidelength)
        {
            return sidelength * sidelength * sidelength;
        }
        public double CalculateVolume(float radius)
        {
            return (4/3) * Math.PI * radius * radius * radius;
        }

    }
}

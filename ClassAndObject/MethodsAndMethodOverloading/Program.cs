using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndMethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method overloading and overriding

            VolumeCalulator volumeCalulator = new VolumeCalulator();
          
            Console.WriteLine("Calculate rectangular block volume: "+volumeCalulator.CalculateVolume(150.0, 250.0, 25.0)+ " mm3");
            Console.WriteLine("Calculate cube volume: " + volumeCalulator.CalculateVolume(150.0) + " mm3");
            Console.WriteLine("Calculate cylinder volume: " + volumeCalulator.CalculateVolume(450.0, 250.0) + " mm3");
            Console.WriteLine("Calculate sphere volume: " + volumeCalulator.CalculateVolume(25.0) + " mm3");
        }
    }
}

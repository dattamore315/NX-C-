using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureVSClasses
{
    internal class Program
    {
        // struct class
        struct Cordinates
        {
            public int x;
            public int y;
            public int z;

        }

        class Points
        {
            public int x;
            public int y;
            public int z;

        }
        static void Main(string[] args)
        {
            // struct class object 
            Cordinates cordinates1 = new Cordinates();
            cordinates1.x = 10;
            cordinates1.y = 20;
            cordinates1.z = 30;

            Cordinates cordinates2 = cordinates1;  // Here we are copies all x y z cordinate values to cordinate2 object

            cordinates2.z = 50;  // passing new value 
            Console.WriteLine("Structure class:");
            Console.WriteLine("First Cordinate Z value is: "+cordinates1.z);
            Console.WriteLine("Second Cordinate Z value is: "+cordinates2.z);

            //Class object

            Points points1 = new Points();
            points1.x = 100;
            points1.y = 150;
            points1.z = 200;

            Points points2 = points1;  // here we are passing reference fron object1 to object2 and assigned value, so it will replace original value with new assigned value.

            points2.z = 300;
            Console.WriteLine("\nClass:");
            Console.WriteLine("First Cordinate Z value is: " + points1.z);
            Console.WriteLine("Second Cordinate Z value is: " + points2.z);

            //Difference: Structure vs Classes
            //Structure: are value type and 
            //Classes: Are reference type

            //Most use case of struct class, when we work with cordinates.
        }
    }
}

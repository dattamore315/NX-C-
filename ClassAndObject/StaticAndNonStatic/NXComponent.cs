using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStatic
{
    internal class NXComponent
    {
        public static int TotalComponent=0;
        public string ComponentName;
        public double ComponentVolume;

        public NXComponent(string componentName, double volume)
        {
            ComponentVolume = volume;
            ComponentName = componentName;
        }
        public static void AddComponent()
        {
            TotalComponent++;
        }

        public static void TotalComponentCount()
        {
            Console.WriteLine("Total Component count: "+ TotalComponent);
            
        }

     
        public void DisplayCOmponentDetails()
        {
            Console.WriteLine("Component Name: "+ComponentName);
            Console.WriteLine("Component Volume: "+ComponentVolume);
            //Console.WriteLine("Total Component Count is: " + TotalComponent);
        }

    }
}

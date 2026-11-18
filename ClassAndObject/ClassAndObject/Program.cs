using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  - Class and Object
            //Exercise1
            Console.WriteLine("----Mechanical Parts Details-----");
            MechanicalPlate mechanicalPlate =new MechanicalPlate(250.0,150.0,25.0,"Aluminium");
            mechanicalPlate.DisplayPlateDetails();
            MechanicalPlate mechanicalPlate1 = new MechanicalPlate(350.0, 250.0, 35.0, "Brass");
            mechanicalPlate1.DisplayPlateDetails();
            MechanicalPlate mechanicalPlate2 = new MechanicalPlate(140.5, 125.5, 10.5, "Steel");
            mechanicalPlate2.DisplayPlateDetails();

            //Exercise2
            ShaftDesign shaftDesign = new ShaftDesign();
            shaftDesign.ShaftDiameter = 20.5;
            shaftDesign.ShaftLength = 250.0;
            shaftDesign.Material = "Aluminium";
            Console.WriteLine("---Shaft Details---");
            shaftDesign.ShaftDetails();

            ShaftDesign shaftDesign1 = new ShaftDesign();
            shaftDesign.ShaftDiameter = 35.0;
            shaftDesign.ShaftLength = 350.0;
            shaftDesign.Material = "Steel";
            shaftDesign.ShaftDetails();

            //Exercise3
            /*
            for (int i = 0; i < 5; i++)
            {
                CylindricalHole hole = new CylindricalHole();
                Console.WriteLine("Enter hole diameter: ");
                hole.Diameter=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter hole depth: ");
                hole.Depth=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Hole Type");
                hole.HoleType=Console.ReadLine();
                hole.DisplayHoleDetails();
            }
            */


            //Exercise4

            PipeDesign pipeDesign = new PipeDesign(250, 245, 450);
            pipeDesign.DisplayPipeDetails();

            PipeDesign pipeDesign1 = new PipeDesign(350, 450, 600);
            pipeDesign.DisplayPipeDetails();

            PipeDesign pipeDesign2 = new PipeDesign(150, 250, 300);
            pipeDesign.DisplayPipeDetails();
            #endregion


           


        }
    }
}

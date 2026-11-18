using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            NXComponent nxComponent = new NXComponent("Shaft", 2.65);
            NXComponent.AddComponent();
            nxComponent.DisplayCOmponentDetails();
            NXComponent nxComponent1 = new NXComponent("Bracket", 3.58);
            NXComponent.AddComponent();
            nxComponent1.DisplayCOmponentDetails();
            NXComponent nxComponent2 = new NXComponent("Ring", 4.8);
            NXComponent.AddComponent();
            nxComponent2.DisplayCOmponentDetails();
            NXComponent nxComponent3 = new NXComponent("Sleeve", 2.5);
            NXComponent.AddComponent();
            nxComponent3.DisplayCOmponentDetails();
            NXComponent nxComponent4 = new NXComponent("Plate", 4);
            NXComponent.AddComponent();
            nxComponent4.DisplayCOmponentDetails();
            NXComponent nxComponent5 = new NXComponent("Bracket2", 3.58);
            NXComponent.AddComponent();
            nxComponent5.DisplayCOmponentDetails();

            NXComponent.TotalComponentCount();


            // Exercise 2

            // Multiple object creation

            //DesignCompany designCompany1 = new DesignCompany("Datta M", 1235);
            //designCompany1.DisplayEmpDetails();

            //DesignCompany designCompany2 = new DesignCompany("D M", 4554);
            //designCompany2.DisplayEmpDetails();
            //DesignCompany designCompany3 = new DesignCompany("DB M", 3277);
            //designCompany3.DisplayEmpDetails();
            //DesignCompany designCompany4 = new DesignCompany("MM M", 8427);
            //designCompany4.DisplayEmpDetails();
            //DesignCompany designCompany5 = new DesignCompany("KL M", 456);
            //designCompany5.DisplayEmpDetails();

            // Add to list and print details using foreach loop
            List<DesignCompany> Emp = new List<DesignCompany>();
            Emp.Add(new DesignCompany("DMK", 1234));
            Emp.Add(new DesignCompany("DBM", 4562));
            Emp.Add(new DesignCompany("KLM", 5345));
            Emp.Add(new DesignCompany("MLM", 8345));
            Emp.Add(new DesignCompany("MKR", 4538));
            Console.WriteLine();
            DesignCompany.CompanyName();
            foreach (var empDetails in Emp)
            {
                empDetails.DisplayEmpDetails();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStatic
{
    internal class DesignCompany
    {
        public static string CompName="Emdep testBoards pvt ltd";
        public string EmpName;
        public int EmpId;

        public DesignCompany(string empName, int empId)
        {
            EmpName = empName;
            EmpId = empId;
            
        }
        public static void CompanyName()
        {
            
            Console.WriteLine("Company Name: "+CompName);
        }
        public void DisplayEmpDetails()
        {
            
            Console.WriteLine("Employee Name: "+EmpName);
            Console.WriteLine("Employee ID: "+EmpId);
            Console.WriteLine("\n");
        }
    }
}

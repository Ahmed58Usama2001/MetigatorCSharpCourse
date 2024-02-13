using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Report
    {
        public delegate bool IllegibleSales(Employee employee);

        public void ProcessEmployee(Employee[] emps,string title, IllegibleSales isIllegible)
        {
            Console.WriteLine(title);
            Console.WriteLine("------------------------------------------------------");

            foreach (var employee in emps)
            {
                if(isIllegible(employee))
                {
                    Console.WriteLine(employee);
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Employee
    {
       public int Id { get; set; }

        public string Name { get; set; }

        public decimal TotalSales { get; set; }

        public string Gender { get; set; }



        public override string ToString()
        {
            return $"{Id} | {Name} | {Gender} | {TotalSales}";
        }
    }
}

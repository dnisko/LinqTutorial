using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part26
{
    class Program
    {
        static void Main(string[] args)
        {
            //      part 1
            //string[] countries = {"USA", "usa", "INDIA", "UK", "UK"};
            ////var result = countries.Distinct();
            //var result = countries.Distinct(StringComparer.OrdinalIgnoreCase);

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v);
            //}

            //      part 2

            List<Employee> list = new List<Employee>()
            {
                new Employee {ID = 101, Name = "Mike"},
                new Employee {ID = 101, Name = "Mike"},
                new Employee {ID = 102, Name = "Mary"}
            };

            var result = list
                         .Select(x => new { x.ID, x.Name })
                         .Distinct();//new EmployeeComparer());

            foreach (var v in result)
            {
                Console.WriteLine(v.ID + "\t" + v.Name);
            }
        }
    }
}

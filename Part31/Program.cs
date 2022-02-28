using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part31
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //      all
            //var result = numbers.All(x => x < 10);

            //      any
            //var result = numbers.Any(x => x < 10);

            //      contains
            //var result = numbers.Contains(3);
            //string[] countries = {"USA", "INDIA", "UK"};
            //var result = countries.Contains("india", StringComparer.OrdinalIgnoreCase);

            // part26
            List<Employee> employees = new List<Employee>()
            {
                new Employee {ID = 101, Name = "Rosy"},
                new Employee {ID = 102, Name = "Susy"}
            };

            var result = employees.Contains(new Employee { ID = 101, Name = "Rosy" });

            Console.WriteLine(result);
        }

        public class Employee
        {
            public int ID { get; set;}
            public string Name { get; set;}
        }
    }
}

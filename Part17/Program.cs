using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part17
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBDataContext db = new EmployeeDBDataContext();

            var result = db.Employees
                           .AsEnumerable()//executing everything before. After is in memory.
                           .Where(x => x.Gender == "Male")
                           .OrderByDescending(x => x.Salary)
                           .Take(5);

            foreach (var e in result)
            {
                Console.WriteLine(e.Name + "\t" +
                                  e.Salary + "\t" +
                                  e.Gender);
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

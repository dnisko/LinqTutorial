using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part18
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Default
            //var employeeGroups = Employee.GetAllEmployees()
            //                             .GroupBy(x => x.Department);

            //      SQL like
            var employeeGroups = from employees in Employee.GetAllEmployees()
                                 group employees by employees.Department into eGroup
                                 orderby eGroup.Key
                                 select new
                                 {
                                     Key = eGroup.Key,
                                     Employees = eGroup.OrderBy(x => x.Name)
                                 };

            foreach (var group in employeeGroups)
            {
                Console.WriteLine("{0} - {1}", 
                                  group.Key,
                                  //group.Count(x => x.Gender == "Male"));
                                  //group.Max(x => x.Salary));
                                  group.Employees.Count());
                Console.WriteLine("-------------------");

                foreach (var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name + "\t" +
                                      employee.Department);
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

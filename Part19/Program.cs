using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part19
{
    class Program
    {
        static void Main(string[] args)
        {
            //      default
            //var employeGroups = Employee.GetAllEmployees()
            //                    .GroupBy(x => new { x.Department, x.Gender })
            //                    .OrderBy(g => g.Key.Department)
            //                    .ThenBy(g => g.Key.Gender)
            //                    .Select(g => new
            //                    {
            //                        Dept = g.Key.Department,
            //                        Gender = g.Key.Gender,
            //                        Employees = g.OrderBy(x => x.Name)
            //                    });


            //      sql like
            var employeGroups = from employee in Employee.GetAllEmployees()
                                group employee by new { employee.Department, employee.Gender} into eGroup
                                orderby eGroup.Key.Department, eGroup.Key.Gender
                                select new
                                {
                                    Dept = eGroup.Key.Department,
                                    Gender = eGroup.Key.Gender,
                                    Employees = eGroup.OrderBy(x => x.Name)
                                };
            foreach (var group in employeGroups)
            {
                Console.WriteLine("{0} department {1} employees count {2}",
                    group.Dept, group.Gender, group.Employees.Count());

                Console.WriteLine("---------------------------------");

                foreach (var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name + "\t" +
                                      employee.Gender + "\t" +
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

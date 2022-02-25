using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part23
{
    class Program
    {
        static void Main(string[] args)
        {
            //      group join
            //var result = from d in Department.GetAllDepartments()
            //               join e in Employee.GetAllEmployees()
            //               on d.ID equals e.DepartmentID into eGroup
            //               select new
            //               {
            //                   Department = d,
            //                   Employees = eGroup
            //               };

            //foreach (var department in result)
            //{
            //    Console.WriteLine(department.Department.Name);

            //    foreach (var employee in department.Employees)
            //    {
            //        Console.WriteLine(" " + employee.Name);
            //    }
            //    Console.WriteLine();


            //      Inner join
            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID
                         select new
                         {
                            e, d
                         };

            foreach (var employee in result)
            {
                Console.WriteLine(employee.e.Name + "\t" +
                                  employee.d.Name);
            
            }
        }
    }
}

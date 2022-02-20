using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part21
{
    class Program
    {
        static void Main(string[] args)
        {
            //      extension method syntax (default)
            //var employeesByDepartment = Department.GetAllDepartments()
            //                            .GroupJoin(Employee.GetAllEmployees(),
            //                                       d => d.ID,
            //                                       e => e.DepartmentID,
            //                                       (department, employees) => new
            //                                       {
            //                                           Department = department,
            //                                           Employees = employees
            //                                       });

            //      sql like syntax
            var employeesByDepartment = from d in Department.GetAllDepartments()
                                        join e in Employee.GetAllEmployees()
                                        on d.ID equals e.DepartmentID into eGroup
                                        select new
                                        {
                                            Department = d,
                                            Employees = eGroup
                                        };


            foreach (var department in employeesByDepartment)
            {
                Console.WriteLine(department.Department.Name);

                foreach (var employee in department.Employees)
                {
                    Console.WriteLine(" " + employee.Name);
                }
                Console.WriteLine();
            }
        }
    }
}

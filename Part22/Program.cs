using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part22
{
    class Program
    {
        static void Main(string[] args)
        {
            //      default
            //var result = Employee.GetAllEmployees()
            //             .Join(Department.GetAllDepartments(),
            //                    e => e.DepartmentID,
            //                    d => d.ID,
            //                    (employee, department) => new
            //                    {
            //                        EmployeeName = employee.Name,
            //                        DepartmentName = department.Name
            //                    });


            //      sql like
            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID
                         select new
                         {
                             EmployeeName = e.Name,
                             DepartmentName = d.Name
                         };

            foreach (var employee in result)
            {
                Console.WriteLine(employee.DepartmentName + "\t" +
                                  employee.EmployeeName);
            }
        }
    }
}

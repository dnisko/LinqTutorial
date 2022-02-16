using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var result = Employee.GetAllEmployees()
                .Select(emp => new
                {
                    Name = emp.FirstName,
                    Salary = emp.AnnualSalary,
                    Bouns = emp.AnnualSalary * 0.1
                })
                .Where(sal => sal.Salary > 50000);

            foreach (var v in result)
            {
                Console.WriteLine(v.Name + ": " + v.Salary + " - " + v.Bouns);
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part25
{
    class Program
    {
        static void Main(string[] args)
        {
            //      extensions
            //          SelectMany
            //var result = Employee.GetAllEmployees()
            //                     .SelectMany(e => Department.GetAllDepartments()
            //                        ,(e, d) => new {e,d});

            //          Join
            var result = Employee.GetAllEmployees()
                                 .Join(Department.GetAllDepartments()
                                    , e => true
                                    , d => true
                                    , (e,d) => new {e,d});
            //      sql like
            //var result = from d in Department.GetAllDepartments()
            //             from e in Employee.GetAllEmployees()

            //             select new {e,d};

            foreach (var v in result)
            {
                Console.WriteLine(v.e.Name + "\t" + v.d.Name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrvDel();
            //VtorDel();
            Test();
        }

        public static void Test()
        {
            TestDBContext test = new TestDBContext();
            IEnumerable<objekt> objekts = test.objekts;
            Console.OutputEncoding = Encoding.UTF8;
            foreach (objekt obj in objekts)
            {
                Console.WriteLine("Objekt = " + obj.ime);

                IEnumerable<nastan> nastans = obj.nastans.Where(x => x.objekt.id_objekt == x.o_id_objekt);

                foreach (nastan nas in nastans)
                {
                    Console.WriteLine("\tNastan = " + nas.naziv);
                }
                    //.Where(x => x.ime);
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
        public static void VtorDel()
        {
            EmployeeDBContext context = new EmployeeDBContext();
            IEnumerable<Department> Departments = context.Departments
                .Where(x => x.Name == "IT" || x.Name == "HR");

            foreach (Department dept in Departments)
            {
                Console.WriteLine("Department - " + dept.Name);

                IEnumerable<Employee> employees = dept.Employees
                    .Where(x => x.Gender == "Male");

                foreach (Employee employee in employees)
                {
                    Console.WriteLine("\tEmployee Name = " +
                        employee.FirstName + " " +
                        employee.LastName);
                }
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static void PrvDel()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Func<int, bool> predicate = x => x % 2 == 0;
            //IEnumerable<int> evenNumbers = Numbers.Where(num => IsEven(num));

            //IEnumerable<int> evenNumbers = from num in Numbers
            //                               where num % 2 == 0
            //                               select num;
            var result = Numbers
                .Select((num, index) =>
                new
                {
                    Number = num,
                    Index = index
                })
                .Where(x => x.Number % 2 == 0)
                .Select(x => x.Index);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(result);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

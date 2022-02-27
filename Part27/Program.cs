using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part27
{
    class Program
    {
        static void Main(string[] args)
        {
            //      part 1
            //int[] num1 = { 1, 2, 3, 4, 5 };
            //int[] num2 = { 1, 3, 6, 7, 8 };

            //var result = num1.Union(num2);

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v);
            //}


            //      part 2
            //List<Employee> list1 = new List<Employee>()
            //{
            //    new Employee { ID = 101, Name = "Mike"},
            //    new Employee { ID = 102, Name = "Susy"},
            //    new Employee { ID = 103, Name = "Mary"}
            //};

            //List<Employee> list2 = new List<Employee>()
            //{
            //    new Employee { ID = 101, Name = "Mike"},
            //    new Employee { ID = 104, Name = "John"}
            //};

            ////var result = list1.Union(list2);
            //var result = list1.Select(x => new 
            //                        {
            //                            x.ID, x.Name
            //                        })
            //                  .Union(list2.Select(x => new 
            //                        {
            //                            x.ID, x.Name
            //                        }));

            //      part 3
            int[] num1 = { 1, 2, 3, 4, 5 };
            int[] num2 = { 1, 3, 6, 7, 8 };

            var result = num1.Intersect(num2);
            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
        }
    }
}

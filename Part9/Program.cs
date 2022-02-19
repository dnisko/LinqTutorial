using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable<List<string>> result = 
            //    Student.GetAllStudents()
            //    .Select(s => s.Subjects);

            IEnumerable<string> result =
                Student.GetAllStudents()
                .SelectMany(s => s.Subjects);

            //foreach (List<string> stringList in result)
            //{
                foreach (string str in result)//stringList)
                {
                    Console.WriteLine(str);
                }
            //}

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

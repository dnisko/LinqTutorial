using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            //          PART 1

            //      default
            //var Subjects = Student.GetAllStudents()
            //    .SelectMany(s => s.Subjects, (student, subject) => 
            //        new { StudentName = student.Name,
            //            SubjectName = subject })
            //    .Distinct();

            //      sql like
            var Subjects = 
                (from student in Student.GetAllStudents()
                 from subject in student.Subjects
                 select new { 
                                StudentName = student.Name, 
                                SubjectName = subject 
                            });
            foreach (var subject in Subjects)
            {
                Console.WriteLine(subject);
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
            
            //          PART 2
            /*
            string[] stringArray =
            {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };
            //      default
            //IEnumerable<char> result = stringArray.SelectMany(s => s);

            //      sql like
            IEnumerable<char> result = from s in stringArray
                                       from c in s
                                       select c;
            foreach (char c in result)
            {
                Console.WriteLine(c);
            }
            */
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

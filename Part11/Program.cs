using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part11
{
    class Program
    {
        static void Main(string[] args)
        {
            //          SORTING
            //      default
            //IEnumerable<Student> result = Student.GetAllStudents()
            //    .OrderBy(s => s.TotalMarks)
            //    .ThenBy(s => s.Name)
            //    .ThenByDescending(s => s.StudentID);


            //      sql like
            //IEnumerable<Student> result = from s in Student.GetAllStudents()
            //                              orderby s.TotalMarks, s.Name, s.StudentID descending
            //                              select s;
            //foreach (Student s in result)
            //{
            //    Console.WriteLine(s.TotalMarks + 
            //        "\t" + s.Name + 
            //        "\t" + s.StudentID);
            //}

            //          DESORTING

            IEnumerable<Student> students = Student.GetAllStudents();
            Console.WriteLine("Before calling Reverse Method");

            foreach (Student s in students)
            {
                Console.WriteLine(s.StudentID +
                    "\t" + s.Name +
                    "\t" + s.TotalMarks);
            }
            Console.WriteLine();
            Console.WriteLine("After calling Reverse Method");
            IEnumerable<Student> result = students.Reverse();

            foreach (Student s in result)
            {
                Console.WriteLine(s.StudentID +
                    "\t" + s.Name +
                    "\t" + s.TotalMarks);
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Students names before sorting");

            List<Student> students = Student.GetAllStudents();

            foreach (Student s in students)
            {
                Console.WriteLine(s.Name);
            }

            //      default
            //Console.WriteLine("Students names after sorting");
            //IOrderedEnumerable<Student> result = Student.GetAllStudents()
            //    .OrderByDescending(s => s.Name);

            //      sql like
            Console.WriteLine("Students names after sorting");
            IOrderedEnumerable<Student> result = from student in Student.GetAllStudents()
                                                 orderby student.Name descending
                                                 select student;

            foreach (Student s1 in result)
            {
                Console.WriteLine(s1.Name);
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part14
{
    class Program
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string Name { get; set; }
            public int TotalMarks { get; set; }
        }
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>
            {
                new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
                new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
                new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            };

            //ToList; Sum etc.. will execute query here
            int result = (from student in listStudents
                                          where student.TotalMarks == 800
                                          select student).Count();

            listStudents.Add(new Student()
            {
                StudentID = 104, Name = "Tim", TotalMarks = 800
            });

            //query is executed here
            //foreach (int st in result)
            //{
            //    Console.WriteLine(st.StudentID + "\t" + 
            //                      st.Name + "\t" + 
            //                      st.TotalMarks);
            //}
            Console.WriteLine(result);
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

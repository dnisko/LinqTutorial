using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part12
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>
        {
            new Student
            {
                StudentID= 101,
                Name = "Tom",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 102,
                Name = "Mary",
                TotalMarks = 900
            },
            new Student
            {
                StudentID= 103,
                Name = "Pam",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 104,
                Name = "John",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 105,
                Name = "John",
                TotalMarks = 800
            },
        };

            return listStudents;
        }
    }
}

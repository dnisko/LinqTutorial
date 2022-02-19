using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part9
{
    public class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>
        {
            new Student
            {
                Name = "Tom",
                Gender = "Male",
                Subjects = new List<string> { "ASP.NET", "C#" }
            },
            new Student
            {
                Name = "Mike",
                Gender = "Male",
                Subjects = new List<string> { "ADO.NET", "C#", "AJAX" }
            },
            new Student
            {
                Name = "Pam",
                Gender = "Female",
                Subjects = new List<string> { "WCF", "SQL Server", "C#" }
            },
            new Student
            {
                Name = "Mary",
                Gender = "Female",
                Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" }
            },
        };

            return listStudents;
        }
    }
}

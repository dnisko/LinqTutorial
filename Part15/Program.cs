using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part15
{
    class Program
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string Name { get; set; }
            public int TotalMarks { get; set; }
        }
        public class Employee
        {
            public string Name { get; set; }
            public string JobTitle { get; set; }
            public string City { get; set; }
        }
        static void Main(string[] args)
        {
            //      part 1
            //int[] numbers = {1, 2, 3, 4, 5};

            //List<int> result = numbers.ToList();

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //      part 2
            //List<string> countries = new List<string>
            //{
            //  "US", "India", "UK", "Australia", "Canada"
            //};

            //string[] result = (from country in countries
            //                   orderby country ascending
            //                   select country).ToArray();

            //foreach (string str in result)
            //{
            //    Console.WriteLine(str);
            //}

            //      part 3
            //List<Student> listStudents = new List<Student>
            //{
            //    new Student { StudentID = 101, Name = "Tom", TotalMarks = 800},
            //    new Student { StudentID = 102, Name = "Mary", TotalMarks = 900},
            //    new Student { StudentID = 103, Name = "Pam", TotalMarks = 800}
            //};

            //Dictionary<int, Student> result = 
            //        listStudents.ToDictionary(x => x.StudentID);//,
            //                                  //x => x.Name);

            //foreach (KeyValuePair<int, Student> kvp in result)
            //{
            //    Console.WriteLine(kvp.Key + "\t" +
            //                      kvp.Value.Name + "\t" +
            //                      kvp.Value.TotalMarks);
            //}

            //      part 4
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee { Name = "Ben", JobTitle = "Developer", City = "London"},
                new Employee { Name = "John", JobTitle = "Sr. Developer", City = "Bangalore"},
                new Employee { Name = "Steve", JobTitle = "Developer", City = "Bangalore"},
                new Employee { Name = "Stuart", JobTitle = "Sr. Developer", City = "London"},
                new Employee { Name = "Sara", JobTitle = "Developer", City = "London"},
                new Employee { Name = "Pam", JobTitle = "Developer", City = "London"}
            };
            var emplojeeByJobTitle = listEmployees.ToLookup(
                                     x => x.JobTitle);

            Console.WriteLine("Employee grouped by job title");
            foreach (var kvp in emplojeeByJobTitle)
            {
                Console.WriteLine(kvp.Key);
                foreach (var employee in emplojeeByJobTitle[kvp.Key])
                {
                    Console.WriteLine("\t" + employee.Name + "\t" +
                                      employee.JobTitle + "\t" +
                                      employee.City);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Employee grouped by city");

            var emplojeeByCity = listEmployees.ToLookup(
                                     x => x.City);
            foreach (var kvp in emplojeeByCity)
            {
                Console.WriteLine(kvp.Key);
                foreach (var employee in emplojeeByCity[kvp.Key])
                {
                    Console.WriteLine("\t" + employee.Name + "\t" +
                                      employee.JobTitle + "\t" +
                                      employee.City);
                }
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

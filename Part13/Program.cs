using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part13
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                IEnumerable<Student> students =
                    Student.GetAllStudents();


                Console.WriteLine("Please enter Page Number - 1, 2, 3 or 4");
                int pageNumber = 0;
                if (int.TryParse(Console.ReadLine(), out pageNumber))
                {
                    if (pageNumber >= 1 && pageNumber <= 4)
                    {
                        int pageSize = 3;
                        IEnumerable<Student> result = students
                            .Skip((pageNumber - 1) * pageSize)
                            .Take(pageSize);

                        Console.WriteLine();

                        Console.WriteLine("Displaying Page " + pageNumber);

                        foreach (Student s in result)
                        {
                            Console.WriteLine(s.StudentID + "\t" +
                                              s.Name + "\t" +
                                              s.TotalMarks);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Paage number must be integer form 1 to 4");
                    }
                }
                else
                {
                    Console.WriteLine("Paage number must be integer form 1 to 4");
                }

                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }

            while (1 == 1);
        }
    }
}

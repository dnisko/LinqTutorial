using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part28
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Part 1
            //          Without LINQ
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //          With LINQ
            //IEnumerable<int> result = Enumerable.Range(1, 10)
            //                                    .Where(i => i % 2 == 0);

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //          Part2
            //var result = Enumerable.Repeat("Hello", 5);

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v);
            //}

            //          Part3
            IEnumerable<int> result = GetData() ?? Enumerable.Empty<int>();
            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
        }

        public static IEnumerable<int> GetData()
        {
            return null;
        }
    }
}

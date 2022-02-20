using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            //      first
            //int result = numbers.First(x => x % 2 == 0);

            //      firstOrDefault
            //int result = numbers.FirstOrDefault(x => x % 2 == 100);

            //      last
            //int result = numbers.Last(x => x % 2 == 0);

            //      lastOrDefault
            //int result = numbers.FirstOrDefault(x => x % 2 == 100);

            //      elementAt
            //int result = numbers.ElementAt(1);

            //      elementAtOrDefault
            //int result = numbers.ElementAtOrDefault(1);

            //      single
            //int result = numbers.Single(x => x % 2 == 0);

            //      singleAtOrDefault
            //int result = numbers.SingleOrDefault(x => x % 2 == 0);

            //      defaultIfEmpty
            var result = numbers.DefaultIfEmpty(1);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            //      single

            Console.WriteLine("Result is " + result);


            //Console.WriteLine("Press enter to close...");
            //Console.ReadLine();
        }
    }
}

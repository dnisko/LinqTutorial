using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part30
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries1 = { "USA", "India", "UK" };
            string[] countries2 = { "UK", "IndIa", "USA" };

            var result = countries1.OrderBy(c => c)
                                   .SequenceEqual(countries2
                                        .OrderBy(c => c),
                                    StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Are equal: " + result);

            // for complex type (List<string>) in part26

        }
    }
}


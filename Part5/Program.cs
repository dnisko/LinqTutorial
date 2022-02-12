using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq();
            Default();
        }

        public static void Linq()
        {
            //      STRINGS
            /*string[] countries = { "India", "USA", "UK", "Canada", "Australia" };

            string result = countries.Aggregate((a, b) => a + ", " + b);
            */
            //      INTEGERS
            int[] Numbers = {2, 3, 4, 5};

            int result = Numbers.Aggregate((a, b) => a * b);
            Console.WriteLine("This is Linq");
            Console.WriteLine(result);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public static void Default()
        {
            //      STRINGS
            /*string[] countries = { "India", "USA", "UK", "Canada", "Australia" };
            
            string result = string.Empty;

            foreach (string str in countries)
            {
                result = result + str + ", ";
            }

            int lastIndex = result.LastIndexOf(", ");
            result = result.Remove(lastIndex);
            */

            //      INTEGERS
            int[] Numbers = { 2, 3, 4, 5 };

            int result = 1;

            foreach (int i in Numbers)
            {
                result *= i;
            }

            Console.WriteLine("This is Default");
            Console.WriteLine(result);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

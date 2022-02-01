using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int> {1,2,3,4,5,6,7,8,9,10};
            IEnumerable<int> EvenNumbers = 
                Enumerable.Where(Numbers, n => n % 2 == 0);

            foreach (int evenNumber in EvenNumbers)
            {
                Console.WriteLine(evenNumber);
            }
            
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

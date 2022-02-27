using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3 };
            int[] num2 = { 1, 5, 6 };
            
            var result = num1.Concat(num2);

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
        }
    }
}

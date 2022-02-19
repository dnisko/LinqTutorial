using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries =
                {
                    "Australia", "Canada", "Germany", "US", "UK", "Italy"
                };

            //      default
            //IEnumerable<string> result = countries.Skip(3);//.Take(3);
            //TakeWhile(s => s.Length > 2)
            //SkipWhile(s => s.Length > 2)

            //      sql like
            IEnumerable<string> result = (from country in countries
                                         select country).Skip(3);//.Take(3);
                                         //TakeWhile(s => s.Length > 2)
                                         //SkipWhile(s => s.Length > 2)
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

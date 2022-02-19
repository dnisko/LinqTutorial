using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part16
{
    class Program
    {
        static void Main(string[] args)
        {
            //      CAST
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //IEnumerable<int> result = list.Cast<int>();


            //      TYPE OF
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("4");
            list.Add("ABC");

            IEnumerable<int> result = list.OfType<int>();

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
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
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //      SMALEST NUMBER
            //int result = Numbers.Where(x => x % 2 == 0).Min();

            //      LARGEST NUMBER
            //int result = Numbers.Where(x => x % 2 == 0).Max();

            //      SUM ALL NUMBER
            //int result = Numbers.Where(x => x % 2 == 0).Sum();

            //      COUNT ALL NUMBER
            //int result = Numbers.Where(x => x % 2 == 0).Count();

            //      AVERAGE ALL NUMBER
            //double result = Numbers.Where(x => x % 2 == 0).Average();

            string[] countries = { "India", "USA", "UK" };

            //      SHORTEST STRING
            //int result = countries.Min(x => x.Length);

            //      LONGEST STRING
            int result = countries.Max(x => x.Length);

            Console.WriteLine("This is Linq");
            Console.WriteLine(result);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public static void Default()
        {
            
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //double? sum = 0;
            //int total = 0;
            //double? result = 0;

            //int? result = 0;

            foreach (int i in Numbers)
            {
                //      SMALEST NUMBER
                /*if (i % 2 == 0)
                {


                    if (!result.HasValue || i < result)
                    {
                        result = i;
                    }
                }
                */

                //      LARGEST NUMBER
                /* if (i % 2 == 0)
                 {
                     if (!result.HasValue || i > result)
                     {
                         result = i;
                     }
                 }*/
                //      SUM ALL NUMBER
                /*if (i % 2 == 0)
                {
                    result += i;
                }
                */

                //      COUNT ALL NUMBER
                /*if (i % 2 == 0)
                {
                    result += 1;
                }
                */

                //      AVERAGE ALL NUMBER
                /*if (i % 2 == 0)
                {
                    sum += i;
                    total += 1;
                }

                result = sum / total;
                */
            }

            
            string[] countries = {"India", "USA", "UK"};

            int? result = null;

            foreach (string str in countries)
            {
                //      SHORTEST STRING
                /*if (!result.HasValue || str.Length < result)
                {
                    result = str.Length;
                }
                */

                //      LONGEST STRING
                if (!result.HasValue || str.Length > result)
                {
                    result = str.Length;
                }
            }


            Console.WriteLine("This is Default");
            Console.WriteLine("Shortest country has {0} chrs",result);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

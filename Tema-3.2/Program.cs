using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
        }

        private static void Ex2()
        {
            string[] fileContent = System.IO.File.ReadAllLines(@"G:\Homework\Week3\Tema-3.2\Sum.txt");

            int[] myInts = Array.ConvertAll(fileContent, int.Parse);

            int sum = 0;

            foreach (var item in myInts)
            {
                sum += item;
            }

            string textToFile = "Suma este " + sum;

            System.IO.File.WriteAllText(@"G:\Homework\Week3\Tema-3.2\Sum.txt", textToFile);
        }

        private static void Ex1()

        {
            int year = 0;
            Console.WriteLine("Check is the year is leap or not:");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else if ((year % 100) == 0)
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
            else if ((year % 4) == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
        }
    }
}

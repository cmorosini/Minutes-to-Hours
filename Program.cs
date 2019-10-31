using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter how many minutes you want to convert to hours: ");
            int minutes = int.Parse(Console.ReadLine());
            int hours = minutes / 60;
            int mins = minutes % 60;

            Console.WriteLine("That is {0} hours and {1} minutes", hours, mins);
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}

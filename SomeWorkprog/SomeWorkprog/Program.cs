using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeWorkprog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word:");
            string str = Console.ReadLine();
            Console.WriteLine("Date added!");
            if (Int32.Parse(str) > 0)
	        {
                Console.WriteLine("{0}",str);
	        }
        }
    }
}

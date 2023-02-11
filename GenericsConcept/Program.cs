using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Generics...");
            FindMax maxValue = new FindMax();
            Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxNumber(43, 56, 15));
            Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxNumber(16, 16, 16));
            Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxNumber(136, 16, 5));
            Console.ReadLine();
        }
    }
}

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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1:Find Max Number \n2:Find Max Float \n3:find max string \n5:Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxNumber(43, 56, 15));
                        Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxNumber(16, 145, 34));
                        Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxNumber(136, 16, 5));
                        break;
                    case 2:
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxFloat(21.5f, 14.9f, 15));
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxFloat(12, 90, 15.3f));
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxFloat(12, 14, 25.1f));
                        break;
                    case 3:
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxString("Apple", "Peach", "Banana"));
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxString("dragonfruit", "goava", "grapes"));
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxString("pineapple", "papaya", "Peach"));
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter the above one");
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}


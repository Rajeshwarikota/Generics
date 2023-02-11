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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1:Find Max Number \n2:Find Max Float \n3:find max string \n5:Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("The Greatest Number is {0}", FindMax<int>.FindMaxValue(43, 56, 15));
                        Console.WriteLine("The Greatest Number is {0}", FindMax<int>.FindMaxValue(16, 145, 34));
                        Console.WriteLine("The Greatest Number is {0}", FindMax<int>.FindMaxValue(136, 16, 5));
                        break;
                    case 2:
                        Console.WriteLine("The Greatest Value is {0}", FindMax<float>.FindMaxValue(21.5f, 14.9f, 15));
                        Console.WriteLine("The Greatest Value is {0}", FindMax<float>.FindMaxValue(12, 90, 15.3f));
                        Console.WriteLine("The Greatest Value is {0}", FindMax<float>.FindMaxValue(12, 14, 25.1f));
                        break;
                    case 3:
                        Console.WriteLine("The Greatest Value is {0}", FindMax<string>.FindMaxValue("Apple", "Peach", "Banana"));
                        Console.WriteLine("The Greatest Value is {0}", FindMax<string>.FindMaxValue("dragonfruit", "goava", "grapes"));
                        Console.WriteLine("The Greatest Value is {0}", FindMax<string>.FindMaxValue("pineapple", "papaya", "Peach"));
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


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
            List<int> listNo = new List<int> { 90, 1, 56, 88, 4, 23, 7 };
            List<float> listfloat = new List<float> { 22, 3.3f, 12.9f, 99.234f, 1, 67.85f };
            List<string> listString = new List<string> { "apple", "banana", "xray", "peach", "WaterMelon" };

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1:Find Max Number \n2:Find Max Float \n3:find max string \n4:sort int find max \n5:sort float \n6:sort string \n5:Exit");
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
                        Console.WriteLine("Maximum Value = " + Sorting<int>.FindMaxList(listNo));
                        break;
                    case 5:
                        Console.WriteLine("Maximum Value = " + Sorting<float>.FindMaxList(listfloat));
                        break;
                    case 6:
                        Console.WriteLine("Maximum Value = " + Sorting<string>.FindMaxList(listString));
                        break;
                    case 7:
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConcept
{
    internal class Sorting<T> where T : IComparable
    {
        List<T> list;
        public Sorting(List<T> list)
        {
            this.list = list;
        }

        public static T FindMaxList(List<T> list)
        {
            list.Sort();
            Console.WriteLine("Sorted Values :");
            foreach (T items in list)
            {
                Console.Write(" " + items);
            }
            Console.WriteLine("\nMax Value : ");
            return list.Last();
     
        }
    }
}

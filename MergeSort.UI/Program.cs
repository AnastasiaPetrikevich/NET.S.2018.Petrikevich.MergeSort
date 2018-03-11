using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MergeSort.Logic;

namespace MergeSort.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[] { 12, 6, -122, 5, 890, -3, 24, 89, 4, -76, 0 };
            string[] secondArray = new string[] { "one", "two", "three", "four", "five", "six" };

            ArraySort<int>.Sort(firstArray, new IntComparer());
            ArraySort<string>.Sort(secondArray, new StringComparer());
            Display(firstArray);
            Display(secondArray);
            Console.ReadKey();
        }

        public static void Display<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write((array[i]) + " ");
            }
            Console.WriteLine();
        }
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort.Logic
{
    public class ArraySort<T>
    {
        public static void Sort(T[] array, IComparer<T> comparer)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (comparer == null)
            {                
                throw new ArgumentNullException(nameof(comparer));               
            }

            if (array.Length <= 1)
            {
                return;
            }

            Array.Copy(MergeSort(array, comparer), array, array.Length);
        }

        public static T[] MergeSort(T[] array, IComparer<T> comparer)
        {
            if (array.Length == 1)
            {
                return array;
            }

            int midle = array.Length / 2;
            return Merge(MergeSort(array.Take(midle).ToArray(), comparer), MergeSort(array.Skip(midle).ToArray(), comparer), comparer);

        }
        private static T[] Merge(T[] firstArray, T[] secondArray, IComparer<T> comparer)
        {

            int right = 0;
            int left = 0;
            T[] merged = new T[firstArray.Length + secondArray.Length];

            for (int i = 0; i < firstArray.Length + secondArray.Length; i++)
            {
                if (right < secondArray.Length && left < firstArray.Length)
                {
                    if (comparer.Compare(firstArray[left], secondArray[right]) > 0)
                    {
                        merged[i] = secondArray[right++];
                    }
                    else
                    {
                        merged[i] = firstArray[left++];
                    }
                }
                else
                {
                    if (right < secondArray.Length)
                    {
                        merged[i] = secondArray[right++];
                    }
                    else
                    {
                        merged[i] = firstArray[left++];
                    }
                }
            }
            return merged;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort.UI
{
    class IntComparer : IComparer<int>
    {
        public int Compare(int a, int b)
        {
            if (a < b)
            {
                return -1;
            }

            if (a > b)
            {
                return 1;
            }

            return 0;

        }
    }
    class StringComparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            if (a.Length < b.Length)
            {
                return -1;
            }

            if (a.Length > b.Length)
            {
                return 1;
            }

            return 0;

        }
    }
}


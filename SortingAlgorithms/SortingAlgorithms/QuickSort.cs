using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class QuickSort
    {
        private int[] array;
        public QuickSort(int[] inarray)
        {
            array = inarray;
            quickSort(array, 0, array.Length -1);
        }

        public int[] Array
        {
            get
            {
                return array;
            }
        }

        public void quickSort(int[] a, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = partition(a, lo, hi);
                quickSort(a, lo, p - 1);
                quickSort(a, p + 1, hi);
            }
        }

        int partition(int[] a, int lo, int hi)
        {
            int pivot = a[hi];
            int i = lo;
            for (int j = lo; j <= (hi - 1); j++)
            {
                if (a[j] <= pivot)
                {
                    int swap = a[i];
                    a[i] = a[j];
                    a[j] = swap;
                    i++;
                }
            }
            int temp = a[i];
            a[i] = a[hi];
            a[hi] = temp;
            return i;
        }

        public override string ToString()
        {
            string builder = "";
            int i = 0;
            do
            {
                builder += array[i] + ",";
                i++;
            }
            while (i < array.Length);

            return builder;
        }
    }
}

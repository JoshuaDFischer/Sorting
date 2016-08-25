using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class InsertionSort
    {
        private int[] array;

        public InsertionSort(int [] inArray)
        {
            array = inArray;
            sort();
        }

        public int[] Array
        {
            get
            {
                return array;
            }
        }

        void sort()
        {
            for (int j = 1; j < array.Length; ++j)
            {
                int key = array[j];
                int i = j - 1;
                while (i >= 0 && array[i] > key)
                {
                    array[i + 1] = array[i];
                    i--;
                }
                array[i + 1] = key;

            }
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

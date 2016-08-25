using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class MergeSort
    {
        private int[] array;
        public MergeSort(int[] inarray)
        {
            array = inarray;
            mergeSort(array);
        }

        public int[] Array
        {
            get
            {
                return array;
            }
        }

        void mergeSort(int [] array)
        {
            if (array.Length > 1)
            {
                int[] B = new int[array.Length / 2];
                int[] C;
                //if input array is odd then the 2nd sub array will have the odd count
                if (array.Length % 2 == 1)
                    C = new int[array.Length / 2 + 1];
                else
                    C = new int[array.Length / 2];

                int i = 0;

                while (i < array.Length / 2)
                {
                    B[i] = array[i];
                    i++;
                }
                while (i < array.Length)
                {
                    C[i - (array.Length / 2)] = array[i];
                    i++;
                }
                mergeSort(B);
                mergeSort(C);
                merge(B, C, array);

            }
        }

        private void merge(int[] B, int[] C, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < B.Length && j < C.Length)
            {
                if (B[i] <= C[j])
                {
                    arr[k] = B[i];
                    i++;
                    k++;
                }
                else
                {
                    arr[k] = C[j];
                    j++;
                    k++;
                }
            }

            if (i == B.Length)
            {
                while (j < C.Length)
                {
                    arr[k] = C[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i < B.Length)
                {
                    arr[k] = B[i];
                    i++;
                    k++;
                }
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

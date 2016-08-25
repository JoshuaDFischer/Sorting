using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static int[] unsortedArray;
        static void Main(string[] args)
        {
            buildUnsortedArray(10);
            RunSorts();

            buildUnsortedArray(10000);
            RunSorts();


            Console.ReadKey();
        }

       static void buildUnsortedArray(int size)
        {
            Random rnd1 = new Random();
            
            unsortedArray = new int[size];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = rnd1.Next(0, size);
            }
        }

        static void RunSorts()
        {
            var watch = new System.Diagnostics.Stopwatch();
            Console.WriteLine("Unsorted int array size of {0}", unsortedArray.Length);

            watch.Start();
            InsertionSort ISort = new InsertionSort(unsortedArray);
            watch.Stop();

            Console.WriteLine("Insertion Sort - Ticks/ Time in Milliseconds spent to create object and sort the array: " + watch.Elapsed.Ticks);
            watch.Reset();

            watch.Start();
            MergeSort MSort = new MergeSort(unsortedArray);
            watch.Stop();

            Console.WriteLine("Merge Sort - Ticks/ Time in Milliseconds spent to create object and sort the array: " + watch.Elapsed.Ticks);

            watch.Reset();

            watch.Start();
            QuickSort QSort = new QuickSort(unsortedArray);
            watch.Stop();

            Console.WriteLine("Quick Sort - Ticks/ Time in Milliseconds spent to create object and sort the array: " + watch.Elapsed.Ticks);
            


            watch.Reset();
            watch.Start();
            Array.Sort(unsortedArray);
            watch.Stop();

            //This method uses the Array.Sort method, which applies the introspective sort as follows:
            //•If the partition size is fewer than 16 elements, it uses an insertion sort algorithm.
            //•If the number of partitions exceeds 2 * LogN, where N is the range of the input array, it uses a Heapsort algorithm.
            //•Otherwise, it uses a Quicksort algorithm.

            Console.WriteLine(".Net Sort - Ticks/ Time in Milliseconds spent to create object and sort the array: " + watch.Elapsed.Ticks);

        }
    }
}

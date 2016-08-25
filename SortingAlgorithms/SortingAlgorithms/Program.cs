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
            var watch = System.Diagnostics.Stopwatch.StartNew();
            InsertionSort ISort = new InsertionSort(unsortedArray);
            watch.Stop();

            
            Console.WriteLine("Unsorted int array size of {0}", unsortedArray.Length);
            Console.WriteLine("Insertion Sort - Ticks/ Time in Milliseconds spent to create object and sort the array: " + watch.Elapsed.Ticks);

            watch.Reset();
            watch.Start();
            Array.Sort(unsortedArray);
            watch.Stop();

           //This method uses the Array.Sort method, which applies the introspective sort as follows:
          //•If the partition size is fewer than 16 elements, it uses an insertion sort algorithm.
          //•If the number of partitions exceeds 2 * LogN, where N is the range of the input array, it uses a Heapsort algorithm.
          //•Otherwise, it uses a Quicksort algorithm.

            Console.WriteLine(".Net Sort - Ticks/ Time in Milliseconds spent to create object and sort the array: " + watch.Elapsed.Ticks);


            Console.ReadKey();
        }

       void buildUnsortedArray()
        {
            Random rnd1 = new Random();

            unsortedArray = new int[10000];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = rnd1.Next(0, 1000);
            }
        }
    }
}

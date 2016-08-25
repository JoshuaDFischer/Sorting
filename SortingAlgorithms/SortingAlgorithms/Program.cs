using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] unsortedArray;
            Random rnd1 = new Random();

            unsortedArray = new int[1000];
            for(int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = rnd1.Next(0,1000);
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            InsertionSort ISort = new InsertionSort(unsortedArray);
            watch.Stop(); 
            
            //Console.WriteLine("Sorted Array with Insertion Sort: " + ISort.ToString());
            Console.WriteLine("Time spent to create object and sort the array: " + watch.Elapsed);
            Console.WriteLine("Ticks spent to create object and sort the array: " + watch.Elapsed.Ticks);

            Console.ReadKey();
        }

       
    }
}

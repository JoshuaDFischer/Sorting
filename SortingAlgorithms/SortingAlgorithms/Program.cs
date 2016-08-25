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
            int[] arr = { 2, 3, 4, 1, 6, 4, 12, 16 };
            InsertionSort ISort = new InsertionSort(arr);


            var builder = new StringBuilder();
            Array.ForEach(ISort.Array, x => builder.Append(x + ","));
            var res = builder.ToString();

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

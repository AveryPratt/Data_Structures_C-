using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
			Sorter<int> sorter = new Sorter<int>((a, b) => a > b ? 1 : b > a ? -1 : 0);
			IEnumerable<int> sorted = sorter.MergeSort(new int[] { 4, 8, 3, 0, 5, 1, 7, 9, 6, 2 });
			foreach (int val in sorted)
			{
				Console.WriteLine(val);
			}
			Console.ReadLine();
		}
    }
}
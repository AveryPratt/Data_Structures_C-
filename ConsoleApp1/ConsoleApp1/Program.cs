using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
			Heap<int> heap = new Heap<int>((i, j) => i > j ? -1 : j > i ? 1 : 0);
			heap.Push(4);
			heap.Push(6);
			heap.Push(8);
			heap.Push(2);
			heap.Push(5);
			heap.Push(1);
			heap.Push(9);
			heap.Push(3);
			heap.Push(7);
			Console.WriteLine("values added.");
			while (heap.Values.Count > 0)
			{
				Console.WriteLine(heap.Pop());
			}
			Console.ReadLine();
		}
    }
}
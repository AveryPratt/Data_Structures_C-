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
			PriorityQueue<string> queue = new PriorityQueue<string>();
			Random rand = new Random();
			for (int i = 0; i < 1000; i++)
			{
				var val = rand.Next();
				queue.Insert(val.ToString(), val);
			}
			while (queue.Heap.Values.Count > 0)
			{
				Console.WriteLine(queue.Pop());
			}
			Console.ReadLine();
		}
    }
}
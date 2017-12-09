using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
	public class Heap<T>
	{
		public List<T> Values { get; internal set; }
		public Comparison<T> Comparer { get; internal set; }

		public Heap(Comparison<T> comp, IEnumerable<T> values = null)
		{
			Comparer = comp;
			Values = new List<T>();
			if(values != null)
			{
				foreach (T item in values)
				{
					Push(item);
				}
			}
		}

		public override string ToString()
		{
			StringBuilder bldr = new StringBuilder();
			int idx = 1;
			while (idx <= Values.Count)
			{
				for (int i = 0; i < idx; i++)
				{
					if (idx + i - 1 >= Values.Count)
					{
						break;
					}
					bldr.Append(Values[idx + i - 1] + " ");
				}
				bldr.Append("\n");
				idx *= 2;
			}
			return bldr.ToString();
		}

		/// <summary>
		/// Adds a value to the heap.
		/// </summary>
		/// <param name="data"></param>
		public void Push(T data)
		{
			int idx = Values.Count;
			Values.Add(data);
			sink(idx);
		}

		/// <summary>
		/// Removes the highest priority object from the heap.
		/// </summary>
		/// <returns></returns>
		public T Pop()
		{
			if (Values.Count == 0)
			{
				throw new InvalidOperationException("Cannot pop from an empty heap.");
			}
			T val = Values[0];
			bubble(0);
			return val;
		}

		private void sink(int idx)
		{
			while (idx > 0 && Comparer(Values[idx], Values[(idx - 1) / 2]) == 1)
			{
				T temp = Values[idx];
				Values[idx] = Values[(idx - 1) / 2];
				Values[(idx - 1) / 2] = temp;
				idx = (idx - 1) / 2;
			}
		}

		private void bubble(int idx)
		{
			while (Values.Count >= idx * 2 + 2)
			{
				if (Values.Count != idx * 2 + 2 && Comparer(Values[idx * 2 + 2], Values[idx * 2 + 1]) == 1)
				{
					Values[idx] = Values[idx * 2 + 2];
					idx = idx * 2 + 2;
				}
				else
				{
					Values[idx] = Values[idx * 2 + 1];
					idx = idx * 2 + 1;
				}
			}
			Values.RemoveAt(idx);
			for (int i = idx; i < Values.Count; i++)
			{
				sink(i);
			}
		}
	}
}

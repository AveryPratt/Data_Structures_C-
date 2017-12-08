using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Queue<T>
    {
        public DoublyLinkedList<T> List { get; set; }

		public Queue()
		{
			List = new DoublyLinkedList<T>();
		}

        public void Enqueue(T val)
        {
            this.List.Push(val);
        }
        
        public T Dequeue()
        {
			if (this.List.Tail == null)
			{
				throw new InvalidOperationException("Cannot dequeue from an empty queue.");
			}
            return this.List.Shift();
        }

        public int Size()
        {
            int count = 0;
            DoublyLinkedListNode<T> cur = List.Head;
            while (cur != null)
            {
                cur = cur.Next;
                count++;
            }
            return count;
        }

        public T Peek()
        {
			if (List.Tail == null)
			{
				throw new InvalidOperationException("Cannot peek from an empty queue.");
			}
            return List.Tail.Data;
        }
    }
}

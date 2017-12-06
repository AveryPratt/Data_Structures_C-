using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Queue<T>
    {
        public DoublyLinkedList<T> List { get; set; }

        public void Enqueue(T val)
        {
            this.List.Append(val);
        }
        
        public T Dequeue()
        {
            return this.List.Shift().Data;
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
            return List.Tail.Data;
        }
    }
}

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }
        public T Data { get; set; }

        public DoublyLinkedListNode(T data)
        {
            this.Data = data;
        }
    }

    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        public void Push(T val)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(val);
            this.Head.Next = newNode;
            newNode.Previous = this.Head;
            this.Head = newNode;
        }

        public void Append(T val)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(val);
            this.Tail.Previous = newNode;
            newNode.Next = this.Tail;
            this.Tail = newNode;
        }

        public DoublyLinkedListNode<T> Pop()
        {
            DoublyLinkedListNode<T> node = this.Head;
            this.Head = this.Head.Next;
            this.Head.Previous = null;
            node.Next = null;
            return node;
        }

        public DoublyLinkedListNode<T> Shift()
        {
            DoublyLinkedListNode<T> node = this.Tail;
            this.Tail = this.Tail.Previous;
            this.Tail.Next = null;
            node.Previous = null;
            return node;
        }

        public DoublyLinkedListNode<T> Search(T val)
        {
            DoublyLinkedListNode<T> cur = this.Head;
            while (cur != null && cur.Data == null ? val != null : !cur.Data.Equals(val))
            {
                cur = cur.Next;
            }
            return cur;
        }

        public void Remove(DoublyLinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

            if (node.Next != null)
            {
                node.Next.Previous = node.Previous;
            }
            if (node.Previous != null)
            {
                node.Previous.Next = node.Next;
            }
            node.Next = null;
            node.Previous = null;
        }
    }
}

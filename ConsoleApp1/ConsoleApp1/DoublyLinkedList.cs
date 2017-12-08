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
        public DoublyLinkedListNode<T> Head { get; private set; }
        public DoublyLinkedListNode<T> Tail { get; private set; }

		/// <summary>
		/// Adds a node containing the value to the Head of the list.
		/// </summary>
		/// <param name="val"></param>
        public void Push(T val)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(val);
			if (this.Head != null)
			{
				this.Head.Previous = newNode;
			}
			else
			{
				this.Tail = newNode;
			}
            newNode.Next = this.Head;
            this.Head = newNode;
        }

		/// <summary>
		/// Adds a node containing the value to the Tail of the list.
		/// </summary>
		/// <param name="val"></param>
		public void Append(T val)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(val);
			if (this.Tail != null)
			{
				this.Tail.Next = newNode;
			}
			else
			{
				this.Head = newNode;
			}
            newNode.Previous = this.Tail;
            this.Tail = newNode;
        }

		/// <summary>
		/// Removes the node at the Head of the list and returns its value.
		/// </summary>
		/// <returns></returns>
        public T Pop()
        {
            DoublyLinkedListNode<T> node = this.Head;
            this.Head = this.Head.Next;
            this.Head.Previous = null;
            node.Next = null;
            return node.Data;
        }

		/// <summary>
		/// Removes the node at the Tail of the list and returns its value.
		/// </summary>
		/// <returns></returns>
		public T Shift()
        {
            DoublyLinkedListNode<T> node = this.Tail;
            this.Tail = this.Tail.Previous;
            this.Tail.Next = null;
            node.Previous = null;
            return node.Data;
        }

		/// <summary>
		/// Returns the node containing the value that is closest to the Head of the list.
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
        public DoublyLinkedListNode<T> Search(T val)
        {
            DoublyLinkedListNode<T> cur = this.Head;
			while (cur != null)
			{
				if (cur.Data == null ? val != null : !cur.Data.Equals(val))
				{
					cur = cur.Next;
				}
				else
				{
					return cur;
				}
			}
			return null;
		}

		/// <summary>
		/// Removes the node from the list.
		/// </summary>
		/// <param name="node"></param>
        public void Remove(DoublyLinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

			if (node == this.Head)
			{
				this.Head.Next.Previous = null;
				this.Head = this.Head.Next;
				return;
			}
			if (node == this.Tail)
			{
				this.Tail.Previous.Next = null;
				this.Tail = this.Tail.Previous;
				return;
			}

            if (node.Next != null)
            {
                node.Next.Previous = node.Previous;
            }
            if (node.Previous != null)
            {
                node.Previous.Next = node.Next;
            }
        }
    }
}

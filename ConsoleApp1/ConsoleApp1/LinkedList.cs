using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next { get; set; }
        public T Data { get; set; }

        public LinkedListNode(T data)
        {
            this.Data = data;
        }
    }

    public class LinkedList<T>
    {
        /// <summary>
        /// Gets the LinkedListNode at the top of the list.
        /// </summary>
        public LinkedListNode<T> Head { get; private set; }

        /// <summary>
        /// Adds a new node to the list with the value as the node's Data.
        /// </summary>
        /// <param name="val"></param>
        public void Push(T val)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(val);
            newNode.Next = this.Head;
            this.Head = newNode;
        }

        /// <summary>
        /// Removes the Head of the list and returns the Data.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T val = this.Head.Data;
            this.Head = this.Head.Next;
            return val;
        }

        /// <summary>
        /// Returns the size of the list.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int count = 0;
            LinkedListNode<T> cur = this.Head;
            while (cur != null)
            {
                cur = cur.Next;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Returns the node containing the value as the node's Data, or returns null if there is no such node on the list.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public LinkedListNode<T> Search(T val)
        {
            LinkedListNode<T> cur = this.Head;
            while (cur != null && cur.Data == null ? val != null : !cur.Data.Equals(val))
            {
                cur = cur.Next;
            }   
            return cur;
        }

        /// <summary>
        /// Removes a particular node from the list.
        /// </summary>
        /// <param name="node"></param>
        public void Remove(LinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }

            if (node == this.Head)
            {
                this.Head = this.Head.Next;
                return;
            }
            LinkedListNode<T> cur = this.Head;
            if (this.Head != null)
            {
                while (cur.Next != node)
                {
                    cur = cur.Next;
                }
                cur.Next = node.Next;
            }
        }

        /// <summary>
        /// Returns a string representation of the data for each node in the list, starting from the Head.
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            StringBuilder bldr = new StringBuilder();
            bldr.Append("(");
            LinkedListNode<T> cur = this.Head;
            while (cur != null)
            {
                if (cur.Data == null)
                {
                    bldr.Append("null");
                }
                else
                {
                    bldr.Append(cur.Data.ToString());
                }
                if (cur.Next != null)
                {
                    bldr.Append(", ");
                }
                cur = cur.Next;
            }
            bldr.Append(")");
            return bldr.ToString();
        }
    }
}

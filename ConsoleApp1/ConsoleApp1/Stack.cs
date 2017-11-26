using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Stack<T>
    {
        public LinkedList<T> List { get; private set; }

        public void Push(T val)
        {
            this.List.Push(val);
        }

        public T Pop()
        {
            return this.List.Pop();
        }
    }
}

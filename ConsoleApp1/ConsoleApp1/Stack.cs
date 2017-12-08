using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack<T>
    {
        public LinkedList<T> List { get; private set; }

		public Stack()
		{
			List = new LinkedList<T>();
		}

        public void Push(T val)
        {
            List.Push(val);
        }

        public T Pop()
        {
			if (List.Size() == 0)
			{
				throw new InvalidOperationException("Cannot pop from an empty stack.");
			}
            return List.Pop();
        }
    }
}

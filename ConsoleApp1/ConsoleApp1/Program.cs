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
            LinkedList<string> intList = new LinkedList<string>();
            for (int i = 0; i < 10; i++)
            {
                intList.Push(i.ToString());
            }
            intList.Push(null);
            Console.WriteLine("size: {0}", intList.Size());
            Console.WriteLine("display: {0}", intList.Display());
            Console.WriteLine("searching for node with Data of 5: {0}", intList.Search("5"));
            Console.WriteLine("removing null...");
            intList.Remove(intList.Search(null));
            Console.WriteLine("size: {0}", intList.Size());
            Console.WriteLine("display: {0}", intList.Display());
            Console.ReadLine();
        }
    }
}
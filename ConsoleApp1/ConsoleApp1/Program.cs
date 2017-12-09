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
			Trie trie = new Trie();
			trie.Insert("hi");
			trie.Insert("ha");
			trie.Insert("apple");
			trie.Insert("hello");
			Console.WriteLine(trie.GetValues());
			Console.ReadLine();
		}
    }
}
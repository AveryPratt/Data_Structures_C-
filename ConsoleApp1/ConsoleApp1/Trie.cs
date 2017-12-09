using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
	public class TrieNode
	{
		public int Depth { get; set; }
		public TrieNode Parent { get; set; }
		public Dictionary<char, TrieNode> Children { get; set; }
		public bool IsEnd { get; set; }

		public TrieNode(int depth, TrieNode parent)
		{
			Depth = depth;
			Parent = parent;
			Children = new Dictionary<char, TrieNode>();
			IsEnd = false;
		}
	}

	public class Trie : IEnumerable<string>
	{
		public TrieNode Head { get; set; }

		public Trie()
		{
			Head = new TrieNode(-1, null);
		}

		/// <summary>
		/// Adds a branch to the trie corresponding to the string.
		/// </summary>
		/// <param name="val"></param>
		public void Insert(string val)
		{
			TrieNode parent = Head;
			for (int i = 0; i < val.Length; i++)
			{
				if (!parent.Children.Keys.Contains(val[i]))
				{
					TrieNode newParent = new TrieNode(i, parent);
					parent.Children[val[i]] = newParent;
					parent = newParent;
				}
				else
				{
					parent = parent.Children[val[i]];
				}
			}
			parent.IsEnd = true;
		}

		/// <summary>
		/// Returns whether or not a string is contained in the trie.
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		public bool Contains(string val)
		{
			TrieNode parent = Head;
			for (int i = 0; i < val.Length; i++)
			{
				if (!parent.Children.Keys.Contains(val[i]))
				{
					return false;
				}
				else
				{
					parent = parent.Children[val[i]];
				}
			}
			return parent.IsEnd;
		}

		/// <summary>
		/// Returns the number of branches in the trie.
		/// </summary>
		/// <returns></returns>
		public int Size()
		{
			int count = 0;
			foreach (string val in this)
			{
				count++;
			}
			return count;
		}

		/// <summary>
		/// Removes a string from the trie.
		/// </summary>
		/// <param name="val"></param>
		public void Remove(string val)
		{
			if (String.IsNullOrEmpty(val))
			{
				throw new ArgumentException("Value must be a non-empty string.");
			}
			TrieNode last = Head;
			char lastVal = ' ';
			bool cut = false;
			TrieNode parent = Head;
			for (int i = 0; i < val.Length; i++)
			{
				if (!parent.Children.Keys.Contains(val[i]) || (i == val.Length - 1 && !parent.Children[val[i]].IsEnd))
				{
					throw new InvalidOperationException(String.Format("Value \"{0}\" doesn't exist in trie.", val));
				}
				if (parent.IsEnd || parent.Children.Count > 1)
				{
					last = parent;
					lastVal = val[i];
				}
				parent = parent.Children[val[i]];
				if (i == val.Length - 1)
				{
					parent.IsEnd = false;
					if (parent.Children.Count == 0)
					{
						cut = true;
					}
				}
			}
			if (cut)
			{
				last.Children.Remove(lastVal);
			}
		}

		public IEnumerator<string> GetEnumerator()
		{
			StringBuilder bldr = new StringBuilder();
			Stack<Tuple<TrieNode, char?>> stack = new Stack<Tuple<TrieNode, char?>>();
			stack.Push(new Tuple<TrieNode, char?>(Head, null));
			while (stack.List.Size() > 0)
			{
				Tuple<TrieNode, char?> cur = stack.Pop();
				bldr.Append(cur.Item2);
				if (cur.Item1.IsEnd)
				{
					yield return bldr.ToString();
					int idx = stack.List.Head.Data.Item1.Depth;
					bldr.Remove(idx, bldr.Length - idx);
				}
				foreach (char key in cur.Item1.Children.Keys)
				{
					stack.Push(new Tuple<TrieNode, char?>(cur.Item1.Children[key], key));
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}

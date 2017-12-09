using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace UnitTestProject1
{
	[TestClass]
	public class PriorityQueueTests
	{
		[TestMethod]
		public void TestPriorityQueueInsert()
		{
			PriorityQueue<string> queue = new PriorityQueue<string>();
			queue.Insert("second", 2);
			queue.Insert("seventh", 7);
			queue.Insert("first", 1);
			queue.Insert("third", 3);
			queue.Insert("sixth", 6);
			queue.Insert("ninth", 9);
			queue.Insert("zeroth");
			queue.Insert("fourth", 4);
			queue.Insert("eighth", 8);
			queue.Insert("fifth", 5);
			Assert.AreEqual(queue.Heap.Values.Count, 10);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestPriorityQueuePopEmpty()
		{
			PriorityQueue<string> queue = new PriorityQueue<string>();
			queue.Pop();
		}

		[TestMethod]
		public void TestPriorityQueuePopOnce()
		{
			PriorityQueue<string> queue = new PriorityQueue<string>();
			queue.Insert("second", 2);
			queue.Insert("seventh", 7);
			queue.Insert("first", 1);
			queue.Insert("third", 3);
			queue.Insert("sixth", 6);
			queue.Insert("ninth", 9);
			queue.Insert("zeroth");
			queue.Insert("fourth", 4);
			queue.Insert("eighth", 8);
			queue.Insert("fifth", 5);
			Assert.AreEqual(queue.Pop(), "ninth");
		}

		[TestMethod]
		public void TestPriorityQueuePopTwice()
		{
			PriorityQueue<string> queue = new PriorityQueue<string>();
			queue.Insert("second", 2);
			queue.Insert("seventh", 7);
			queue.Insert("first", 1);
			queue.Insert("third", 3);
			queue.Insert("sixth", 6);
			queue.Insert("ninth", 9);
			queue.Insert("zeroth");
			queue.Insert("fourth", 4);
			queue.Insert("eighth", 8);
			queue.Insert("fifth", 5);
			queue.Pop();
			Assert.AreEqual(queue.Pop(), "eighth");
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestPriorityQueuePeekEmpty()
		{
			PriorityQueue<string> queue = new PriorityQueue<string>();
			queue.Peek();
		}

		[TestMethod]
		public void TestPriorityQueuePeekOnce()
		{
			PriorityQueue<string> queue = new PriorityQueue<string>();
			queue.Insert("second", 2);
			queue.Insert("seventh", 7);
			queue.Insert("first", 1);
			queue.Insert("third", 3);
			queue.Insert("sixth", 6);
			queue.Insert("ninth", 9);
			queue.Insert("zeroth");
			queue.Insert("fourth", 4);
			queue.Insert("eighth", 8);
			queue.Insert("fifth", 5);
			Assert.AreEqual(queue.Peek(), "ninth");
		}

		[TestMethod]
		public void TestPriorityQueuePeekTwice()
		{
			PriorityQueue<string> queue = new PriorityQueue<string>();
			queue.Insert("second", 2);
			queue.Insert("seventh", 7);
			queue.Insert("first", 1);
			queue.Insert("third", 3);
			queue.Insert("sixth", 6);
			queue.Insert("ninth", 9);
			queue.Insert("zeroth");
			queue.Insert("fourth", 4);
			queue.Insert("eighth", 8);
			queue.Insert("fifth", 5);
			queue.Peek();
			Assert.AreEqual(queue.Peek(), "ninth");
		}
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace UnitTestProject1
{
	[TestClass]
	public class QueueTests
	{
		[TestMethod]
		public void TestQueueEnqueue()
		{
			Queue<string> queue = new Queue<string>();
			queue.Insert("first");
			queue.Insert("second");
			queue.Insert("third");
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestQueueDequeueEmpty()
		{
			Queue<string> queue = new Queue<string>();
			queue.Pop();
		}

		[TestMethod]
		public void TestQueueDequeueOnce()
		{
			Queue<string> queue = new Queue<string>();
			queue.Insert("first");
			queue.Insert("second");
			queue.Insert("third");
			Assert.AreEqual(queue.Pop(), "first");
		}

		[TestMethod]
		public void TestQueueDequeueTwice()
		{
			Queue<string> queue = new Queue<string>();
			queue.Insert("first");
			queue.Insert("second");
			queue.Insert("third");
			queue.Pop();
			Assert.AreEqual(queue.Pop(), "second");
		}

		[TestMethod]
		public void TestQueueSize()
		{
			Queue<string> queue = new Queue<string>();
			queue.Insert("first");
			queue.Insert("second");
			queue.Insert("third");
			Assert.AreEqual(queue.Size(), 3);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void TestQueuePeekEmpty()
		{
			Queue<string> queue = new Queue<string>();
			Assert.IsNull(queue.Peek());
		}

		[TestMethod]
		public void TestQueuePeekOnce()
		{
			Queue<string> queue = new Queue<string>();
			queue.Insert("first");
			queue.Insert("second");
			queue.Insert("third");
			Assert.AreEqual(queue.Peek(), "first");
		}

		[TestMethod]
		public void TestQueuePeekTwice()
		{
			Queue<string> queue = new Queue<string>();
			queue.Insert("first");
			queue.Insert("second");
			queue.Insert("third");
			queue.Peek();
			Assert.AreEqual(queue.Peek(), "first");
		}
	}
}

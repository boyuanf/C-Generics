using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectIt.Tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void Can_Peek_at_next_item()
        {
            var queue = new Queue<int>();
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Dequeue();
            Assert.AreEqual(12,queue.Peek());
            Assert.IsTrue(queue.Contains(13));

            queue.Enqueue(15);
            var asArray = queue.ToArray();
            queue.Dequeue();

            Assert.AreEqual(12,asArray[0]);
            Assert.AreEqual(2, queue.Count);

        }
    }
}

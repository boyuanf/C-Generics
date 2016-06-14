using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectIt.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Can_Peek_at_next_item()
        {
            var stack=new Stack<int>();
            stack.Push(11);
            stack.Push(22);
            stack.Push(33);

            Assert.AreEqual(33,stack.Peek());
            Assert.IsTrue(stack.Contains(22));

            var asArray = stack.ToArray();
            stack.Pop();

            Assert.AreEqual(33, asArray[0]);
            Assert.AreEqual(2, stack.Count);

        }
    }
}

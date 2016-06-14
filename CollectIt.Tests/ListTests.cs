using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectIt.Tests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void A_List_Can_Insert()
        {
            List<int> alist = new List<int>()
            {1, 2, 3, 4, 5};
            alist.Add(6);
            alist.Insert(1,20);
            Assert.AreEqual(20,alist[1]);
        }

        [TestMethod]
        public void A_List_Can_Remove()
        {
            List<int> alist = new List<int>() { 1, 2, 3};
            alist.Remove(2);
            
            Assert.IsTrue(alist.SequenceEqual(new []{1,3}));
        }

        [TestMethod]
        public void A_List_Can_Find()
        {
            List<int> alist = new List<int>() { 1, 2, 3 };
            Assert.AreEqual(alist.IndexOf(3),2);
            Assert.AreEqual(alist.Count,3);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectIt.Tests
{
    [TestClass]
    public class SortedListTests
    {
        [TestMethod]
        public void Can_Use_Sorted_list()
        {
            var list=new SortedList<int, string>();
            list.Add(3, "Three");
            list.Add(1, "One");
            list.Add(2, "Two");


            Assert.AreEqual(0, list.IndexOfKey(1));
            Assert.AreEqual("Two", list[2]);
            Assert.AreEqual(2, list.IndexOfValue("Three"));
        }

        [TestMethod]
        public void Can_Use_Sorted_set()
        {
            var set=new SortedSet<int>();

            set.Add(33);
            set.Add(11);
            set.Add(22);

            


            var enumerator = set.GetEnumerator();
           // Assert.AreEqual(enumerator.Current, 0);
            enumerator.MoveNext();
            Assert.AreEqual(enumerator.Current,11);
            enumerator.MoveNext();
            Assert.AreEqual(22, enumerator.Current);
            enumerator.MoveNext();
            Assert.AreEqual(33, enumerator.Current);
        }
    }
}

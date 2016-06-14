using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectIt.Tests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void Can_Use_Dictionary_As_Map()
        {
            var map=new Dictionary<int,string>();
            map.Add(1,"one");
            map.Add(2,"two");
            map.Add(3, "three");

            Assert.AreEqual("one",map[1]);

            Assert.IsTrue(map.ContainsKey(2));

            map.Remove(1);
            Assert.AreEqual(2,map.Count);
        }
    }
}

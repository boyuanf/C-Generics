using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectIt.Tests
{
    [TestClass]
    public class HashsetTests
    {
        [TestMethod]
        public void Intersect_Sets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.IntersectWith(set2);

            Assert.IsTrue(set1.SequenceEqual(new[] { 2, 3 }));
            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));

            set1.Clear();
            set2.Clear();

            set1 = new HashSet<int>() { 1, 2, 3 };
            set2 = new HashSet<int>() { 2, 3, 4 };

            set1.UnionWith(set2);
            
            Assert.IsTrue(set1.SetEquals(new []{1,2,3,4}));

            set1.Clear();
            set2.Clear();

            set1 = new HashSet<int>() { 1, 2, 3 };
            set2 = new HashSet<int>() { 2, 3, 4 };

            set1.SymmetricExceptWith(set2);

            Assert.IsTrue(set1.SetEquals(new []{1,4}));

        }
    }
}

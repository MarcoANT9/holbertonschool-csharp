using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        // 1
        [Test]
        public void empty_list()
        {
            List<int> this_list = new List<int>(5);
            int result = Operations.Max(this_list);
            Assert.AreEqual(0, result);
        }
        // 2
        [Test]
        public void null_list()
        {
            List<int> this_list = null;
            int result = Operations.Max(this_list);
            Assert.AreEqual(0, result);
        }
        // 3
        [Test]
        public void number_list_positive()
        {
            List<int> this_list = new List<int>();
            this_list.Add(2);
            this_list.Add(1);
            this_list.Add(21);
            this_list.Add(10);
            this_list.Add(15);
            int result = Operations.Max(this_list);
            Assert.AreEqual(21, result);
        }
        // 4
        [Test]
        public void number_list_negative()
        {
            List<int> this_list = new List<int>();
            this_list.Add(-2);
            this_list.Add(-1);
            this_list.Add(-21);
            this_list.Add(-10);
            this_list.Add(-15);
            int result = Operations.Max(this_list);
            Assert.AreEqual(-1, result);
        }
        // 5
        [Test]
        public void number_list_mixed()
        {
            List<int> this_list = new List<int>();
            this_list.Add(-2);
            this_list.Add(1);
            this_list.Add(-21);
            this_list.Add(10);
            this_list.Add(-15);
            int result = Operations.Max(this_list);
            Assert.AreEqual(10, result);
        }
    }
}
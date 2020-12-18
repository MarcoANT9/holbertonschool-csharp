using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void a_test()
        {
            string my_str = "this one";
            int result = Str.UniqueChar(my_str);
            Assert.AreEqual(-1, result);
        }

        [TestCase("this one", -1)]
        [TestCase("marco ant", 1)]
        [TestCase("anna", 0)]
        [TestCase("does this one have reppeated characters", 0)]
        [TestCase("", -1)]
        public void repeated_at_n(string my_str, int expected_index)
        {
            int result = Str.UniqueChar(my_str);
            Assert.AreEqual(expected_index, result);
        }
    }
}
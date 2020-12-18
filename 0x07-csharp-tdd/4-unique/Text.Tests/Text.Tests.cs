using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("this one", 0)]
        [TestCase("aaabccccc", 3)]
        [TestCase("annac", 4)]
        [TestCase("anna", -1)]
        [TestCase("", -1)]
        [TestCase("anacomparaenelcasino", 5)]
        [TestCase("aaaaaaabbbbbbbbc", 15)]
        public void repeated_at_n(string my_str, int expected_index)
        {
            int result = Str.UniqueChar(my_str);
            Assert.AreEqual(expected_index, result);
        }
    }
}
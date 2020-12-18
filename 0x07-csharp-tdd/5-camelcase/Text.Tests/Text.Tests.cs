using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("marcoAnt", 2)]
        [TestCase("marco", 1)]
        [TestCase("marcoAntonioNino", 3)]
        [TestCase("marcoantonioniñocalderon", 1)]
        [TestCase("marcoAntonioNinoCalderon", 4)]
        [TestCase("", 0)]
        public void camelCases(string my_string, int expected_words)
        {
            int result = Str.CamelCase(my_string);
            Assert.AreEqual(expected_words, result);
        }
    }
}
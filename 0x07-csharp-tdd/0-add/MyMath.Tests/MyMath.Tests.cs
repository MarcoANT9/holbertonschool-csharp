using NUnit.Framework;


namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(1, -1)]
        [TestCase(-2, -4)]
        [TestCase(2, 0)]
        [TestCase(0, -5)]
        [TestCase(0, 0)]
        public void Test1_A1_B1_Returns_2(int a, int b)
        {
            int result = Operations.Add(a, b);
            Assert.AreEqual(result, a + b);
        }
    }
}

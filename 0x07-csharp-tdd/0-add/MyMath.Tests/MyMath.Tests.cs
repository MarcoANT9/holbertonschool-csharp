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

        [TestCase(1, 1)]
        [TestCase(1, -1)]
        [TestCase(-2, -4)]
        [TestCase(2, 0)]
        [TestCase(0, -5)]
        [TestCase(0, 0)]
        public void Test_Returns_A_Plus_B(int a, int b)
        {
            int result = Operations.Add(a, b);
            Assert.AreEqual(a + b, result);
        }
    }
}

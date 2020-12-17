using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_zero()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] result = Matrix.Divide(matrix, 0);
            Assert.Null(result);
        }

        [TestCase(2)]
        [TestCase(-3)]
        public void test_Matrix_null(int value)
        {
            int[,] matrix = null;
            int[,] result = Matrix.Divide(matrix, 3);
            Assert.Null(result);
        }
        [Test]
        public void test_matrix_number()
        {
            int[,] matrix = {{2, 4}, {6, 8}};
            int[,] result = Matrix.Divide(matrix, 2);
            int[,] expected = {{1, 2}, {3, 4}};
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void test_matrix_negative()
        {
            int[,] matrix = {{3, 6, 9}, {12, 15, 18}};
            int n = -3;
            int[,] expected = {{-1, -2, -3}, {-4, -5, -6}};
            int[,] result = Matrix.Divide(matrix, n);
            Assert.AreEqual(expected, result);
        }
                [Test]
        public void test_matrix_negative_and_positive()
        {
            int[,] matrix = {{3, -6, 9}, {-12, 15, -18}};
            int n = -3;
            int[,] expected = {{-1, 2, -3}, {4, -5, 6}};
            int[,] result = Matrix.Divide(matrix, n);
            Assert.AreEqual(expected, result);
        }
    }
}
using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        // 1
        [Test]
        public void empty_text()
        {
            string my_str = "";
            bool result = str.IsPalindrome(my_str);
            Assert.IsTrue(result);
        }
        // 2
        [Test]
        public void not_palindrome()
        {
            string my_str = "What is this D:";
            bool result = str.IsPalindrome(my_str);
            Assert.IsFalse(result);
        }
        // 3
        [Test]
        public void palindrome_lower()
        {
            string my_str = "racecar";
            bool result = str.IsPalindrome(my_str);
            Assert.IsTrue(result);
        }
        // 4
        [Test]
        public void palindrome_Upper()
        {
            string my_str = "RACECAR";
            bool result = str.IsPalindrome(my_str);
            Assert.IsTrue(result);
        }
        // 5
        [Test]
        public void palindrome_mixed()
        {
            string my_str = "rAcECaR";
            bool result = str.IsPalindrome(my_str);
            Assert.IsTrue(result);
        }
        // 6
        [Test]
        public void palindrome_punctuation()
        {
            string my_str = "Anita; Lava la.Tina";
            bool result = str.IsPalindrome(my_str);
            Assert.IsTrue(result);
        }
        // 7
        [Test]
        public void null_str()
        {
            string my_str = null;
            bool result = str.IsPalindrome(my_str);
            Assert.IsTrue(result);
        }
    }
}
using Problems.Medium;

namespace ProblemTests.Medium
{
    [TestFixture]
    public class LongestSubstringRepeatingCharactersTests
    {
        [Test]
        public void Test_EmptyString_ReturnsZero()
        {
            string input = "";
            int result = LongestSubstringRepeatingCharacters.LengthOfLongestSubstring(input);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test_SingleCharacter_ReturnsOne()
        {
            string input = "a";
            int result = LongestSubstringRepeatingCharacters.LengthOfLongestSubstring(input);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_AllUniqueCharacters_ReturnsLengthOfString()
        {
            string input = "abcdef";
            int result = LongestSubstringRepeatingCharacters.LengthOfLongestSubstring(input);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Test_RepeatedCharacters_ReturnsCorrectLength()
        {
            string input = "abcabcbb";
            int result = LongestSubstringRepeatingCharacters.LengthOfLongestSubstring(input);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test_StringWithSpaces_ReturnsCorrectLength()
        {
            string input = "abc abcbb";
            int result = LongestSubstringRepeatingCharacters.LengthOfLongestSubstring(input);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Test_LongestSubstringAtEnd_ReturnsCorrectLength()
        {
            string input = "bbbbbabcdef";
            int result = LongestSubstringRepeatingCharacters.LengthOfLongestSubstring(input);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Test_AllSameCharacter_ReturnsOne()
        {
            string input = "aaaaaa";
            int result = LongestSubstringRepeatingCharacters.LengthOfLongestSubstring(input);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_StringWithSpecialCharacters_ReturnsCorrectLength()
        {
            string input = "a!@#$%^&*()";
            int result = LongestSubstringRepeatingCharacters.LengthOfLongestSubstring(input);
            Assert.That(result, Is.EqualTo(11));
        }

        [Test]
        public void Test_StringWithNumbers_ReturnsCorrectLength()
        {
            string input = "12312345123";
            int result = LongestSubstringRepeatingCharacters.LengthOfLongestSubstring(input);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}

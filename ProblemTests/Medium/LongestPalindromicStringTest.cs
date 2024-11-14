using Problems.Medium;

namespace ProblemTests.Medium
{
    [TestFixture]
    public class LongestPalindromicStringTests
    {
        [Test]
        public void LongestPalindrome_WithNormalInput_ReturnsCorrectResult()
        {
            // Arrange
            string input = "babad";

            // Act
            string result = LongestPalindromicString.LongestPalindrome(input);

            // Assert
            Assert.IsTrue(result == "bab" || result == "aba", $"Unexpected result: {result}");
        }

        [Test]
        public void LongestPalindrome_WithEvenLengthPalindrome_ReturnsCorrectResult()
        {
            // Arrange
            string input = "cbbd";

            // Act
            string result = LongestPalindromicString.LongestPalindrome(input);

            // Assert
            Assert.That(result, Is.EqualTo("bb"));
        }

        [Test]
        public void LongestPalindrome_WithSingleCharacter_ReturnsSameCharacter()
        {
            // Arrange
            string input = "a";

            // Act
            string result = LongestPalindromicString.LongestPalindrome(input);

            // Assert
            Assert.That(result, Is.EqualTo("a"));
        }

        [Test]
        public void LongestPalindrome_WithAllSameCharacters_ReturnsFullString()
        {
            // Arrange
            string input = "aaaaa";

            // Act
            string result = LongestPalindromicString.LongestPalindrome(input);

            // Assert
            Assert.That(result, Is.EqualTo("aaaaa"));
        }

        [Test]
        public void LongestPalindrome_WithNoPalindrome_ReturnsSingleCharacter()
        {
            // Arrange
            string input = "abcde";

            // Act
            string result = LongestPalindromicString.LongestPalindrome(input);

            // Assert
            Assert.That(result, Is.EqualTo("a"));
        }

        [Test]
        public void LongestPalindrome_WithSpaces_ReturnsCorrectResult()
        {
            // Arrange
            string input = "amanaplanacanalpanama";

            // Act
            string result = LongestPalindromicString.LongestPalindrome(input);

            // Assert
            Assert.That(result, Is.EqualTo("amanaplanacanalpanama"));
        }
    }
}

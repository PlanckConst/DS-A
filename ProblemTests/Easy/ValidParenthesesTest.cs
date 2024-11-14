using Problems.Easy;

namespace ProblemTests.Easy
{
    [TestFixture]
    public class ValidParenthesesTests
    {
        [Test]
        public void IsValid_WithValidParentheses_ReturnsTrue()
        {
            // Arrange
            string input = "()";

            // Act
            bool result = ValidParentheses.IsValid(input);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_WithMixedValidParentheses_ReturnsTrue()
        {
            // Arrange
            string input = "({[]})";

            // Act
            bool result = ValidParentheses.IsValid(input);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_WithNestedParentheses_ReturnsTrue()
        {
            // Arrange
            string input = "(([]){})";

            // Act
            bool result = ValidParentheses.IsValid(input);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_WithUnmatchedOpeningParentheses_ReturnsFalse()
        {
            // Arrange
            string input = "({[}";

            // Act
            bool result = ValidParentheses.IsValid(input);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_WithUnmatchedClosingParentheses_ReturnsFalse()
        {
            // Arrange
            string input = "({[]))";

            // Act
            bool result = ValidParentheses.IsValid(input);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_WithIncorrectOrder_ReturnsFalse()
        {
            // Arrange
            string input = "{[)]}";

            // Act
            bool result = ValidParentheses.IsValid(input);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_WithSingleOpeningBracket_ReturnsFalse()
        {
            // Arrange
            string input = "(";

            // Act
            bool result = ValidParentheses.IsValid(input);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_WithSingleClosingBracket_ReturnsFalse()
        {
            // Arrange
            string input = "]";

            // Act
            bool result = ValidParentheses.IsValid(input);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_WithEmptyString_ReturnsTrue()
        {
            // Arrange
            string input = "";

            // Act
            bool result = ValidParentheses.IsValid(input);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_WithLargeValidInput_ReturnsTrue()
        {
            // Arrange
            string input = new string('(', 1000) + new string(')', 1000);

            // Act
            bool result = ValidParentheses.IsValid(input);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_WithLargeInvalidInput_ReturnsFalse()
        {
            // Arrange
            string input = new string('(', 1000) + new string(')', 999);

            // Act
            bool result = ValidParentheses.IsValid(input);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}

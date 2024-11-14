using Problems.Medium;
using System.Collections.Generic;
using System.Linq;

namespace ProblemTests.Medium
{
    [TestFixture]
    public class GroupAnagramTests
    {
        [Test]
        public void GroupAnagrams_WithAnagrams_ReturnsGroupedAnagrams()
        {
            // Arrange
            string[] input = { "eat", "tea", "tan", "ate", "nat", "bat" };

            // Act
            IList<IList<string>> result = Leet49.GroupAnagrams(input);

            // Convert result to a set for easier comparison
            List<IList<string>> expected =
            [
                ["eat", "tea", "ate"],
                ["tan", "nat"],
                ["bat"]
            ];

            // Assert
            Assert.That(result, Has.Count.EqualTo(expected.Count));
            foreach (IList<string> group in expected)
            {
                Assert.That(result.Any(r => new HashSet<string>(r).SetEquals(group)), Is.True);
            }
        }

        [Test]
        public void GroupAnagrams_WithEmptyString_ReturnsSingleGroup()
        {
            // Arrange
            string[] input = { "" };

            // Act
            IList<IList<string>> result = Leet49.GroupAnagrams(input);

            // Assert
            Assert.That(result, Has.Count.EqualTo(1));
            Assert.That(result[0], Has.Count.EqualTo(1));
            Assert.That(result[0][0], Is.EqualTo(""));
        }

        [Test]
        public void GroupAnagrams_WithNoInput_ReturnsEmptyList()
        {
            // Arrange
            string[] input = [];

            // Act
            IList<IList<string>> result = Leet49.GroupAnagrams(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GroupAnagrams_WithIdenticalStrings_ReturnsSingleGroup()
        {
            // Arrange
            string[] input = { "aaa", "aaa", "aaa" };

            // Act
            IList<IList<string>> result = Leet49.GroupAnagrams(input);

            // Assert
            Assert.That(result, Has.Count.EqualTo(1));
            Assert.That(result[0], Has.Count.EqualTo(3));
        }
    }
}

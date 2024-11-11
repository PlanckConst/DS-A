using Problems.Easy;

namespace ProblemTests.Easy
{
    [TestFixture]
    public class MergeStringsAlternatelyTest
    {
        [Test]
        public void DefaultTest()
        {
            Assert.That(Leet.MergeAlternately("abc", "pqr"), Is.EqualTo("apbqcr"));
            Assert.That(Leet.MergeAlternately("ab", "pqrs"), Is.EqualTo("apbqrs"));
            Assert.That(Leet.MergeAlternately("abcd", "pq"), Is.EqualTo("apbqcd"));
        }
        [Test]
        public void MyTest()
        {
            Assert.That(Leet.MergeAlternately("acefg", "bd"), Is.EqualTo("abcdefg"));
            Assert.That(Leet.MergeAlternately("acegi", "bdfhj"), Is.EqualTo("abcdefghij"));
            Assert.That(Leet.MergeAlternately("acegi", "bdfhjk"), Is.EqualTo("abcdefghijk"));
        }
    }
}

using Problems.Hard;

namespace ProblemTests.Hard
{
    [TestFixture]
    public class TrappingRainWaterTest
    {
        [Test]
        public void DefaultTest()
        {
            Assert.That(Leet42.Trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]), Is.EqualTo(6));
            Assert.That(Leet42.Trap([4, 2, 0, 3, 2, 5]), Is.EqualTo(9));
        }
        [Test]
        public void MyTests()
        {
            Assert.That(Leet42.Trap([0, 3, 0, 3, 1, 0, 1]), Is.EqualTo(4));
            Assert.That(Leet42.Trap([0, 0, 0, 10, 1, 0, 0]), Is.EqualTo(0));
        }
    }
}

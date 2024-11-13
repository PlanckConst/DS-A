using Problems.Medium;

namespace ProblemTests.Medium
{
    [TestFixture]
    public class NumsIslandsTests
    {
        [Test]
        public void Test_SingleIsland()
        {
            char[][] grid =
            [
                ['1', '1', '0', '0', '0'],
                ['1', '1', '0', '0', '0'],
                ['0', '0', '0', '1', '1'],
                ['0', '0', '0', '1', '1']
            ];

            int result = NumsIslands.NumIslands(grid);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test_MultipleIslands()
        {
            char[][] grid =
            [
                ['1', '0', '1', '0', '1'],
                ['0', '1', '0', '1', '0'],
                ['1', '0', '1', '0', '1']
            ];

            int result = NumsIslands.NumIslands(grid);
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Test_NoIslands()
        {
            char[][] grid =
            [
                ['0', '0', '0', '0'],
                ['0', '0', '0', '0'],
                ['0', '0', '0', '0']
            ];

            int result = NumsIslands.NumIslands(grid);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test_SingleRow()
        {
            char[][] grid =
            [
                ['1', '0', '1', '1', '0']
            ];

            int result = NumsIslands.NumIslands(grid);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test_SingleColumn()
        {
            char[][] grid =
            [
                ['1'],
                ['0'],
                ['1'],
                ['1'],
                ['0']
            ];

            int result = NumsIslands.NumIslands(grid);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test_AllLand()
        {
            char[][] grid =
            [
                ['1', '1', '1'],
                ['1', '1', '1'],
                ['1', '1', '1']
            ];

            int result = NumsIslands.NumIslands(grid);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_SingleCellIsland()
        {
            char[][] grid =
            [
                ['1']
            ];

            int result = NumsIslands.NumIslands(grid);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_SingleCellWater()
        {
            char[][] grid =
            [
                ['0']
            ];

            int result = NumsIslands.NumIslands(grid);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}

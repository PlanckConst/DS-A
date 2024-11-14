using Problems.Easy;

namespace ProblemTests.Easy
{
    [TestFixture]
    public class BestTimeToBuyAndSellStockTests
    {
        [Test]
        public void MaxProfit_WithNormalPrices_ReturnsCorrectProfit()
        {
            // Arrange
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            // Act
            int result = BestTimeToBuyAndSellStock.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void MaxProfit_WithDecreasingPrices_ReturnsZero()
        {
            // Arrange
            int[] prices = { 7, 6, 4, 3, 1 };

            // Act
            int result = BestTimeToBuyAndSellStock.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MaxProfit_WithSingleDayPrice_ReturnsZero()
        {
            // Arrange
            int[] prices = { 10 };

            // Act
            int result = BestTimeToBuyAndSellStock.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MaxProfit_WithConstantPrices_ReturnsZero()
        {
            // Arrange
            int[] prices = { 5, 5, 5, 5, 5 };

            // Act
            int result = BestTimeToBuyAndSellStock.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MaxProfit_WithFluctuatingPrices_ReturnsCorrectProfit()
        {
            // Arrange
            int[] prices = { 2, 4, 1, 7, 3, 6 };

            // Act
            int result = BestTimeToBuyAndSellStock.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(6)); // Buy at 1, sell at 7
        }
    }
}

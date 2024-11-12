using Problems.Medium;

namespace ProblemTests.Medium
{
    [TestFixture]
    public class LRUCacheTests
    {
        [Test]
        public void Test_Get_OnEmptyCache_ReturnsMinusOne()
        {
            // Arrange
            LRUCache cache = new LRUCache(2);

            // Act
            int result = cache.Get(1);

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Test_PutAndGet_SingleElement()
        {
            // Arrange
            LRUCache cache = new LRUCache(1);
            cache.Put(1, 1);

            // Act
            int result = cache.Get(1);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_PutAndGet_MultipleElements()
        {
            // Arrange
            LRUCache cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);

            // Act
            int result1 = cache.Get(1);
            int result2 = cache.Get(2);

            // Assert
            Assert.That(result1, Is.EqualTo(1));
            Assert.That(result2, Is.EqualTo(2));
        }

        [Test]
        public void Test_CapacityExceeded_EvictsLeastRecentlyUsed()
        {
            // Arrange
            LRUCache cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(3, 3); // This should evict key 1

            // Act
            int result1 = cache.Get(1);
            int result2 = cache.Get(2);
            int result3 = cache.Get(3);

            // Assert
            Assert.That(result1, Is.EqualTo(-1)); // Key 1 should have been evicted
            Assert.That(result2, Is.EqualTo(2));
            Assert.That(result3, Is.EqualTo(3));
        }

        [Test]
        public void Test_AccessOrder_MaintainsRecentUsage()
        {
            // Arrange
            LRUCache cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Get(1);      // Access key 1, making key 2 least recently used
            cache.Put(3, 3);   // Evicts key 2

            // Act
            int result1 = cache.Get(2);
            int result2 = cache.Get(1);
            int result3 = cache.Get(3);

            // Assert
            Assert.That(result1, Is.EqualTo(-1)); // Key 2 should have been evicted
            Assert.That(result2, Is.EqualTo(1));
            Assert.That(result3, Is.EqualTo(3));
        }

        [Test]
        public void Test_UpdateExistingKey_MovesToFront()
        {
            // Arrange
            LRUCache cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(1, 10); // Update key 1 and move to front
            cache.Put(3, 3);  // Evicts key 2

            // Act
            int result1 = cache.Get(1);
            int result2 = cache.Get(2);
            int result3 = cache.Get(3);

            // Assert
            Assert.That(result1, Is.EqualTo(10)); // Updated value
            Assert.That(result2, Is.EqualTo(-1)); // Key 2 should have been evicted
            Assert.That(result3, Is.EqualTo(3));
        }

        [Test]
        public void Test_CapacityOne_EvictionBehavior()
        {
            // Arrange
            LRUCache cache = new LRUCache(1);
            cache.Put(1, 1);
            cache.Put(2, 2); // Evicts key 1

            // Act
            int result1 = cache.Get(1);
            int result2 = cache.Get(2);

            // Assert
            Assert.That(result1, Is.EqualTo(-1));
            Assert.That(result2, Is.EqualTo(2));
        }

        [Test]
        public void Test_MultipleEvictions_CorrectlyEvictsLRU()
        {
            // Arrange
            LRUCache cache = new LRUCache(3);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(3, 3);
            cache.Get(1); // Access key 1
            cache.Put(4, 4); // Should evict key 2

            // Act
            int result1 = cache.Get(2);
            int result2 = cache.Get(1);
            int result3 = cache.Get(3);
            int result4 = cache.Get(4);

            // Assert
            Assert.That(result1, Is.EqualTo(-1)); // Key 2 evicted
            Assert.That(result2, Is.EqualTo(1));
            Assert.That(result3, Is.EqualTo(3));
            Assert.That(result4, Is.EqualTo(4));
        }

        [Test]
        public void Test_PutExistingKey_DoesNotIncreaseSize()
        {
            // Arrange
            LRUCache cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(1, 10); // Update key 1

            // Act
            int result1 = cache.Get(1);
            int result2 = cache.Get(2);

            // Assert
            Assert.That(result1, Is.EqualTo(10));
            Assert.That(result2, Is.EqualTo(2));
            // The cache size should still be 2
            // No direct assertion possible; relies on no eviction
        }

        [Test]
        public void Test_PutAndGet_AllElements()
        {
            // Arrange
            LRUCache cache = new LRUCache(3);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(3, 3);

            // Act
            int result1 = cache.Get(1);
            int result2 = cache.Get(2);
            int result3 = cache.Get(3);

            // Assert
            Assert.That(result1, Is.EqualTo(1));
            Assert.That(result2, Is.EqualTo(2));
            Assert.That(result3, Is.EqualTo(3));
        }

        [Test]
        public void Test_GetRecentItem_DoesNotEvict()
        {
            // Arrange
            LRUCache cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Get(1); // Make key 1 recent
            cache.Put(3, 3); // Evicts key 2

            // Act
            int result1 = cache.Get(1);
            int result2 = cache.Get(2);
            int result3 = cache.Get(3);

            // Assert
            Assert.That(result1, Is.EqualTo(1));
            Assert.That(result2, Is.EqualTo(-1));
            Assert.That(result3, Is.EqualTo(3));
        }
    }
}

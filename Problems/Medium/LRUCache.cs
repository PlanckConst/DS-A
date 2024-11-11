using System.Collections.Generic;

namespace Problems.Medium
{
    public class LRUCache
    {
        private readonly Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> _index;
        private readonly int _capacity;
        private readonly LinkedList<KeyValuePair<int, int>> _cache;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _index = [];
            _cache = new LinkedList<KeyValuePair<int, int>>();
        }

        public int Get(int key)
        {
            if (!_index.TryGetValue(key, out var node))
                return -1;

            // Move the accessed node to the front (most recently used)
            _cache.Remove(node);
            _cache.AddFirst(node);
            return node.Value.Value;
        }

        public void Put(int key, int value)
        {
            if (_index.TryGetValue(key, out var node))
            {
                // Update the value and move to front
                node.Value = new KeyValuePair<int, int>(key, value);
                _cache.Remove(node);
                _cache.AddFirst(node);
            }
            else
            {
                if (_cache.Count >= _capacity)
                {
                    // Remove the least recently used item
                    var lru = _cache.Last;
                    if (lru != null)
                    {
                        _index.Remove(lru.Value.Key);
                        _cache.RemoveLast();
                    }
                }

                // Add the new key-value pair
                var kvp = new KeyValuePair<int, int>(key, value);
                var newNode = new LinkedListNode<KeyValuePair<int, int>>(kvp);
                _cache.AddFirst(newNode);
                _index[key] = newNode;
            }
        }
    }
}

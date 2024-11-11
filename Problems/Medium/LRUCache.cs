using System.Collections.Generic;

namespace Problems.Medium
{
    public class LRUCache
    {
        private Dictionary<int, LinkedListNode<int?>> _index;
        private int _capacity;
        private LinkedList<int?> _cache;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _index = new Dictionary<int, LinkedListNode<int?>>();
            _cache = new LinkedList<int?>();
        }

        public int Get(int key)
        {
            //Search for the value too see if key exists
            if (!_index.TryGetValue(key, out LinkedListNode<int?>? node)) return -1;
            //Check if key is found, but node has a null value (buffer)
            if (!node.Value.HasValue) return -1;

            _cache.Remove(node);
            _cache.AddFirst(node);
            return node.Value!.Value;
        }

        public void Put(int key, int value)
        {
            //Buffer: check if key exists and if value is null. If true then remove the key.
            if (_index.ContainsKey(key) && !_index[key].Value.HasValue) _index.Remove(key);

            LinkedListNode<int?> node = new LinkedListNode<int?>(value);

            //Checks if key does not exist and can add it
            if (_index.TryAdd(key, node))
            {
                //Check if cache is full
                if (_cache.Count + 1 > _capacity)
                {
                    //Set last node value to null
                    _cache.Last!.Value = null;
                    _cache.RemoveLast();
                }
                _cache.AddFirst(node);
            }
            //Key exists so update the node value and bring it to front of cache
            else
            {
                node = _index[key];
                node.Value = value;
                _cache.Remove(node);
                _cache.AddFirst(node);
            }
        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}

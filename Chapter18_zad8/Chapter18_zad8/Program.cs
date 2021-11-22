using System;
using System.Collections;
using System.Collections.Generic;


namespace Chapter18_zad8
{
    class HashTable<K, T> : IEnumerable<KeyValuePair<K,T>>
    {
        private const int DEFAULT_CAPACITY = 16;
        private const float DEFAULT_LOAD_FACTOR = 0.75f;
        private List<KeyValuePair<K, T>>[] table; //sprawdzic to, [] daje mozliwosc nadania poczatkowej wielkosci listy
        private float loadFactor;
        private int threshold;
        private int size;
        private int initialCapacity;

        public HashTable() : this(DEFAULT_CAPACITY, DEFAULT_LOAD_FACTOR)
        {
        }
        public HashTable(int capacity, float loadFactor)
        {
            this.initialCapacity = capacity;
            this.table = new List<KeyValuePair<K, T>>[capacity];
            this.loadFactor = loadFactor;
            this.threshold = (int)(capacity * this.loadFactor);
        }

        private List<KeyValuePair<K,T>> FindChain(K key, bool createIfMissing)
        {
            int index = key.GetHashCode();
            index = index & 0x7FFFFFFF;
            index = index % this.table.Length;

            /* proba implementacji quadratic probing
            int j = 0;
            int hash = index;

            while (table[hash] != null && table[hash]. != key)
            {
                j++;
                hash = (hash + j * j) % this.table.Length;
                index = hash;
            }
            if (table[hash] == null)
            {
                //table[hash] = new hashentry(key, data);
                index = hash;
                this.table[index] = new List<KeyValuePair<K, T>>();
                //return;
            }
            */

            if (this.table[index] == null && createIfMissing)
            {
                this.table[index] = new List<KeyValuePair<K, T>>();
            }

            return this.table[index] as List<KeyValuePair<K, T>>;
        }

        public T Get(K key)
        {
            List<KeyValuePair<K, T>> chain = this.FindChain(key, false);
            if(chain != null)
            {
                foreach (KeyValuePair<K,T> entry in chain)
                {
                    if (entry.Key.Equals(key))
                    {
                        return entry.Value;
                    }
                }
            }

            return default(T);
        }

        public T Set(K key, T value)
        {
            if (this.size >- this.threshold)
            {
                this.Expand();
            }

            List<KeyValuePair<K, T>> chain = this.FindChain(key, true);
            for (int i = 0; i < chain.Count; i++)
            {
                KeyValuePair<K, T> entry = chain[i];
                if (entry.Key.Equals(key))
                {
                    KeyValuePair<K, T> newEntry = new KeyValuePair<K, T>(key, value);
                    chain[i] = newEntry;
                    return entry.Value;
                }
            }
            chain.Add(new KeyValuePair<K, T>(key, value));
            this.size++;

            return default(T);
        }

        public T this[K key]
        {
            get
            {
                return this.Get(key);
            }

            set
            {
                this.Set(key, value);
            }
        }

        public bool Remove(K key)
        {
            List<KeyValuePair<K, T>> chain = this.FindChain(key, false);

            if (chain != null)
            {
                for (int i = 0; i < chain.Count; i++)
                {
                    KeyValuePair<K, T> entry = chain[i];
                    if (entry.Key.Equals(key))
                    {
                        chain.RemoveAt(i);
                        this.size--;
                        return true;
                    }
                }
            }
            return false;
        }

        public int Count
        {
            get
            {
                return this.size;
            }
        }
        
        public void Clear()
        {
            this.table = new List<KeyValuePair<K, T>>[this.initialCapacity];
            this.size = 0;
        }

        private void Expand()
        {
            int newCapacity = 2 * this.table.Length;
            List<KeyValuePair<K, T>>[] oldTable = this.table;
            this.table = new List<KeyValuePair<K, T>>[newCapacity];
            this.threshold = (int)(newCapacity * this.loadFactor);
            foreach ( List<KeyValuePair<K,T>> oldChain in oldTable)
            {
                if (oldChain != null)
                {
                    foreach (KeyValuePair<K,T> keyValuePair in oldChain)
                    {
                        List<KeyValuePair<K, T>> chain = FindChain(keyValuePair.Key, true);
                        chain.Add(keyValuePair);
                    }
                }
            }
        }

        IEnumerator<KeyValuePair<K,T>> IEnumerable<KeyValuePair<K,T>>.GetEnumerator()
        {
            foreach (List<KeyValuePair<K,T>> chain in this.table)
            {
                if (chain != null)
                {
                    foreach (KeyValuePair<K,T> entry in chain)
                    {
                        yield return entry;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<K,T>>)this).GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //8.Implement the data structure hash-table in a class HashTable<K, T>.
            //Keep the data in an array of key-value pairs(List<KeyValuePair<K, T>>[]) with
            //initial capacity of 16. Resole the collisions with quadratic probing.
            //When the hash table load runs over 75%, perform resizing to 2 times
            //larger capacity.Implement the following methods and properties:
            //Add(key, value), Find(key) -> value, Remove(key), Count, Clear(), this[] and Keys.
            //Try to make the hash-table to support iterating over its elements with foreach.
            Console.WriteLine("Hello World!");


            HashTable<int,int> test = new HashTable<int,int>();
            


            Console.ReadKey();
        }
    }
}

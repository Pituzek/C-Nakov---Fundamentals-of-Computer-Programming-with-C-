using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



namespace Rozdzial18_zad5
{
    class HashDictionary<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        #region Fields
        private const int DEFAULT_CAPACITY = 16;
        private const float DEFAULT_LOAD_FACTOR = 0.75f;
        private readonly float loadFactor;
        private int capacity;
        private int count;
        private int threshold;
        private int size;
        private List<KeyValuePair<K, V>>[] table;
        #endregion Fields

        #region Properties
        public V this[K key]
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

        public int Count
        {
            get
            {
                return this.count;
            }
        }
        #endregion Properties

        #region Constructors
        public HashDictionary()
            : this(DEFAULT_CAPACITY, DEFAULT_LOAD_FACTOR)
        {
        }

        private HashDictionary(int capacity, float loadFactor)
        {
            this.loadFactor = loadFactor;
            this.capacity = capacity;
            this.count = 0;
            this.size = 0;
            unchecked
            {
                this.threshold = (int)(capacity * this.loadFactor);
            }
            this.table = new List<KeyValuePair<K, V>>[capacity];
        }
        #endregion Constructors

        #region Public Methods
        public void Clear()
        {
            if (this.table != null)
            {
                this.table = new List<KeyValuePair<K, V>>[capacity];
            }
            this.size = 0;
            this.count = 0;
        }

        public V Get(K key)
        {
            List<KeyValuePair<K, V>> chain = this.FindChain(key, false);

            if (chain != null)
            {
                foreach (KeyValuePair<K, V> entry in chain)
                {
                    if (entry.Key.Equals(key))
                    {
                        return entry.Value;
                    }
                }
            }

            throw new ArgumentException("The given key was not present in the dictionary.");
        }

        public void Set(K key, V value)
        {
            List<KeyValuePair<K, V>> chain = this.FindChain(key, true);
            for (int i = 0; i < chain.Count; i++)
            {
                KeyValuePair<K, V> entry = chain[i];
                if (entry.Key.Equals(key))
                {
                    KeyValuePair<K, V> newEntry = new KeyValuePair<K, V>(key, value);
                    chain[i] = newEntry;
                    return;
                }
            }

            chain.Add(new KeyValuePair<K, V>(key, value));
            count++;

            if (size >= threshold)
            {
                this.Expand();
            }
        }

        public bool Remove(K key)
        {
            List<KeyValuePair<K, V>> chain = this.FindChain(key, false);
            if (chain != null)
            {
                for (int i = 0; i < chain.Count; i++)
                {
                    KeyValuePair<K, V> entry = chain[i];
                    if (entry.Key.Equals(key))
                    {
                        chain.RemoveAt(i);
                        count--;
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion Public Methods

        #region Private Methods
        private List<KeyValuePair<K, V>> FindChain(K key, bool createIfMissing)
        {
            int index = Math.Abs(key.GetHashCode());
            index = index % this.capacity;

            if ((this.table[index] == null) && createIfMissing)
            {
                this.table[index] = new List<KeyValuePair<K, V>>();
                size++;
            }
            return this.table[index];
        }

        private void Expand()
        {
            this.capacity = 2 * this.capacity;
            List<KeyValuePair<K, V>>[] oldTable = this.table;
            this.table = new List<KeyValuePair<K, V>>[this.capacity];
            this.threshold = (int)(this.capacity * this.loadFactor);
            this.size = 0;

            foreach (List<KeyValuePair<K, V>> oldChain in oldTable)
            {
                if (oldChain != null)
                {
                    foreach (KeyValuePair<K, V> keyValuePair in oldChain)
                    {
                        List<KeyValuePair<K, V>> chain = FindChain(keyValuePair.Key, true);
                        chain.Add(keyValuePair);
                    }
                }
            }
        }
        #endregion PrivateMethods

        #region Implement Interfaces
        IEnumerator<KeyValuePair<K, V>>
          IEnumerable<KeyValuePair<K, V>>.GetEnumerator()
        {
            foreach (List<KeyValuePair<K, V>> chain in this.table)
            {
                if (chain != null)
                {
                    foreach (KeyValuePair<K, V> entry in chain)
                    {
                        yield return entry;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<K, V>>)this).GetEnumerator();
        }
        #endregion
    }


    class DoubleKeyHashDictionaryTest
    {
        static readonly string[] delimeter = { "; " };
        static DoubleKeyHashDictionary<string, string, string> dictionary =
        new DoubleKeyHashDictionary<string, string, string>();

    static void Main(string[] args)
    {
        string commandLine = Console.ReadLine();
        while (commandLine != "End")
            {
            int index = commandLine.IndexOf(':');
            string[] commandParamaters = commandLine.Substring(index + 2).Split(delimeter,
                StringSplitOptions.RemoveEmptyEntries);
            string command = commandLine.Substring(0, index);
            switch (command)
            {
                case "Add": Add(commandParamaters); break;
                case "Get": Get(commandParamaters); break;
            }

            commandLine = Console.ReadLine();
        }
    }

    private static void Add(string[] commandParamaters)
    {
        dictionary.Set(commandParamaters[0], commandParamaters[1], commandParamaters[2]);
    }

    private static void Get(string[] commandParamaters)
    {
        try
        {
            string value = dictionary.Get(commandParamaters[0], commandParamaters[1]);
            Console.WriteLine(value);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Not found");
        }
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            // 5. Implement a hash-table, maintaining triples (key1, key2, value) and allowing quick search by the pair of keys and adding of triples.
            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }

    public class DoubleKeyHashDictionary<K1, K2, V>
    {
        private HashDictionary<K2, V> innerHashTable;
        private HashDictionary<K1, HashDictionary<K2, V>> outerHashTable;

        public DoubleKeyHashDictionary()
        {
            innerHashTable = new HashDictionary<K2, V>();
            outerHashTable = new HashDictionary<K1, HashDictionary<K2, V>>();
        }

        public void Set(K1 key1, K2 key2, V value)
        {
            innerHashTable[key2] = value;
            outerHashTable[key1] = innerHashTable;
        }

        public V Get (K1 key1, K2 key2)
        {
            HashDictionary<K2, V> hashTable = outerHashTable.Get(key1);
            V result = hashTable.Get(key2);
            return result;
        }

    }

}

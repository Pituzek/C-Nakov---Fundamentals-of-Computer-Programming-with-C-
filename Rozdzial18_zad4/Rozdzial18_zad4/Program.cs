using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozdzial18_zad4
{
    class DictHashSet<T> : IEnumerable<T>
    {
        private HashDictionary<T, T> hashSet;

        #region Properties
        public int Count
        {
            get { return hashSet.Count; }
        }
        #endregion Properties

        #region Constructors
        public DictHashSet()
        {
            hashSet = new HashDictionary<T, T>();
        }

        public DictHashSet(IEnumerable<T> initialSet)
        {
            hashSet = new HashDictionary<T, T>();
            foreach (T value in initialSet)
            {
                this.Add(value);
            }
        }
        #endregion Constructors

        #region Public Methods
        public void Add(T value)
        {
            hashSet.Set(value, value);
        }

        public bool Remove(T item)
        {
            return hashSet.Remove(item);
        }

        public void Clear()
        {
            hashSet.Clear();
        }

        public bool Contains(T item)
        {
            try
            {
                hashSet.Get(item);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DictHashSet<T> IntersectWith(IEnumerable<T> other)
        {
            DictHashSet<T> intersectedHashSet = new DictHashSet<T>();

            foreach (T value in other)
            {
                if (this.Contains(value))
                {
                    intersectedHashSet.Add(value);
                }
            }

            return intersectedHashSet;
        }

        public DictHashSet<T> UnionWith(IEnumerable<T> other)
        {
            DictHashSet<T> unitedHashSet = new DictHashSet<T>(this);

            foreach (T element in other)
            {
                if (!unitedHashSet.Contains(element))
                {
                    unitedHashSet.Add(element);
                }
            }

            return unitedHashSet;
        }
        #endregion Public Methods

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var value in hashSet)
            {
                yield return value.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }


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
            int index = key.GetHashCode();
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
        #endregion Private Methods

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


    class DictHashSetTest
    {
        static DictHashSet<int>[] sets;
        static readonly char[] delimeter = new char[] { ' ' };

        static void Main(string[] args)
        {
            int numberOfSets = int.Parse(Console.ReadLine());
            sets = new DictHashSet<int>[numberOfSets];

            for (int i = 0; i < numberOfSets; i++)
            {
                GetSet(i);
            }

            string commandLine = Console.ReadLine();
            while (commandLine != "End")
            {
                int index = commandLine.IndexOf(':');
                string command = commandLine.Substring(0, index);
                string[] commandParamaters = commandLine.Substring(index + 2).Split();
                switch (command)
                {
                    case "Add": Add(commandParamaters); break;
                    case "Remove": Remove(commandParamaters); break;
                    case "Clear": Clear(commandParamaters); break;
                    case "Count": Count(commandParamaters); break;
                    case "Intersect": Intersect(commandParamaters); break;
                    case "Union": Union(commandParamaters); break;
                    case "Print": Print(commandParamaters); break;
                }
                commandLine = Console.ReadLine();
            }
        }

        private static void GetSet(int index)
        {
            sets[index] = new DictHashSet<int>();
            string[] numbers = Console.ReadLine().Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);
                sets[index].Add(number);
            }
        }

        private static void PrintSet(DictHashSet<int> set)
        {
            StringBuilder output = new StringBuilder();
            foreach (var item in set.OrderBy(x => x))
            {
                output.AppendFormat("{ 0} ", item);
            }
            Console.WriteLine(output);
        }

        private static void Add(string[] commandParamaters)
        {
            int index = int.Parse(commandParamaters[0]);
            int number = int.Parse(commandParamaters[1]);
            sets[index].Add(number);
        }

        private static void Remove(string[] commandParamaters)
        {
            int index = int.Parse(commandParamaters[0]);
            int number = int.Parse(commandParamaters[1]);
            sets[index].Remove(number);
        }

        private static void Clear(string[] commandParamaters)
        {
            int index = int.Parse(commandParamaters[0]);
            sets[index].Clear();
        }

        private static void Count(string[] commandParamaters)
        {
            int index = int.Parse(commandParamaters[0]);
            Console.WriteLine(sets[index].Count);
        }

        private static void Intersect(string[] commandParamaters)
        {
            int firstSet = int.Parse(commandParamaters[0]);
            int secondSet = int.Parse(commandParamaters[1]);
            DictHashSet<int> intersectedSet = sets[firstSet].IntersectWith(sets[secondSet]);
            PrintSet(intersectedSet);
        }

        private static void Union(string[] commandParamaters)
        {
            int firstSet = int.Parse(commandParamaters[0]);
            int secondSet = int.Parse(commandParamaters[1]);
            DictHashSet<int> unitedSet = sets[firstSet].UnionWith(sets[secondSet]);
            PrintSet(unitedSet);
        }

        private static void Print(string[] commandParamaters)
        {
            int index = int.Parse(commandParamaters[0]);
            PrintSet(sets[index]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //4.Implement a DictHashSet<T> class, based on HashDictionary<K, V> class, we discussed in the text above.
           Console.WriteLine("Hello World!");


            Console.ReadKey();
        }
    }
}

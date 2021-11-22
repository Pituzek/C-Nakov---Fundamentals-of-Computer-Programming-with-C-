using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Rozdzial18_zad7
{
    class Program
    {
        static StringBuilder output = new StringBuilder();
        static CuckooHashingHashTable<int, int> dictionary = new CuckooHashingHashTable<int, int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 7.Implement a hash-table, using "cuckoo hashing" with 3 hash - functions.
            ReadInput();
            PrintOutput();

        }

        private static void ReadInput()
        {
            while (true)
            {
                string commandText = Console.ReadLine();
                if (commandText == "End" || commandText == null)
                {
                    break;
                }
                try
                {
                    ProcessCommand(commandText);
                }
                catch (Exception ex)
                {
                    output.Append("Unhandled exception: " + ex);
                }
            }

        }

        private static void ReadInput(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string line = reader.ReadLine();
            while (line != String.Empty && line != "End")
            {
                ProcessCommand(line);
                line = reader.ReadLine();
            }

        }

        private static void ProcessCommand(string commandText)
        {
            string[] command = commandText.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            switch (command[0])
            {
                case "Add":
                    {
                        string[] arguments = command[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        int key = int.Parse(arguments[0]);
                        if (!dictionary.ContainsKey(key))
                        {
                            dictionary.Add(key, int.Parse(arguments[1]));
                        }
                        break;
                    }
                case "Remove":
                    {
                        int key = int.Parse(command[1]);
                        if (dictionary.ContainsKey(key))
                        {
                            dictionary.Remove(int.Parse(command[1]));
                        }
                        break;
                    }
                case "ContainsKey":
                    {
                        output.AppendLine(dictionary.ContainsKey(int.Parse(command[1])).ToString());
                        break;

                    }
                case "Count":
                    {
                        output.AppendLine(dictionary.Count.ToString());
                        break;
                    }
                case "Clear":
                    {
                        dictionary.Clear();
                        break;
                    }
                case "this":
                    {
                        int key = int.Parse(command[1]);
                        if (dictionary.ContainsKey(key))
                        {
                            output.AppendLine(dictionary[key].ToString());
                        }
                        break;
                    }
                case "Foreach":
                    {
                        foreach (var item in dictionary)
                        {
                            output.AppendLine(item.Key + "->" + item.Value);
                        }
                        break;
                    }
            }
        }


        private static void PrintOutput()
        {

            Console.WriteLine(output);
        }

        private static void PrintOutput(string fileName)
        {

            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                writer.Write(output);
            }
        }



        class CuckooHashingHashTable<K, V> : IEnumerable<KeyValuePair<K, V>>
        {
            private const int defaultCapacity = 16;
            private int currentCapacity;
            Nullable<KeyValuePair<K, V>>[] hashTable;
            int count;

            public CuckooHashingHashTable()
                : this(defaultCapacity)
            {
            }

            public CuckooHashingHashTable(int capacity)
            {
                hashTable = new Nullable<KeyValuePair<K, V>>[capacity];
                currentCapacity = capacity;
                count = 0;
            }

            #region Properties

            public int Count
            {
                get
                {
                    return count;
                }
            }

            public V this[K key]
            {
                get
                {
                    int[] hashCodes = GetThreeHashCodes(key);

                    foreach (var hashCode in hashCodes)
                    {
                        if (hashTable[hashCode] != null && hashTable[hashCode].Value.Key.Equals(key))
                        {
                            return hashTable[hashCode].Value.Value;
                        }
                    }
                    throw new ArgumentException("Cant find KeyValuePair with this key.");
                }

                set
                {
                    int[] hashCodes = GetThreeHashCodes(key);

                    foreach (var hashCode in hashCodes)
                    {
                        if (hashTable[hashCode] != null && hashTable[hashCode].Value.Key.Equals(key))
                        {
                            hashTable[hashCode] = new KeyValuePair<K, V>(key, value);
                            return;
                        }
                    }
                    throw new ArgumentException("Cant find KeyValuePair with this key.");
                }

            }

            public ICollection<V> Values
            {
                get
                {
                    List<V> values = new List<V>();
                    foreach (Nullable<KeyValuePair<K, V>> item in hashTable)
                    {
                        if (item.HasValue)
                        {

                            values.Add(item.Value.Value);
                        }
                    }
                    return values;
                }
            }

            public ICollection<K> Keys
            {
                get
                {
                    List<K> keys = new List<K>();
                    foreach (Nullable<KeyValuePair<K, V>> item in hashTable)
                    {
                        if (item.HasValue)
                        {
                            keys.Add(item.Value.Key);
                        }
                    }
                    return keys;
                }
            }

            #endregion

            #region Methods

            public void Add(K key, V value)
            {
                int[] hashCodes = GetThreeHashCodes(key);
                CheckKeyForDuplicate(hashCodes, key);
            }


            public void Remove(K key)
            {
                int[] hashCodes = GetThreeHashCodes(key);
                foreach (var hashCode in hashCodes)
                {
                    if (hashTable[hashCode] != null && hashTable[hashCode].Value.Key.Equals(key))
                    {
                        hashTable[hashCode] = null;
                        count--;
                        return;
                    }
                }
                throw new ArgumentException("Cant find KeyValuePair with this key.");
            }

            public void Clear()
            {
                hashTable = new Nullable<KeyValuePair<K, V>>[defaultCapacity];
                currentCapacity = defaultCapacity;
                count = 0;
            }

            public bool ContainsKey(K key)
            {
                int[] hashCodes = GetThreeHashCodes(key);

                foreach (var hashCode in hashCodes)
                {
                    if (hashTable[hashCode] != null && hashTable[hashCode].Value.Key.Equals(key))
                    {
                        return true;
                    }
                }
                return false;
            }


            private int[] GetThreeHashCodes(K key)
            {
                int[] hashCodes = new int[3];
                hashCodes[0] = Math.Abs(key.GetHashCode() % currentCapacity);
                hashCodes[1] = Math.Abs((key.GetHashCode() * 83 + 7) % currentCapacity);
                hashCodes[2] = Math.Abs((key.GetHashCode() * key.GetHashCode() + 19) % currentCapacity);
                return hashCodes;
            }

            private void FindNewPlace(KeyValuePair<K, V>? movingKeyValuePair, int oldPosition, HashSet<int> hashSetVisitedPosiotion)
            {
                int[] hashCodes = GetThreeHashCodes(movingKeyValuePair.Value.Key);
                int numberOfLastPossiblePosition = 0;
                bool needToContinueReplacing = true;

                for (int i = 0; i < hashCodes.Length; i++)
                {
                    if (hashCodes[i] == oldPosition)
                    {
                        continue;
                    }
                    if (hashTable[hashCodes[i]] == null)
                    {
                        hashTable[hashCodes[i]] = movingKeyValuePair;
                        needToContinueReplacing = false;
                        break;
                    }
                    numberOfLastPossiblePosition = i;
                }

                if (needToContinueReplacing)
                {
                    if (hashSetVisitedPosiotion.Contains(hashCodes[numberOfLastPossiblePosition]))
                    {
                        ResizeHashTable();
                        if (hashTable[hashCodes[numberOfLastPossiblePosition]] == null)
                        {
                            hashTable[hashCodes[numberOfLastPossiblePosition]] = movingKeyValuePair;
                        }
                        else
                        {
                            FindNewPlace(movingKeyValuePair, hashCodes[numberOfLastPossiblePosition],
                                         new HashSet<int>() { hashCodes[numberOfLastPossiblePosition] });
                        }
                    }
                    else
                    {
                        HashSet<int> oldHashSetVisitedPosiotion = hashSetVisitedPosiotion;
                        oldHashSetVisitedPosiotion.Add(hashCodes[numberOfLastPossiblePosition]);
                        Nullable<KeyValuePair<K, V>> newMovingPair = hashTable[hashCodes[numberOfLastPossiblePosition]];
                        hashTable[hashCodes[numberOfLastPossiblePosition]] = movingKeyValuePair;

                        FindNewPlace(newMovingPair, hashCodes[numberOfLastPossiblePosition], oldHashSetVisitedPosiotion);

                    }
                }
            }

            private void ResizeHashTable()
            {
                currentCapacity *= 2;
                Nullable<KeyValuePair<K, V>>[] oldHashTable = hashTable;
                Nullable<KeyValuePair<K, V>>[] newHashTable = new Nullable<KeyValuePair<K, V>>[currentCapacity];
                hashTable = newHashTable;
                count = 0;

                foreach (var item in oldHashTable)
                {
                    if (item.HasValue)
                    {
                        this.Add(item.Value.Key, item.Value.Value);
                    }
                }
            }

            private void CheckKeyForDuplicate(int[] hashCodes, K key)
            {
                foreach (int item in hashCodes)
                {
                    if (hashTable[item].HasValue && hashTable[item].Value.Key.Equals(key))
                    {
                        throw new ArgumentException("An element with the same key already exists in the CuckooHashingHashTable<TKey, TValue>.");
                    }
                }
            }

            #endregion

            #region IEnumerable
            public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
            {
                foreach (Nullable<KeyValuePair<K, V>> pair in hashTable)
                {
                    if (pair != null)
                    {
                        yield return pair.Value;
                    }
                }
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<KeyValuePair<K, V>>)this).GetEnumerator();
            }

            #endregion
        }
    }
}

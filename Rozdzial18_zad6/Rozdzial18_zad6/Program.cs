using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozdzial18_zad6
{
    class MultiDictionary<K,V>
    {
        private Dictionary<K, List<V>> dictionary;

        public List<V> this[K key]
        {
            get
            {
                if (ContainsKey(key))
                {
                    return dictionary[key];
                }
                else
                {
                    throw new ArgumentException("The given key was not present in the dictionary.");
                }
            }
        }

        public bool ContainsKey(K key)
        {
            return dictionary.ContainsKey(key);
        }

        public MultiDictionary()
        {
            dictionary = new Dictionary<K, List<V>>();
        }

        public void Add (K key, V value)
        {
            if (!ContainsKey(key))
            {
                dictionary[key] = new List<V>();
            }

            dictionary[key].Add(value);
        }


    }
    class Program
    {
        static readonly string[] delimeter = { "; " };
        static MultiDictionary<string, string> multiDictionary = new MultiDictionary<string, string>();

        static void Main(string[] args)
        {
           //6.Implement a hash-table, allowing the maintenance of more than one value for a specific key.
           Console.WriteLine("Hello World!");

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


            Console.ReadKey();
        }

        private static void Add(string[] commandParamaters)
        {
            multiDictionary.Add(commandParamaters[0], commandParamaters[1]);
        }

        private static void Get(string[] commandParamaters)
        {
            try
            {
                List<string> value = multiDictionary[commandParamaters[0]];

                if (value.Count == 0)
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    PrintValues(value);
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Not found");
            }
        }
        private static void PrintValues(List<string> value)
        {
            StringBuilder output = new StringBuilder();
            foreach (var item in value.OrderBy(x => x))
            {
                output.AppendFormat("{0}, ", item);
            }
            output.Remove(output.Length - 2, 2);
            Console.WriteLine(output);
        }
    }

}
    

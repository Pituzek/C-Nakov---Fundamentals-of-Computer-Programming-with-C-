using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter19_zad4
{
    class Program
    {
        public static BiDictionary<string, string, int> biDictionary = new BiDictionary<string, string, int>();
        private static StringBuilder output = new StringBuilder();
        public static void ProcessAllCommands()
        {
            while (true)
            {
                string commandText = Console.ReadLine();
                if (commandText == "End")
                {
                    break;
                }
                ProcessCommand(commandText);
            }
        }

        private static void ProcessCommand(string commandText)
        {

            // Parse the command and its arguments
            int spaceIndex = commandText.IndexOf(": ");
            if (spaceIndex == -1)
            {
                throw new ArgumentException("Invalid command: " + commandText);
            }
            string command = commandText.Substring(0, spaceIndex);
            string argumentsStr = commandText.Substring(spaceIndex + 2);
            string[] arguments = argumentsStr.Split(';');
            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = arguments[i].Trim();
            }

            // Execute the parsed command
            if (command == "Add")
            {
                ProcessAddCommand(command, arguments);
            }
            else if ((command == "FindOne") || (command == "FindTwo") || (command == "FindThree"))
            {
                ProcessFindCommand(command, arguments);
            }
            else
            {
                throw new ArgumentException("Invalid command: " + commandText);
            }
        }

        private static void ProcessFindCommand(string command, string[] arguments)
        {
            List<int> elements = new List<int>();
            bool hasElements = false;
            if (command == "FindOne")
            {
                hasElements = biDictionary.SearchByFirstKey(arguments[0], out elements);
            }
            else if (command == "FindTwo")
            {
                hasElements = biDictionary.SearchBySecondKey(arguments[0], out elements);
            }
            else if (command == "FindThree")
            {
                hasElements = biDictionary.SearchByBothKeys(arguments[0], arguments[1], out elements);
            }
            if (hasElements == false)
            {
                Print("No elements found");
            }
            else
            {
                foreach (var item in elements)
                {
                    Print(item.ToString());
                }
            }
        }
        private static void ProcessAddCommand(string command, string[] arguments)
        {
            biDictionary.Add(arguments[0], arguments[1], int.Parse(arguments[2]));
            Print("Book added");
        }
        private static void PrintCollectedOutput()
        {
            Console.Write(output);
        }
        private static void Print(string text)
        {
            output.AppendLine(text);
        }

        static void Main(string[] args)
        {
            //4. Implement a class BiDictionary<K1,K2,T>, which allows adding triplets {key1, key2, value}
            //and quickly search by either of the keys key1, key2 as well as searching by combination of the both keys.
            //Note: Adding many elements with the same keys is allowed.

            ProcessAllCommands();
            PrintCollectedOutput();

            Console.ReadKey();
        }
    }

    class BiDictionary<K1, K2, T>
    {
        private Dictionary<K1, List<KeyValuePair<int, T>>> key1;
        private Dictionary<K2, List<KeyValuePair<int, T>>> key2;
        private T value;
        private int index;

        public BiDictionary()
        {
            this.key1 = new Dictionary<K1, List<KeyValuePair<int, T>>>();
            this.key2 = new Dictionary<K2, List<KeyValuePair<int, T>>>();
            this.value = default(T);
            this.index = 0;
        }

        public Dictionary<K1, List<KeyValuePair<int, T>>> Key1
        {
            get
            {
                return this.key1;
            }
            
            set
            {
                this.key1 = value;
            }
        }

        public Dictionary<K2, List<KeyValuePair<int, T>>> Key2
        {
            get
            {
                return this.key2;
            }

            set
            {
                this.key2 = value;
            }
        }

        public void Add(K1 key1, K2 key2, T value)
        {
            KeyValuePair<int, T> newEntry = new KeyValuePair<int, T>(index, value);

            if (this.key1.ContainsKey(key1))
            {
                this.key1[key1].Add(newEntry);
            }
            else
            {
                this.key1.Add(key1, new List<KeyValuePair<int, T>>() { newEntry });
            }

            if (this.key2.ContainsKey(key2))
            {
                this.key2[key2].Add(newEntry);
            }
            else
            {
                this.key2.Add(key2, new List<KeyValuePair<int, T>>() { newEntry });
            }

            this.index = ++index;
            this.value = value;
        }

        public bool SearchByBothKeys(K1 key1, K2 key2, out List<T> result)
        {
            result = new List<T>();
            List<KeyValuePair<int, T>> firstKeyResults = new List<KeyValuePair<int, T>>(16);
            List<KeyValuePair<int, T>> secondKeyResults = new List<KeyValuePair<int, T>>(16);

            if (Key1.Count == 0 || Key2.Count == 0)
            {
                return false;
            }

            if (firstKeyResults.Count > secondKeyResults.Count)
            {
                foreach (var firstKey in secondKeyResults)
                {
                    foreach (var secondKey in firstKeyResults)
                    {
                        if (firstKey.Key == secondKey.Key)
                        {
                            result.Add(firstKey.Value);
                        }
                    }
                }
            }

            if (secondKeyResults.Count >= firstKeyResults.Count)
            {
                foreach(var firstKey in firstKeyResults)
                {
                    foreach(var secondKey in secondKeyResults)
                    {
                        if (firstKey.Key == secondKey.Key)
                        {
                            result.Add(firstKey.Value);
                        }
                    }
                }
            }

            return true;
        }

        public bool SearchByFirstKey(K1 key1, out List<T> result)
        {
            result = new List<T>();
            List<KeyValuePair<int, T>> res = new List<KeyValuePair<int, T>>();

            if (this.key1.TryGetValue(key1, out res))
            {
                foreach (var item in res)
                {
                    result.Add(item.Value);
                }
                return true;
            }

            return false;
        }

        public bool SearchBySecondKey(K2 key2, out List<T> result)
        {
            result = new List<T>();
            List<KeyValuePair<int, T>> res = new List<KeyValuePair<int, T>>();

            if (this.key2.TryGetValue(key2, out res))
            {
                foreach (var item in res)
                {
                    result.Add(item.Value);
                }
            }

            return false;
        }

    }

}

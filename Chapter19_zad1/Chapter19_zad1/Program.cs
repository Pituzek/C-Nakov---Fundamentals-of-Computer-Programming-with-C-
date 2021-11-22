using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Chapter19_zad1
{
    class MultiDictionary<Tkey, TVal> : Dictionary<Tkey, List<TVal>>
    {

        public List<TVal> elements;

        public MultiDictionary()
        {
            this.elements = new List<TVal>();
        }

        public void Add(Tkey key, TVal val)
        {
            //this.Key = key;
            //this.Value = val;

            if (!base.ContainsKey(key))
            {
                base.Add(key, new List<TVal>());
            }
            base[key].Add(val);
            elements.Add(val);
        }

        public override string ToString()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine(elements[i]);
            }
                return base.ToString();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //1.Hash - tables do not allow storing more than one value in a key.
            //How can we get around this restriction? Define a class to hold multiple values in a hash-table.


            MultiDictionary<int, int> test = new MultiDictionary<int, int>();

            test.Add(1, 30);
            test.Add(2, 50);
            test.Add(3, 60);

            Console.WriteLine(test.ToString());

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Chapter19_zad2
{
    class FastAdd<T> where T : IComparable
    {
        private List<T> elements;
        private T minElement;

        public FastAdd(T value)
        {
            this.elements = new List<T>(){ value };
            this.minElement = value;
        }

        public void Add(T element)
        {
            this.elements.Add(element);

            //int test = MinElement.CompareTo(element);

            if (MinElement.CompareTo(element) == 1)
            {
                this.minElement = element;
            }

        }
        public T MinElement
        {
            get
            {
                return this.minElement;
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FastAdd<int> myList = new FastAdd<int>(123);
            myList.Add(44);
            myList.Add(123);
            myList.Add(1);
            myList.Add(2);
            Console.WriteLine(myList.MinElement);

            FastAdd<string> myList2 = new FastAdd<string>("some");
            myList2.Add("ab");
            myList2.Add("aaaa");
            Console.WriteLine(myList2.MinElement);


            Console.ReadKey();
        }
    }
}

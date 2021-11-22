using System;
using System.Collections.Generic;

namespace Rozdzial22_zad2_Extenstion_Methods_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
			//2. Implement the following extension methods for the classes, implementing the interface IEnumerable<T>: Sum(), Min(), Max(), Average().

			List<int> lista = new List<int> { 10, 20, 30, 8, 7, 4, 3, 2, 5 };
			var t = ExtensionMethods.Min(lista, (x => x > 2)); //zwraca 3 przez ograniczenie selektora (x musi byc wieksze od 2)
			Console.WriteLine("Minimal value from this collection: {0}", t);

			var tt = ExtensionMethods.Min(lista); // zwraca 2, ze wzgledu na nieokreslenie selektora kazda wartosc ma true
			Console.WriteLine("Minimal value from this collection: {0}", tt);

			double b = 2;

			var a = ExtensionMethods.SumTwoNumbers(2.0, b);

			Console.ReadKey();
        }


	}


	public static class ExtensionMethods
	{
		public static T SumTwoNumbers<T>(T a, T b)
		{
			dynamic a1 = a;
			dynamic b1 = b;

			return a1 + b1;
		}
		public static double Average<T>(this IEnumerable<T> collection, Func<T, bool> selector = null) where T : IComparable
        {
			using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
				selector = selector ?? (x => true);
				while (enumerator.MoveNext())
                {
					if (selector(enumerator.Current))
                    {
						dynamic sum = enumerator.Current;
						int count = 1;
						while (enumerator.MoveNext())
                        {
							sum += enumerator.Current;
							count++;
                        }
						return sum / (double)count;
                    }
                }					
            }
			throw new InvalidOperationException("Collection is empty or there are no elements in it that satisfy the condition");
		}
		public static T Sum<T>(this IEnumerable<T> collection, Func<T,bool> selector = null) where T : IComparable<T>
        {
			using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
				selector = selector ?? (x => true);
				while (enumerator.MoveNext())
                {
					if (selector(enumerator.Current))
                    {
						dynamic sum = enumerator.Current;
						while (enumerator.MoveNext())
                        {
							sum += enumerator.Current;
                        }
						return sum;
                    }
                }

            }
			throw new InvalidOperationException("Collection is empty or there are no elements in it that satisfy the condition");
		}

		public static T Min<T>(this IEnumerable<T> collection, Func<T, bool> selector = null) where T : IComparable<T>
		{
			using (IEnumerator<T> enumerator = collection.GetEnumerator())
			{
				selector = selector ?? (x => true);  // jesli selector != null to uzyj selektora, a jesli nie jest to uzyj (x => true), co powoduje ze kazda wartosc jest true
				while (enumerator.MoveNext())
				{
					if (selector(enumerator.Current))
					{
						T min = enumerator.Current;
						while (enumerator.MoveNext())
						{
							if (selector(enumerator.Current) && enumerator.Current.CompareTo(min) < 0)
							{
								min = enumerator.Current;
							}
						}
						return min;
					}
				}

				throw new InvalidOperationException("Collection is empty or there are no elements in it that satisfy the condition");
			}
		}

		public static T Max<T>(this IEnumerable<T> collection, Func<T,bool> selector = null) where T : IComparable
        {
			using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
				selector = selector ?? (x => true);
				while (enumerator.MoveNext())
                {
					if (selector(enumerator.Current))
                    {
						T max = enumerator.Current;
						while (enumerator.MoveNext())
                        {
							if (selector(enumerator.Current) && enumerator.Current.CompareTo(max) > 0)
                            {
								max = enumerator.Current;
                            }
                        }
						return max;
                    }
                }
            }

			throw new InvalidOperationException("Collection is empty or there are no elements in it that satisfy the condition");
		}
	}
}

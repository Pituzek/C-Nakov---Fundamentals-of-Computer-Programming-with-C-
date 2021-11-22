using System;

namespace Rodzial4_zad5
{
    class Program
    {
        static void Main(string[] args)
        {
         		Console.WriteLine("Podaj liczbe a");
				int a = int.Parse(Console.ReadLine());
				//int a = 14;

				Console.WriteLine("Podaj liczbe b");
				int b = int.Parse(Console.ReadLine());
				//int b = 25;


				int liczba = (b>a ? b-a : (a-b));

				int licznik = 0;

				int[] tablica = new int[liczba];

				tablica[0] = a;

				for (int i = 0; i < tablica.Length; i++)
				{
					if (i == 0)
					{
						tablica[i] += 1;
					}
					else
						tablica[i] = tablica[i - 1] + 1;

					Console.WriteLine(tablica[i]);
				}

				foreach (int i in tablica)
				{

					if (i % 5 == 0)
					{
						licznik++;
					}


				}

			Console.WriteLine("{0}", licznik);

			Console.ReadKey();

			}
		
		

	}
    
}

using System;

namespace Rozdzial4_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
           /* A given company has name, address, phone number, fax number, web site and manager. 
            * The manager has name, surname and phone number.Write a program that reads information 
            * about the company and its manager and then prints it on the console.                               
            */

            Console.WriteLine("Podaj nazwe firmy");
                string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj adres firmy");
                string adres = Console.ReadLine();
            Console.WriteLine("Podaj numer tel do firmy");
                string numerTelFirmy = Console.ReadLine();
            Console.WriteLine("Podaj numer fax do firmy");
                string numerFaxFirmy = Console.ReadLine();
            Console.WriteLine("Podaj adres www firmy");
                string stronaWWW = Console.ReadLine();
            Console.WriteLine("Podaj imie menadzera");
                string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko menadzera");
                string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj tel menadzera");
                string telMenadzera = Console.ReadLine();

            Console.WriteLine("Nazwa firmy: {0:10} \n" + "Adres firmy: {1:10} \n" + 
                              "Tel: {2:10} \n" + "Fax: {3:10} \n" + "www: {4:10} \n" + "\n" +
                              "Imie: {5:10} \n" + "Nazwisko: {6:10} \n" + "Tel: {7:10}"
                              ,nazwa,adres,numerTelFirmy,numerFaxFirmy ,stronaWWW ,imie ,nazwisko ,telMenadzera );

            Console.ReadKey();
        }
    }
}

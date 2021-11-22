using System;

namespace Rozdzial11_zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9. Write a program, which calculates the count of workdays between the current date and another given date after the current (inclusive). Consider that workdays are all days from Monday to Friday, which are not public holidays, except when Saturday is a working day. The program should keep a list of predefined public holidays, as well as a list of predefined working Saturdays.");

            DateTime[] wakacje = new DateTime[]
            {
                new DateTime(2021, 1, 1),
                new DateTime(2021, 1, 6),
                new DateTime(2021, 2, 14),
                new DateTime(2021, 3, 28),
                new DateTime(2021, 4, 2),
                new DateTime(2021, 4, 4),
                new DateTime(2021, 4, 5),
                new DateTime(2021, 5, 1),
                new DateTime(2021, 5, 3),
                new DateTime(2021, 5, 23),
                new DateTime(2021, 5, 26),
                new DateTime(2021, 6, 3),
                new DateTime(2021, 6, 23),
                new DateTime(2021, 8, 15),
                new DateTime(2021, 10, 31),
                new DateTime(2021, 11, 1),
                new DateTime(2021, 11, 11),
                new DateTime(2021, 12, 24),
                new DateTime(2021, 12, 25),
                new DateTime(2021, 12, 26),
                new DateTime(2021, 12, 31),
        };

            DateTime[] pracujaceSoboty = new DateTime[]
            {
                new DateTime(2021,4,10),
                new DateTime(2021,4,24),
                new DateTime(2021,5,8),
                new DateTime(2021,5,22),
                new DateTime(2021,6,12),
                new DateTime(2021,6,26),
            };

            int dniPracujace = 0;

            Console.WriteLine("Wpisz date koncowa RRRR/MM/DD");
            DateTime dataKonca = System.Convert.ToDateTime(Console.ReadLine());
            DateTime teraz = DateTime.Now;

            do
            {
                teraz = teraz.AddDays(1);

                if ((teraz.DayOfWeek >= DayOfWeek.Monday) && (teraz.DayOfWeek <= DayOfWeek.Friday))
                    dniPracujace++;

                foreach (var i in wakacje)
                    if (i.Date == teraz.Date)
                       dniPracujace--;

                foreach (var i in pracujaceSoboty)
                    if (i.Date == teraz.Date)
                        dniPracujace++;

            } while (teraz.Date != dataKonca.Date);

            Console.WriteLine("\n{0} dni pracujacych.", dniPracujace);


            Console.ReadKey();
        }
    }
}

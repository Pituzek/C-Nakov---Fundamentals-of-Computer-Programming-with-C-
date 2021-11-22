using System;

namespace Rozdzial7_zad14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14. Write a program, which finds the longest sequence of equal stringelements in a matrix.A sequence in a matrix we define as a set of neighbor elements on the same row, column or diagonal.");

            int tempSeq = 1, seq = 1;
            string element = "e";

            Console.WriteLine("Podaj n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj m");
            int m = int.Parse(Console.ReadLine());

            string[,] tab = new string[n, m];

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    Console.Write("[{0}] [{1}]", n, m);
                    tab[n, m] = Console.ReadLine();
                }
            }

            for( int rows=0; rows < tab.GetLength(0); rows++)
            {

                for( int columns=0; columns < tab.GetLength(1)-1 ; columns++)
                {
                    if (tab[rows, columns] == tab[rows, columns + 1]) tempSeq++;
                    else tempSeq = 1;
                    
                    
                    if(seq<tempSeq)
                    {
                        seq = tempSeq;
                        element = tab[rows, columns];
                    }

                }

                tempSeq = 1;
            }

            for( int rows = 0; rows < tab.GetLength(0); rows++)
            {

                for( int cols=0; cols < tab.GetLength(1)-1; cols++)
                {
                    if (tab[rows, cols] == tab[rows + 1, cols]) tempSeq++;
                    else tempSeq = 1;

                    if (seq<tempSeq)
                    {
                        seq = tempSeq;
                        element = tab[rows, cols];
                    }    

                }

                tempSeq = 1;
            }

            for( int i=0; i < tab.GetLength(0)-1; i++)
            {
                for( int j= 0; j < tab.GetLength(1)-1; j++)
                {
                    for (int rows = i, cols = j; rows < tab.GetLength(0) && cols < tab.GetLength(1); rows++, cols++)
                    {
                        if (tab[rows, cols] == tab[rows + 1, cols + 1]) tempSeq++;
                        else tempSeq = 1;

                        if(seq<tempSeq)
                        {
                            seq = tempSeq;
                            element = tab[rows, cols];
                        }

                    }

                    tempSeq = 1;

                }
            }


            for ( int i=0; i < tab.GetLength(0)-1; i++)
            {
                for( int j=1; j < tab.GetLength(1); j++)
                {
                    for ( int rows = i, cols = j; rows < tab.GetLength(0) - 1 && cols > 0; rows++, cols--)
                    {
                        if ( tab[rows, cols] == tab[rows + 1, cols - 1]) tempSeq++;
                        else tempSeq = 1;

                        if( seq < tempSeq)
                        {
                            seq = tempSeq;
                            element = tab[rows, cols];
                                
                        }

                    }

                    tempSeq = 1;

                }


            }

            for (int i = 0; i < seq; i++) Console.Write("{0}, ", element);

            Console.ReadKey();
        }
    }
}

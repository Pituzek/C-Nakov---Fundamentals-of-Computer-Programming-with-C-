using System;
using System.IO;
using System.Collections.Generic;

namespace Rozdzial17_zad11
{
    
    public class DirectoryTraverseDFS
    {
        
        private static void TraverseDir(DirectoryInfo dir, string spaces)
        {
            // Visit the current directory
            Console.WriteLine(spaces + dir.FullName);

            DirectoryInfo[] children;

            try
            {
                children = dir.GetDirectories();
            }
            catch(System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Oops");
                return;
            }
            catch (System.Security.SecurityException)
            {
                Console.WriteLine("The caller does not have the required permission.");
                return;
            }
            catch (System.UnauthorizedAccessException)
            {
                Console.WriteLine("The caller does not have the required permission.");
                return;
            }

            FileInfo[] files;

            try
            {
                files = dir.GetFiles("*.exe");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (System.Security.SecurityException)
            {
                Console.WriteLine("No permissions to access {0}", dir);
                return;
            }

            foreach ( FileInfo f in files)
            {
                Console.WriteLine(f.Name);
            }
         
            // For each child go and visit its sub-tree
            foreach (DirectoryInfo child in children)
            {
                TraverseDir(child, spaces + " ");
            }
        }

        /// <summary>
        /// Traverses and prints given directory recursively
        /// </summary>
        /// <param name="directoryPath">the path to the directory
        /// which should be traversed</param>
        public static void TraverseDir(string directoryPath)
        {
            TraverseDir(new DirectoryInfo(directoryPath), string.Empty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //11. Write a program that searches the directory C:\Windows\ and all its subdirectories recursively and prints all the files which have extension *.exe.

            DirectoryTraverseDFS.TraverseDir(@"C:\Windows\");

            Console.ReadKey();
        }
    }
}

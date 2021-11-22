using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozdzial17_zad12
{
    class File
    {
        private string name;
        private long size;

        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public long Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
    }

    class Folder
    {
        private string fName;
        private File[] files;
        private Folder[] childFolders;

        public Folder()
        {
        }

        public Folder(string name, int filesSize, int childFoldersSize)
        {
            this.fName = name;
            files = new File[filesSize];
            childFolders = new Folder[childFoldersSize];
        }
        public Folder(string name)
        {
            this.fName= name;
        }

        public void SetFilesSize(int filesSize)
        {
            files = new File[filesSize];
        }
        public void SetFoldersSize(int childFoldersSize)
        {
            childFolders = new Folder[childFoldersSize];
        }

        public string FName
        {
            get { return this.fName; }
            set { this.fName = value; }
        }

        public File[] Files
        {
            get { return this.files; }
            set { this.files = value; }
        }

        public Folder[] ChildFolders
        {
            get { return this.childFolders; }
            set { this.childFolders = value; }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //12.Define classes File { string name, int size} and Folder { string name, File[] files, Folder[] childFolders}.
            //Using these classes, build a tree that contains all files and directories on your hard disk, starting from C:\Windows\.
            //Write a method that calculates the sum of the sizes of files in a sub-tree and a program that tests this method.
            //To crawl the directories use recursively crawl depth(DFS).
            string directoryPath = "C:\\WINDOWS";

            Folder C = GetFiles(directoryPath);

            Console.WriteLine(GetFolderSize("C:\\WINDOWS"));

            Console.ReadKey();
        }

        private static Folder GetFiles(string directoryPath)
        {
            Folder allFiles = new Folder();
            Folder newFolder = allFiles;
            TraverseDir(new DirectoryInfo(directoryPath), newFolder);

            return newFolder;
        }

        private static double GetFolderSize(string directoryPath)
        {
            return TraverseSizeDir(new DirectoryInfo(directoryPath)) / (1024 * 1024);
        }

        private static double TraverseSizeDir(DirectoryInfo dir)
        {
            double sum = 0;
            try
            {
                DirectoryInfo[] children = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();


                foreach (FileInfo file in files)
                {
                    sum += (file.Length);
                }

                foreach (DirectoryInfo child in children)
                {
                    sum += TraverseSizeDir(child);
                }
            }
            catch (Exception)
            {
            }
            return sum;
        }
        private static void TraverseDir(DirectoryInfo dir, Folder newFolder)
        {
            try
            {
                DirectoryInfo[] children = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                newFolder.FName = dir.FullName;
                newFolder.SetFilesSize(files.Length);
                newFolder.SetFoldersSize(children.Length);

                for (int file = 0; file < files.Length; file++)
                {
                    newFolder.Files[file] = new File(files[file].Name, files[file].Length);
                }

                for (int child = 0; child < children.Length; child++)
                {
                    Folder backtrack = newFolder;

                    newFolder.ChildFolders[child] = new Folder(children[child].Name);
                    newFolder = newFolder.ChildFolders[child];

                    TraverseDir(children[child], newFolder);

                    newFolder = backtrack;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}

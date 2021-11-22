using System;
using System.Collections.Generic;
using System.Linq;

namespace Rozdzial17_zad13
{
    public class Graph
    {
        private List<int>[] childNodes;
        private List<List<int>> cycles;

        public Graph(List<int>[] childNodes)
        {
            this.childNodes = childNodes;
            this.cycles = new List<List<int>>();
        }

        public int NodesCount
        {
            get { return this.childNodes.Length; }
        }

        public List<List<int>> FindCycles()
        {
            for (int node = 0; node < childNodes.Length; node++)
            {
                List<int> path = new List<int>();
                path.Add(node);
                ProcessPaths(node, path);
            }

            return this.cycles;
        }

        private void ProcessPaths(int current, List<int> path)
        {
            foreach(var node in childNodes[current])
            {
                if (node == path[0])
                {
                    path.Add(node);
                    if(!IsAlreadyFound(path))
                    {
                        cycles.Add(new List<int>(path));
                    }
                    path.RemoveAt(path.Count - 1);
                    return;
                }
                else if (!path.Contains(node))
                {
                    path.Add(node);
                    ProcessPaths(node, path);
                    path.RemoveAt(path.Count - 1);
                }
            }
        }

        private bool IsAlreadyFound(List<int> foundCycle)
        {
            List<int> reversed = new List<int>(foundCycle);
            reversed.Reverse();

            foreach (var cycle in cycles)
            {
                if (CompareLists(cycle, foundCycle) || CompareLists(cycle, reversed))
                {
                    return true;
                }
            }

            return false;
        }

        private bool CompareLists(List<int> first, List<int> second)
        {
            if (first.Count != second.Count)
            {
                return false;
            }

            for (int i = 0; i < first.Count; i++)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }

            return true;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //13. * Write a program that finds all loops in a directed graph.
            
            Graph graph = new Graph(ReadGraph());

            PrintResult(graph.FindCycles());

            Console.ReadKey();
        }

        static List<int>[] ReadGraph()
        {
            // Read number of nodes N
            string input = Console.ReadLine();
            int N = int.Parse(input);

            // Read graph as adjacency list
            List<int>[] graph = new List<int>[N];

            for (int i = 0; i < N; i++)
            {
                graph[i] = new List<int>();

                input = Console.ReadLine();
                string[] childs = input.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var child in childs)
                {
                    graph[i].Add(int.Parse(child));
                }
            }

            return graph;
        }

        static void PrintResult(List<List<int>> cycles)
        {
            if (cycles.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = 0; i < cycles.Count; i++)
                {
                    for (int j = 0; j < cycles[i].Count; j++)
                    {
                        if (j < cycles[i].Count - 1)
                        {
                            Console.Write("{0}, ", cycles[i][j]);
                        }
                        else
                        {
                            Console.WriteLine("{0}", cycles[i][j]);
                        }
                    }
                }
            }
        }

    }
}

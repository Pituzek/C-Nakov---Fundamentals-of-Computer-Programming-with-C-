using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Rozdzial17_zad9
{

    class Graph
    {
        internal const int MaxNode = 1024;
        private List<int>[] childNodes;
        private List<int> dfsPath;

        public Graph(List<int>[] childNodes)
        {
            this.childNodes = childNodes;
            this.dfsPath = new List<int>();
        }

        public List<int> DFSPath

        {
            get { return dfsPath; }
        }

        public void TraverseDFSRecursive(int node, bool[] visited)
        {
            if (!visited[node])
            {
                visited[node] = true;
                dfsPath.Add(node);
                foreach (int childNode in childNodes[node])
                {
                    TraverseDFSRecursive(childNode, visited);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 9.Implement a recursive traversal in depth in an undirected graph and a program to test it.

            Graph g = new Graph(ReadGraph());

            bool[] visited = new bool[Graph.MaxNode];

            g.TraverseDFSRecursive(0, visited);

            PrintResult(g.DFSPath);

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

        static void PrintResult(List<int> path)
        {
            // Print result path in format {start node1 node2 ... end}
            StringBuilder builder = new StringBuilder(path.Count * 2);

            for (int i = 0; i < path.Count; i++)
            {
                if (i < path.Count - 1)
                {
                    builder.Append(String.Format("{0} ", path[i]));
                }
                else
                {
                    builder.Append(path[i]);
                }
            }

            Console.WriteLine(builder);
        }


    }
}

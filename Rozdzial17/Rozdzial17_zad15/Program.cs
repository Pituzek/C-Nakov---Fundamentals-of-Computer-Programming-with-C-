using System;
using System.Collections.Generic;
using System.Linq;


namespace Rozdzial17_zad15
{
    public class Graph
    {
        private IDictionary<int, int>[] childNodes;

        public Graph(IDictionary<int, int>[] childNodes)
        {
            this.childNodes = childNodes;
        }

        public int NodesCount
        {
            get { return childNodes.Length; }
        }

        public int[] FindShortestPaths(int startNode)
        {
            int[] distances = new int[childNodes.Length];
            int[] previous = new int[childNodes.Length];
            HashSet<int> nodes = new HashSet<int>();

            for (int i = 0; i < childNodes.Length; i++)
            {
                nodes.Add(i);
                previous[i] = int.MinValue;
                if (i != startNode)
                {
                    distances[i] = int.MaxValue;
                }
                else
                {
                    distances[i] = 0;
                }
            }

            distances = CalculatePaths(nodes, distances, previous);

            return distances;
        }

        private int[] CalculatePaths(HashSet<int> nodes, int[] distances, int[] previous)
        {
            while (nodes.Count > 0)
            {
                int node = GetNextNode(distances, nodes);
                if (node == int.MaxValue)
                {
                    break;
                }

                nodes.Remove(node);

                foreach (var child in childNodes[node])
                {
                    if (nodes.Contains(child.Key))
                    {
                        int newDistance = distances[node] + child.Value;
                        if (newDistance < distances[child.Key])
                        {
                            distances[child.Key] = newDistance;
                            previous[child.Key] = node;
                        }
                    }
                }
            }
            return distances;
        }

        private int GetNextNode(int[] distances, HashSet<int> nodes)
        {
            int min = int.MaxValue;
            int next = int.MaxValue;

            foreach (var node in nodes)
            {
                if (distances[node] < min)
                {
                    min = distances[node];
                    next = node;
                }
            }

            return next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //15. Suppose we are given a weighted oriented graph G (V, E), in which the weights on the side are nonnegative numbers.
            //Write a program that by a given vertex x from the graph finds the shortest paths from it to all other vertical.

            Graph graph = new Graph(ReadGraph());

            // Read start node
            int startNode = int.Parse(Console.ReadLine());

            PrintResult(graph.FindShortestPaths(startNode));

            Console.ReadKey();
        }
        static IDictionary<int, int>[] ReadGraph()
        {
            // Read number of nodes N
            string input = Console.ReadLine();
            int N = int.Parse(input);

            // Read graph as adjacency list with weights
            Dictionary<int, int>[] graph = new Dictionary<int, int>[N];

            for (int i = 0; i < N; i++)
            {
                graph[i] = new Dictionary<int, int>();

                input = Console.ReadLine();
                string[] values = input.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (values.Length > 0)
                {
                    for (int j = 0; j < values.Length; j += 2)
                    {
                        graph[i].Add(int.Parse(values[j]), int.Parse(values[j + 1]));
                    }
                }
            }

            return graph;
        }

        static void PrintResult(int[] distances)
        {
            for (int i = 0; i < distances.Length; i++)
            {
                if (distances[i] < int.MaxValue)
                {
                    Console.WriteLine("{0} - {1}", i, distances[i]);
                }
                else
                {
                    Console.WriteLine("{0} - No", i);
                }
            }
        }
    }

}

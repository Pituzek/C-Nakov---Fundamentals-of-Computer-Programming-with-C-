using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozdzial17_zad7
{
    public class Graph
    {
        private List<int>[] childNodes;

        public Graph(int size)
        {
            this.childNodes = new List<int>[size];
            for (int i = 0; i < size; i++)
            {
                this.childNodes[i] = new List<int>();
            }

        }

        public Graph(List<int>[] childNodes)
        {
            this.childNodes = childNodes;
        }

        public int Size
        {
            get { return this.childNodes.Length; }
        }

        public void AddEdge(int u, int v)
        {
            childNodes[u].Add(v);
        }

        public void RemoveEdge(int u, int v)
        {
            childNodes[u].Remove(v);
        }

        public bool HasEdge(int u, int v)
        {
            bool hasEdge = childNodes[u].Contains(v);
            return hasEdge;
        }

        public IList<int> GetSuccessors(int v)
        {
            return childNodes[v];
        }

        public void SearchBFS(Graph graph, int u, int v)
        {
            Queue<IList<int>> queue = new Queue<IList<int>>();

            bool[] visited = new bool[graph.Size];

            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = false;
            }

            queue.Enqueue(graph.GetSuccessors(u));

            visited[u] = true;

            while ( queue.Count > 0)
            {

            }


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // 7.Let’s have as given a graph G(V, E) and two of its vertices x and y.
            // Write a program that finds the shortest path between two vertices measured in number of vertices staying on the path.


            Graph graph = new Graph(new List<int>[]
            {
                new List<int> {4},          // successors of vertice 0
                new List<int> {1, 2, 6},    // successors of vertice 1
                new List<int> {1, 6},       // successors of vertice 2
                new List<int> {6},          // successors of vertice 3
                new List<int> {0},          // successors of vertice 4
                new List<int> {},           // successors of vertice 5
                new List<int> {1, 2, 3}     // successors of vertice 6

            });

            

            graph.SearchBFS(graph, 1, 6);


            Console.ReadKey();
        }
    }
}

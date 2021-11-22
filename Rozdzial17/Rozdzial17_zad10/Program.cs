using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozdzial17_zad10
{
    public class Graph
    {
        internal const int MaxNode = 1024;
        private List<int>[] childNode;
        private List<int> bfsPath;
        //public int value;

        public Graph(List<int>[] childNode)
        {
            this.childNode = childNode;
            //this.value = childNode.V
            this.bfsPath = new List<int>();
        }

        public List<int> BFSPath
        {
            get { return bfsPath; }
        }

        public void GetSuccessorsOK()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < childNode[i].Count; j++)
                {
                    object test = childNode[i][j];
                    Console.WriteLine(test);
                }
                
            }
           // return value;
        }

        public int GetSuccessorsValue(List<int> childNode, int index)
        {
            int i = index;
            int value = childNode[i];
            //Console.WriteLine(value);
            
            return value;
        }

        public void TraverseBFS(int node)
        {

            bool[] visited = new bool[Graph.MaxNode];
            Queue<int> q = new Queue<int>();
            q.Enqueue(node);
            visited[node] = true;
            Console.WriteLine("");

            while (q.Count > 0)
            {
                int currentNode = q.Dequeue();
                bfsPath.Add(currentNode);

                /*
                
                foreach (int childNode in childNode[currentNode])
                {
                    if (!visited[childNode])
                    {
                        q.Enqueue(childNode);
                        visited[childNode] = true;
                    }
                }
                */

                for (int j = 0; j < childNode[currentNode].Count; j++)
                {
                    int value = GetSuccessorsValue(childNode[currentNode], j);

                    // tak tez mozna uzyskac wartosc w int, bez wywolania metody GetSuccessorsValue:
                    int t = childNode[currentNode][j];
                    Console.Write(" {0}", t);

                    if (!visited[value])
                    {
                        q.Enqueue(value);
                        visited[value] = true;
                    }
                }
                Console.WriteLine("");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //10. Write breadth first search (BFS), based on a queue, to traverse a directed graph.

            Graph g = new Graph(ReadGraph());

            //g.GetSuccessorsOK();

            g.TraverseBFS(0);
            PrintResult(g.BFSPath);

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

            Console.WriteLine("\n" + builder);
        }


    }
}

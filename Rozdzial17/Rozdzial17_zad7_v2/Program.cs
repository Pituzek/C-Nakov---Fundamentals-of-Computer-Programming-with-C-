using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozdzial17_zad7_v2
{

    public class Graph
    {
        int[,] nodes;
        bool[] visited;
        int[] currentStepsLength;
        int[] currentPath;

        public Graph(int[,] nodes)
        {
            this.nodes = nodes;
            this.visited = new bool[nodes.GetLength(0)];
            this.currentStepsLength = new int[nodes.GetLength(0)];

            for (int i = 0; i < currentStepsLength.GetLength(0); i++)
            {
                currentStepsLength[i] = int.MaxValue;
            }

            currentPath = new int[nodes.GetLength(0)];
        }

        private int GetPreviousNode(int currentNode)
        {
            return currentPath[currentNode];
        }

        public Stack<int> GetPath(int start, int end)
        {
            FindShortestPath(start, end);
            Stack<int> path = new Stack<int>();

            int current = end;

            do
            {
                path.Push(current);
                current = GetPreviousNode(current);

            } while (current != start);

            path.Push(current);

            return path;
        }

        private void FindShortestPath(int start, int end)
        {
            Dictionary<int, int> notVisited = new Dictionary<int, int>();

            for (int i = 0; i < visited.GetLength(0); i++)
            {
                notVisited.Add(i, i);
            }

            int currentNode = start;

            while (notVisited.Count > 0)
            {
                List<int> connectedNodes = GetConnectedNodes(currentNode);

                foreach(int node in connectedNodes)
                {
                    if (!visited[node])
                    {
                        if (currentStepsLength[currentNode] < int.MaxValue)
                        {
                            int newLength = currentStepsLength[currentNode] + nodes[currentNode, node];

                            if (newLength < currentStepsLength[node])
                            {
                                currentStepsLength[node] = currentStepsLength[currentNode] + nodes[currentNode, node];
                                currentPath[node] = currentNode;
                            }
                        }
                        else
                        {
                            currentStepsLength[node] = nodes[currentNode, node];
                            currentPath[node] = currentNode;
                        }
                    }
                }

                visited[currentNode] = true;

                if (currentNode == end)
                {
                    return;
                }

                notVisited.Remove(currentNode);

                int currentMinValue = int.MaxValue;
                int currentMinIndex = -1;

                for (int i = 0; i < currentStepsLength.GetLength(0); i++)
                {
                    if (!visited[i] && currentMinValue > currentStepsLength[i])
                    {
                        currentMinValue = currentStepsLength[i];
                        currentMinIndex = i;
                    }
                }

                if (currentMinValue == int.MaxValue)
                {
                    return;
                }

                currentNode = currentMinIndex;

            }
        }

        private List<int> GetConnectedNodes(int node)
        {
            List<int> lst = new List<int>();

            for (int i = 0; i < nodes.GetLength(0); i++)
            {
                if (nodes[node, i] > 0)
                {
                    lst.Add(i);
                }
            }

            return lst;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
             * 10
0, 1, 0, 0, 0, 0, 0, 1, 0, 0
0, 0, 0, 1, 0, 0, 1, 0, 0, 0
0, 0, 0, 0, 0, 0, 0, 1, 0, 0
0, 0, 1, 0, 0, 0, 0, 0, 0, 0
0, 0, 0, 0, 0, 1, 0, 0, 0, 0
0, 0, 0, 0, 1, 0, 0, 0, 0, 0
0, 0, 0, 0, 0, 0, 0, 0, 0, 0
0, 0, 1, 0, 0, 0, 0, 0, 0, 1
0, 0, 0, 0, 0, 0, 0, 0, 0, 0
0, 0, 0, 0, 0, 0, 0, 0, 0, 0
             * 0, 2
             * 
             */

            Graph g = new Graph(ReadGraph());

            string input = Console.ReadLine();
            string[] searchedPath = input.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            Stack<int> path = g.GetPath(int.Parse(searchedPath[0]), int.Parse(searchedPath[1]));

            PrintResult(path);
        }

        static int[,] ReadGraph()
        {
            string input = Console.ReadLine();
            int N = int.Parse(input);

            int[,] graph = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine();
                string[] rowElements = input.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < N; j++)
                {
                    graph[i, j] = int.Parse(rowElements[j]);
                }
            }

            return graph;
        }

        static void PrintResult(Stack<int> path)
        {
            StringBuilder builder = new StringBuilder(path.Count * 2);

            while (path.Count > 0)
            {
                if (path.Count == 1)
                {
                    builder.Append(path.Pop());
                }
                else
                {
                    builder.Append(String.Format("{0} ", path.Pop()));
                }
            }

            Console.WriteLine(builder);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class ShortestPath_FloyedWarshall
    {
        private const int Inf = int.MaxValue;
        private int vertex, edge;
        private int[][] adj;

        public ShortestPath_FloyedWarshall(int vertex, int edge)
        {
            this.vertex = vertex;
            this.edge = edge;
            adj = new int[vertex][];
            for(int i = 0; i < vertex; i++)
            {
                adj[i] = new int[vertex];
            }
        }

        public void print()
        {
            Console.WriteLine();
            for (int i = 0; i < vertex; i++)
            {
                for (int j = 0; j < vertex; j++)
                {
                    if (adj[i][j] == Inf)
                    {
                        Console.Write("Inf".ToString().PadLeft(5, ' '));
                    }
                    else
                    {
                        Console.Write(adj[i][j].ToString().PadLeft(5, ' '));
                    }
                }
                Console.WriteLine();
            }
        }

        public void floyedWarshall()
        {
            for (int k = 0; k < vertex; k++)
            {
                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        if ((adj[i][k] != Inf && adj[k][j] != Inf) && adj[i][j] > adj[i][k] + adj[k][j])
                        {
                            adj[i][j] = adj[i][k] + adj[k][j];
                        }
                    }
                }
            }
            for (int i = 0; i < vertex; i++)
            {
                if (adj[i][i] != 0)
                {
                    Console.WriteLine("there is a negative weighted graph...");
                    break;
                }
            }
        }

        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int vertex = int.Parse(str[0]);
            int edge = int.Parse(str[1]);
            ShortestPath_FloyedWarshall graph = new ShortestPath_FloyedWarshall(vertex, edge);
            /// adjacency matrix create...

            for (int i = 0; i < vertex; i++)
            {
                for (int j = 0; j < vertex; j++)
                {
                    graph.adj[i][j] = Inf;
                }
            }
            for (int i = 0; i < edge; i++)
            {
                string[] str1 = Console.ReadLine().Split();
                int a = int.Parse(str1[0]);
                int b = int.Parse(str1[1]);
                int wt = int.Parse(str1[2]);
                graph.adj[a][b] = wt;
                //graph.adj[b][a] = wt;     // for undirected graph
            }
            /// main diagonal a shob 0 thakte hobe...
            for (int i = 0; i < vertex; i++)
            {
                graph.adj[i][i] = 0;
            }
            graph.floyedWarshall();
            graph.print();
        }
    }
}

/*
input:
5 8
0 1 -1
0 2 4
1 2 3
1 3 2
1 4 2
3 2 5
3 1 1
4 3 -3

output:
0     -1    2     -2    1
Inf   0     3     -1    2
Inf   Inf   0     Inf   Inf
Inf   1     4     0     3
Inf   -2    1     -3    0

input:
4 4
0 1 5
0 3 10
1 2 3
2 3 1

negative wighted circle
4 4
0 1 1
1 2 -5
2 3 2
3 1 2

*/

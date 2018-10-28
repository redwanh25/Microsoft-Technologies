using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class MaxFlow
    {
        private int[][] residual;
        private int[] parent;
        private bool[] vis;
        int max, min = int.MaxValue;

        public MaxFlow(int index)
        {
            residual = new int[index][];
            residual = residual.Select(i => new int[index]).ToArray();
            parent = new int[index];
            vis = new bool[index];
        }

        public bool bfs(int src, int dist)
        {
            vis = vis.Select(i => false).ToArray();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(src);
            vis[src] = true;
            while(queue.Count != 0)
            {
                int u = queue.Dequeue();
                for (int v = min; v <= max; v++)
                {
                    if (vis[v] == false && residual[u][v] > 0)
                    {
                        vis[v] = true;
                        queue.Enqueue(v);
                        parent[v] = u;
                        if(vis[dist] == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public int MaximumFlow(int source, int dist)
        {
            int max = 0;
            while (bfs(source, dist) == true)
            {
                int flow = int.MaxValue;
                for(int v = dist; v != source; v = parent[v])
                {
                    int u = parent[v];
                    flow = Math.Min(flow, residual[u][v]);
                }
                for(int v = dist; v != source; v = parent[v])
                {
                    int u = parent[v];
                    residual[u][v] -= flow;
                    residual[v][u] += flow;
                }
                max += flow;
            }
            return max;

        }

        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int vertex = int.Parse(str[0]);
            int edge = int.Parse(str[1]);
            MaxFlow graph = new MaxFlow(100);
            for(int i = 0; i < edge; i++)
            {
                string[] str1 = Console.ReadLine().Split();
                int u = Convert.ToInt32(str1[0]);
                int v = Convert.ToInt32(str1[1]);
                int wt = Convert.ToInt32(str1[2]);
                graph.max = Math.Max(graph.max, Math.Max(u, v));
                graph.min = Math.Min(graph.min, Math.Min(u, v));
                graph.residual[u][v] = wt;
            }
            string[] str2 = Console.ReadLine().Split();
            int source = Convert.ToInt32(str2[0]);
            int dist = Convert.ToInt32(str2[1]);
            Console.WriteLine("Max = " + graph.MaximumFlow(source, dist));
        }
    }
}

/*

6 10
0 1 16
0 2 13
1 2 10
2 1 4
1 3 12
3 2 9
2 4 14
4 3 7
3 5 20
4 5 4
0 5

7 11
1 2 3
5 2 1
2 3 4
3 1 3
1 4 3
3 4 1
3 5 2
4 5 2
6 7 9
5 7 1
4 6 6
1 7

4 5
7 9 2
7 8 2
7 11 1
11 8 2
8 9 4
7 9

maximum bipartite matching
10 13
0 1 1
0 2 1
0 3 1
0 4 1
1 5 1
1 6 1
2 6 1
3 6 1
3 7 1
4 7 1
5 10 1
6 10 1
7 10 1
0 10
Max = 3

*/

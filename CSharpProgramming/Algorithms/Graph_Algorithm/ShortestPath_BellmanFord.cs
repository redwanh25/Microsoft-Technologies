using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class ShortestPath_BellmanFord
    {
        private int vertex, edge;
        private List<Tuple<int, int, int>> adj;
        private int[] cnt;
        private SortedSet<int> ss;
        private int[] parent;

        public ShortestPath_BellmanFord(int index, int vertex, int edge)
        {
            this.vertex = vertex;
            this.edge = edge;
            adj = new List<Tuple<int, int, int>>();
            cnt = new int[index];
            cnt = cnt.Select(i => int.MaxValue).ToArray();
            ss = new SortedSet<int>();
            parent = new int[index];
        }

        public int bellmanFord(int src)
        {
            cnt[src] = 0;
            for(int i = 0; i < vertex-1; i++)
            {
                for(int j = 0; j < edge; j++)
                {
                    int wt = adj[j].Item1;
                    int u = adj[j].Item2;
                    int v = adj[j].Item3;
                    if (cnt[u] != int.MaxValue && cnt[v] > cnt[u] + wt)
                    {
                        cnt[v] = cnt[u] + wt;
                        parent[v] = u;
                    }
                }
            }

            for (int j = 0; j < edge; j++)
            {
                int wt = adj[j].Item1;
                int u = adj[j].Item2;
                int v = adj[j].Item3;
                if (cnt[u] != int.MaxValue && cnt[v] > cnt[u] + wt)
                {
                    Console.WriteLine("Graph contains negative weight cycle");
                    return 0;
                }
            }
            return 1;
        }

        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int vertex = int.Parse(str[0]);
            int edge = int.Parse(str[1]);
            ShortestPath_BellmanFord graph = new ShortestPath_BellmanFord(200, vertex, edge);
            for (int i = 0; i < edge; i++)
            {
                string[] str1 = Console.ReadLine().Split();
                int u = int.Parse(str1[0]);
                int v = int.Parse(str1[1]);
                int wt = int.Parse(str1[2]);
                graph.adj.Add(Tuple.Create(wt, u, v));
                graph.ss.Add(u);
                graph.ss.Add(v);
            }
            string[] str2 = Console.ReadLine().Split();
            int source = int.Parse(str2[0]);
            int dis = int.Parse(str2[1]);
            int res = graph.bellmanFord(source);
            if(res != 0)
            {
                IEnumerable<int> it = graph.ss;
                foreach(int i in it)
                {
                    Console.WriteLine(source + " --> " + i + " min distance " + graph.cnt[i]);
                }
                Console.Write(dis);
                for(int v = dis; v != source; v = graph.parent[v])
                {
                    int u = graph.parent[v];
                    Console.Write(" " + u);
                }
                Console.WriteLine();
            }
        }
    }
}

/*

5 7
1 2 10
1 3 20
2 4 5
2 3 30
4 3 15
4 5 8
3 5 6
1

Geeks for Geeks (bellman ford)
5 8
0 1 -1
0 2 4
1 2 3
1 3 2
1 4 2
3 2 5
3 1 1
4 3 -3
0

negative wighted circle
4 4
1 2 1
2 3 -5
3 4 2
4 2 2
1

*/

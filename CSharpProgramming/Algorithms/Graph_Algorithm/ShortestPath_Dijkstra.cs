using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class ShortestPath_Dijkstra
    {
        private int vertex, edge;
        private List<Tuple<int, int>>[] adj;
        private int[] cnt;
        private int[] parent;
        private SortedSet<int> ss;

        public ShortestPath_Dijkstra(int index, int vertex, int edge)
        {
            this.vertex = vertex;
            this.edge = edge;
            adj = new List<Tuple<int, int>>[index];
            for(int i = 0; i < index; i++)
            {
                adj[i] = new List<Tuple<int, int>>();
            }
            cnt = new int[index];
            cnt = cnt.Select(i => int.MaxValue).ToArray();
            parent = new int[index];
            ss = new SortedSet<int>();
        }

        public void dijkstra(int src)
        {
            List<Tuple<int, int>> queue = new List<Tuple<int, int>>();
            queue.Add(Tuple.Create(0, src));
            cnt[src] = 0;
            while(queue.Count != 0)
            {
                int u = queue.First().Item2;
                queue.RemoveAt(0);
                for(int i = 0; i < adj[u].Count; i++)
                {
                    int v = adj[u][i].Item2;
                    int wt = adj[u][i].Item1;
                    if(cnt[v] > cnt[u] + wt)
                    {
                        cnt[v] = cnt[u] + wt;
                        queue.Add(Tuple.Create(cnt[v], v));
                        parent[v] = u;
                    }
                }
                queue.Sort();
            }
        }

        public void print(int source, int dist)
        {
            Console.WriteLine("\nVertex Distance from Source :");
            IEnumerator<int> iit = ss.GetEnumerator();
            while (iit.MoveNext())
            {
                Console.WriteLine("{0} --> {1} min distance {2} ", source, iit.Current, cnt[iit.Current]);
            }

            List<int> list = new List<int>();
            for(int v = dist; v != source; v = parent[v])
            {
                int u = parent[v];
                list.Add(u);
            }
            list.Reverse();

            Console.Write("\npath: ");
            IEnumerator<int> it = list.GetEnumerator();
            while (it.MoveNext())
            {
                Console.Write(it.Current + " --> ");
            }
            Console.WriteLine(dist);

        }

        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int vertex = int.Parse(str[0]);
            int edge = int.Parse(str[1]);
            ShortestPath_Dijkstra graph = new ShortestPath_Dijkstra(200, vertex, edge);
            for(int i = 0; i < edge; i++)
            {
                string[] str1 = Console.ReadLine().Split();
                int a = int.Parse(str1[0]);
                int b = int.Parse(str1[1]);
                int wt = int.Parse(str1[2]);
                graph.adj[a].Add(Tuple.Create(wt, b));
                graph.adj[b].Add(Tuple.Create(wt, a));
                graph.ss.Add(a);
                graph.ss.Add(b);
            }
            string[] str2 = Console.ReadLine().Split();
            int source = int.Parse(str2[0]);
            int destiny = int.Parse(str2[1]);
            graph.dijkstra(source);
            graph.print(source, destiny);
        }
    }
}

/*

3 3
1 2 5
2 3 5
1 3 9
1 3

Vertex Distance from Source :
1 --> 1 min distance 0
1 --> 2 min distance 5
1 --> 3 min distance 9

path: 1 --> 3

5 6
1 2 10
1 3 20
2 3 30
4 3 15
4 5 8
3 5 6
1 5

Vertex Distance from Source :
1 --> 1 min distance 0
1 --> 2 min distance 10
1 --> 3 min distance 20
1 --> 4 min distance 15
1 --> 5 min distance 23

path: 1 --> 2 --> 4 --> 5

*/

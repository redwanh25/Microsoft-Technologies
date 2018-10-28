using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class StronglyConnectedComponent
    {
        private int vertex, edge;
        private List<int>[] adj;
        private List<int>[] adj_T;
        private Stack<int> stack;
        private bool[] vis;
        private SortedSet<int> set;

        public StronglyConnectedComponent(int index, int vertex, int edge)
        {
            this.vertex = vertex;
            this.edge = edge;
            adj = new List<int>[index];
            adj_T = new List<int>[index];
            for (int i = 0; i < adj.Length; i++)
            {
                adj[i] = new List<int>();
                adj_T[i] = new List<int>();
            }
            stack = new Stack<int>();
            vis = new bool[index];
            set = new SortedSet<int>();
        }

        public void dfs(int u)
        {
            vis[u] = true;
            Console.Write(u + " ");
            for(int i = 0; i < adj_T[u].Count; i++)
            {
                if(vis[adj_T[u][i]] == false)
                {
                    dfs(adj_T[u][i]);
                }
            }
        }

        public void dfsTopological(int u)
        {
            vis[u] = true;
            for (int i = 0; i < adj[u].Count; i++)
            {
                if (vis[adj[u][i]] == false)
                {
                    dfsTopological(adj[u][i]);
                }
            }
            stack.Push(u);
        }

        public void scc()
        {
            int cnt = 0;
            foreach (var it in set)
            {
                if (vis[it] == false)
                {
                    dfsTopological(it);
                }
            }
            vis = vis.Select(i => false).ToArray();

            Console.WriteLine("strongly connected component");
            while (stack.Count != 0)
            {
                int u = stack.Pop();
                if(vis[u] == false)
                {
                    dfs(u);
                    cnt++;
                    Console.WriteLine();
                }
            }
            Console.WriteLine("number of strongly connected component : " + cnt);
        }

        public static void Main(String[] args)
        {
            string[] str = Console.ReadLine().Split();
            int vertex = int.Parse(str[0]);
            int edge = int.Parse(str[1]);
            StronglyConnectedComponent graph = new StronglyConnectedComponent(200, vertex, edge);
            for (int i = 0; i < edge; i++)
            {
                string[] str1 = Console.ReadLine().Split();
                int a = int.Parse(str1[0]);
                int b = int.Parse(str1[1]);
                graph.adj[a].Add(b);
                graph.adj_T[b].Add(a);
                graph.set.Add(a);
                graph.set.Add(b);
            }
            graph.scc();

            Console.WriteLine();
        }
    }
}

/*
9 10
0 1
1 2
2 3
3 0
2 4
4 5
5 6
6 4
7 6
7 8

4 6
0 1
0 2
1 2
2 3
0 3
3 0

*/

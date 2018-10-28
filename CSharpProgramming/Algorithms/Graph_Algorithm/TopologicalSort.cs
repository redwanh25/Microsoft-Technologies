using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class TopologicalSort
    {
        private int vertex, edge;
        private List<int>[] adj;
        private Stack<int> stack;
        private bool[] vis;
        private SortedSet<int> set;

        public TopologicalSort(int index, int vertex, int edge)
        {
            this.vertex = vertex;
            this.edge = edge;
            adj = new List<int>[index];
            for(int i = 0; i < adj.Length; i++)
            {
                adj[i] = new List<int>();
            }
            stack = new Stack<int>();
            vis = new bool[index];
            set = new SortedSet<int>();
        }

        public void dfs(int u)
        {
            vis[u] = true;
            for(int i = 0; i < adj[u].Count; i++)
            {
                if(vis[adj[u][i]] == false)
                {
                    dfs(adj[u][i]);
                }
            }
            stack.Push(u);
        }

        public void topological()
        {
            foreach(var it in set)
            {
                if(vis[it] == false)
                {
                    dfs(it);
                }
            }
        }

        public static void Main(String[] args)
        {
            string[] str = Console.ReadLine().Split();
            int vertex = int.Parse(str[0]);
            int edge = int.Parse(str[1]);
            TopologicalSort graph = new TopologicalSort(200, vertex, edge);
            for(int i = 0; i < edge; i++)
            {
                string[] str1 = Console.ReadLine().Split();
                int a = int.Parse(str1[0]);
                int b = int.Parse(str1[1]);
                graph.adj[a].Add(b);
                graph.set.Add(a);
                graph.set.Add(b);
            }
            graph.topological();

            while(graph.stack.Count != 0)
            {
                Console.Write(graph.stack.Pop() + " --> ");
            }
            Console.WriteLine();
        }

    }
}

/*

8 8
1 3
2 3
2 5
3 4
4 6
4 7
5 7
7 8

7 7
1 3
2 3
3 4
2 5
4 6
5 6
6 7

*/

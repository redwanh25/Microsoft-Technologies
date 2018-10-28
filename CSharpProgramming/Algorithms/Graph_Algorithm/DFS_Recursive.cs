using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class DFS_Recursive
    {
        private List<int>[] adj;
        private bool[] vis;

        public DFS_Recursive(int index)
        {
            adj = new List<int>[index];
            for(int i = 0; i < index; i++)
            {
                adj[i] = new List<int>();
            }
        //    adj = adj.Select(s => new List<int>()).ToArray();

            vis = new bool[index];
        }

        public void dfs(int s)
        {
            vis[s] = true;
            Console.Write(s + " ");
            for(int i = 0; i < adj[s].Count; i++)
            {
                if(vis[adj[s][i]] == false)
                {
                    dfs(adj[s][i]);
                }
            }
        }

        public static void Main(string[] args)
        {
            int edge = int.Parse(Console.ReadLine());
            DFS_Recursive graph = new DFS_Recursive(200);
            for(int i = 0; i < edge; i++)
            {
                string[] str = Console.ReadLine().Split();
                int a = int.Parse(str[0]); int b = int.Parse(str[1]);

                // directed graph
                graph.adj[a].Add(b);
                graph.adj[b].Add(a);

                // undirected graph
             //   graph.adj[a].Add(b);
            }
            graph.dfs(1);
            Console.WriteLine();
        }
    }
}

/*
7
1 2
1 5
2 3
2 5
3 4
4 5
4 6

*/

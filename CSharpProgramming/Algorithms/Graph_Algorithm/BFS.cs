using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class BFS
    {
        private List<int>[] adj;
        private bool[] vis;

        public BFS(int index)
        {
            adj = new List<int>[index];
            for (int i = 0; i < index; i++)
            {
                adj[i] = new List<int>();
            }
        //   adj = adj.Select(s => new List<int>()).ToArray();

            vis = new bool[index];      // false
        }

        public void bfs(int s)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(s);
            vis[s] = true;
            while (queue.Count != 0)
            {
                int u = queue.Dequeue();
                Console.Write(u + " ");
                for (int i = 0; i < adj[u].Count; i++)
                {
                    int v = adj[u][i];
                    if (vis[v] == false)
                    {
                        queue.Enqueue(v);
                        vis[v] = true;
                    }
                }
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int edge = int.Parse(Console.ReadLine());
            BFS graph = new BFS(200);
            for(int i = 0; i < edge; i++)
            {
                string[] str = Console.ReadLine().Split();
                int a = int.Parse(str[0]); int b = int.Parse(str[1]);

                // for undirected graph
                graph.adj[a].Add(b);
                graph.adj[b].Add(a);

                // for directed graph
                // graph.adj[a].Add(b);
            }
            graph.bfs(1);
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

1 2 5 3 4 6

*/

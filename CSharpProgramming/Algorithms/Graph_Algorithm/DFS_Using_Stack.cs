using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class DFS_Using_Stack
    {
        private int edge;
        private List<int>[] adj;
        private Stack<int> stack;
        private bool[] vis;
        private int[] eg;

        public DFS_Using_Stack(int index, int edge)
        {
            this.edge = edge;
            adj = new List<int>[index];
            for(int i = 0; i < index; i++)
            {
                adj[i] = new List<int>();
            }
            stack = new Stack<int>();
            vis = new bool[index];
            eg = new int[index];
        }

        public void dfs(int src)
        {
            stack.Push(src);
            vis[src] = true;
            Console.Write(src + " ");
            while (stack.Count != 0)
            {
                int u = stack.Pop();
                while(eg[u] < adj[u].Count)
                {
                    int v = adj[u][eg[u]];
                    eg[u]++;
                    if(vis[v] == false)
                    {
                        vis[v] = true;
                        stack.Push(u); stack.Push(v);
                        Console.Write(v + " ");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int edge = int.Parse(Console.ReadLine());
            DFS_Using_Stack graph = new DFS_Using_Stack(200, edge);
            for (int i = 0; i < edge; i++)
            {
                string[] str = Console.ReadLine().Split();
                int a = int.Parse(str[0]); int b = int.Parse(str[1]);

                // directed graph
                graph.adj[a].Add(b);
                graph.adj[b].Add(a);

                // undirected graph
                //graph.adj[a].Add(b);
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

1 2 3 4 5 6

*/

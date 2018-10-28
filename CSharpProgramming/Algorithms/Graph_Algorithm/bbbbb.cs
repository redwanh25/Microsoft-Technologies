using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class bbbbb
    {
        private List<int>[] adj;
        private bool[] vis;

        public bbbbb(int index)
        {
            adj = new List<int>[index];
            adj = adj.Select(i => new List<int>()).ToArray();
            vis = new bool[index];
        }

        public void bfs(int src)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(src);
            vis[src] = true;
            while (queue.Count != 0)
            {
                int u = queue.Dequeue();
                Console.Write(u + " ");
                IEnumerator<int> it = adj[u].GetEnumerator();
                while (it.MoveNext())
                {
                    if(vis[it.Current] == false)
                    {
                        queue.Enqueue(it.Current);
                        vis[it.Current] = true;
                    }
                }
            }
        }

        public static void Main(String[] args)
        {
            int edge = int.Parse(Console.ReadLine());
            bbbbb bb = new bbbbb(200);
            for(int i = 0; i < edge; i++)
            {
                string[] str = Console.ReadLine().Split();
                int u = int.Parse(str[0]);
                int v = int.Parse(str[1]);
                bb.adj[u].Add(v);
                bb.adj[v].Add(u);
            }
            bb.bfs(1);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class MST_Kruskal
    {
        private int vertex, edge;
        private List<Tuple<int, int, int>> adj;
        private int[] node;
        
        public MST_Kruskal(int vertex, int edge)
        {
            this.vertex = vertex;
            this.edge = edge;
            adj = new List<Tuple<int, int, int>>();
            node = new int[200];
        }

        public int Find(int z)
        {
            if(node[z] == 0)
            {
                return z;
            }
            return Find(node[z]);
        }
        public void Union(int a, int b)
        {
            int x = Find(a);
            int y = Find(b);
            node[x] = y;
        }

        public void kruskal()
        {
            adj.Sort();
            int ver = 0, eg = 0, sum = 0;
            while (ver < vertex - 1 || eg <  edge)
            {
                int wt = adj[eg].Item1;
                int a = adj[eg].Item2;
                int b = adj[eg].Item3;
                if(Find(a) != Find(b))
                {
                    Union(a, b);
                    sum += wt;
                    ver++;
                    Console.WriteLine(a + " --> " + b);
                }
                eg++;
            }
            Console.WriteLine("Minimum Cost = {0}", sum);
        }

        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int vertex = int.Parse(str[0]);
            int edge = int.Parse(str[1]);
            MST_Kruskal graph = new MST_Kruskal(vertex, edge);
            for (int i = 0; i < edge; i++)
            {
                string[] str1 = Console.ReadLine().Split();
                int a = int.Parse(str1[0]);
                int b = int.Parse(str1[1]);
                int wt = int.Parse(str1[2]);
                graph.adj.Add(Tuple.Create(wt, a, b));
            //    graph.adj.Add(Tuple.Create(wt, b, a));        // no need
            }
            Console.WriteLine();
            graph.kruskal();
        }
    }
}

/*

6 8
1 4 1
2 4 2
2 5 -2
2 6 4
3 5 3
3 6 1
4 5 3
5 6 5

2 --> 5
1 --> 4
3 --> 6
2 --> 4
3 --> 5
Minimum Cost = 5

5 7
1 2 10
1 3 20
2 4 5
2 3 30
4 3 15
4 5 8
3 5 6

2 --> 4
3 --> 5
4 --> 5
1 --> 2
Minimum Cost = 29

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph_Algorithm
{
    class MST_Prims
    {
        private int vertex;
        private bool[] vis;
        private List<Tuple<int, int>>[] adj;

        public MST_Prims(int index, int vertex)
        {
            this.vertex = vertex;
            adj = new List<Tuple<int, int>>[index];
            for(int i = 0; i < index; i++)
            {
                adj[i] = new List<Tuple<int, int>>();
            }
            vis = new bool[index];
        }

        public void prims(int s)
        {
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            int n = 0, sum = 0;
            Console.Write(s);
            while(n++ < vertex - 1)
            {
                vis[s] = true;
                for(int i = 0; i < adj[s].Count; i++)
                {
                    list.Add(adj[s][i]);
                }
                list.Sort();
                while (vis[list.First().Item2] == true)
                {
                    list.RemoveAt(0);
                }
                s = list.First().Item2;
                sum += list.First().Item1;
                list.RemoveAt(0);
                Console.Write(" --> " + s);
            }
            Console.WriteLine("\nMin cost {0}", sum);

        }

        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int vertex, edge;
            vertex = int.Parse(str[0]);
            edge = int.Parse(str[1]);
            MST_Prims graph = new MST_Prims(200, vertex);
            for(int i = 0; i < edge; i++)
            {
                string[] str1 = Console.ReadLine().Split();
                int a = int.Parse(str1[0]);
                int b = int.Parse(str1[1]);
                int wt = int.Parse(str1[2]);
                graph.adj[a].Add(Tuple.Create(wt, b));
                graph.adj[b].Add(Tuple.Create(wt, a));
            }
            graph.prims(1);
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

1 --> 4 --> 2 --> 5 --> 3 --> 6
Minimum cost: 5

5 7
1 2 10
1 3 20
2 4 5
2 3 30
4 3 15
4 5 8
3 5 6

1 --> 2 --> 4 --> 5 --> 3
Minimum cost: 29

3 3
1 2 5
2 3 5
1 3 9
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Program
    {
        private const int LengthMax = 100000; // 棍子的长度限制
        private const int Count = 100; //数组的个数

        static void Main(string[] args)
        {
            var rand = new Random();
            List<int> edges = new List<int>(Count);
            for (int i = 0; i < Count; i++)
            {
                edges.Add(rand.Next(1, LengthMax));
            }

            Solve(edges);
        }

        private static void Solve(List<int> edges)
        {
            int maxLength = 0;
            for (int i = 0; i < edges.Count; i++)
                for (int j = i + 1; j < edges.Count; j++)
                    for (int k = j + 1; k < edges.Count; k++)
                    {
                        int a = edges[i];
                        int b = edges[j];
                        int c = edges[k];

                        if (a + b > c && b + c > a && a + c > b)
                        {
                            maxLength = Math.Max(maxLength, a + b + b);
                        }
                    }
            Console.WriteLine(maxLength);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class dfs2
    {
        const int M = 10;
        const int N = 20;

        char[,] fileds = new char[M, N];

        public void Printf()
        {
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < N; j++)
                {
                    Console.Write(fileds[i, j]);
                }
            }
        }

        public void RandomWater()
        {
            var rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    char word;
                    word = rand.Next(0, 10) < 5 ? '.' : 'w';
                    fileds[i, j] = word;
                }
            }
        }

        public void dfs(int x, int y)
        {
            fileds[x, y] = '.';

            for (int dx = -1; dx <= 1; dx++)
                for (int dy = -1; dy <= 1; dy++)
                {
                    int ax = x + dx;
                    int ay = y + dy;

                    if (ax >= 0 && ax < M
                      && ay >= 0 && ay < N
                      && fileds[ax, ay] == 'w')
                    {
                        dfs(ax, ay);
                    }

                }
        }

        public void CountWater()
        {
            int r = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (fileds[i, j] == 'w')
                    {
                        Console.WriteLine("--------------------Count--------------");
                        r++;
                        dfs(i, j);
                        Printf();
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("CountWater: " + r);
        }

    }

}

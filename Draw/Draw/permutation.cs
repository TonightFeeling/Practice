using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class permutation
    {
        private const int N = 2;

        bool[] used = new bool[N];
        int[] perm = new int[N];

        public void Perm(int pos, int n)
        {
            if (pos == n)
            {
                Console.WriteLine("P == N :");
            }

            for (int i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    perm[pos] = i;
                    used[i] = true;
                    Console.WriteLine("i == " + i);
                    Perm(pos + 1, n);
                    Console.WriteLine("i ---" + i);
                    used[i] = false;
                }
            }
            return;
        }

        public void Init()
        {
            for (int i = 0; i < N; i++)
            {
                used[i] = false;
            }

            for (int i = 0; i < N; i++)
            {
                perm[i] = -1;
            }
        }

    }
}

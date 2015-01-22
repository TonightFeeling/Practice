using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Sanuman_sArmy
    {

        public int R = 10;

        public List<int> X = new List<int> { 1, 7, 15, 20, 30, 50 };

        public void Solve()
        {
            List<int> marked = new List<int>();
            int i = 0;
            while (i < X.Count)
            {
                int s = X[i++]; // 没被覆盖的最左边的点

                while (i < X.Count && X[i] <= s + R) i++;

                int p = X[i - 1]; // 标记点
                marked.Add(p);

                while (i < X.Count && X[i] <= p + R) i++;
            }

            if (marked.Count == 0)
            {
                marked.Add(X[0]);
            }

            foreach (var item in marked)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }


    }
}

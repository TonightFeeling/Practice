using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Ants
    {
        protected enum Directions
        {
            Left,
            Right
        };

        private const int L = 1000000; // 杆的长度

        public static void Solve(int l, List<int> ants)
        {
            //最短时间是所有蚂蚁都超最近的断点走去，这样不会发生蚂蚁相遇的情况
            int minTime = 0;
            foreach (var ant in ants)
            {
                minTime += Math.Max(minTime, Math.Min(ant, l - ant));
            }

            int maxTime = 0;
            foreach (var ant in ants)
            {
                maxTime += Math.Max(maxTime, Math.Max(ant, l - ant));
            }

        }

    }

}

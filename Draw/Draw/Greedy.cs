using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Greedy
    {
        List<int> C = new List<int>() { 3, 2, 1, 3, 0, 2 };
        List<int> A = new List<int>() { 1, 5, 10, 50, 100, 500 };
        public void Solve(int v)
        {
           for(int i = 5; i >=0; i--)
            {
                int t = Math.Min(v / A[i], C[i]);
                v -= t * A[i];
                Console.WriteLine(A[i] + "   yuan : " + t);
            }     


        }



    }
}

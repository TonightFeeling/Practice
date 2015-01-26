using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class FenceRepair
    {

        List<int> L = new List<int>() { 8, 5, 8 };

        public void Solve()
        {
            long sum = 0;
            while(L.Count > 1)
            {
                var firstMin =  L.Min();
                L.Remove(firstMin);
                sum += firstMin;
                
                var secondMin = L.Min();
                L.Remove(secondMin);
                sum += secondMin;

                L.Add(firstMin + secondMin);
            }

            Console.WriteLine("Minest Cost :" + " " + sum);

        }






    }
}

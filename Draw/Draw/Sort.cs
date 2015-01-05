using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    public static class Sort
    {
        public static int ExBinarySearch(this List<int> list, int target)
        {
            Contract.Requires(list != null);

            if (list.Count == 0)
                return -1;

            int l = 0;
            int h = list.Count - 1;
            int mid;
            while (l <= h)
            {
                mid = GetMedian(l, h);
                int obj = list[mid];
                if (obj == target)
                {
                    return mid;
                }
                else if (obj < target)
                {
                    l = mid + 1;
                }
                else if (obj > target)
                {
                    h = mid - 1;
                }
            }
            return -1;
        }

        public static int GetMedian(int low, int hi)
        {
            Contract.Requires(low <= hi);
            Contract.Assert(hi - low >= 0, "Length overflow");
            return low + ((hi - low) >> 1);
        }


    }
}

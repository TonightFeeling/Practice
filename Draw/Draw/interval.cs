using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class interval
    {

        List<int> St = new List<int> { 1, 2, 4, 6, 8 };
        List<int> Et = new List<int> { 3, 5, 7, 9, 10 };

        public void solve()
        {
            List<int> selected = new List<int>();
            List<int> conflicts = new List<int>();

            while (true)
            {
                int j = GetNext(selected, conflicts);
                if (j != -1)
                {
                    selected.Add(j);

                    conflicts.AddRange(CheckedConflict(j));

                    Console.WriteLine("selected: " + (j + 1));
                }
                else
                {
                    break;
                }
            }

        }

        private List<int> CheckedConflict(int selected)
        {
            List<int> j = new List<int>();

            for (int i = 0; i < St.Count; i++)
            {
                if (!(St[i] > Et[selected] || Et[i] < St[selected]))
                {
                    j.Add(i);
                }
            }
            return j;
        }

        private int GetNext(List<int> selected, List<int> conflicts)
        {
            List<int> candidate = new List<int>();
            for (int i = 0; i < St.Count; i++)
            {
                if (selected.Exists(a => a == i) || conflicts.Exists(b => b == i))
                    continue;

                candidate.Add(i);
            }

            if (candidate.Count == 0)
            {
                return -1;
            }
            else
            {
                int index = candidate[0];
                int value = Et[index];
                for (int i = 0; i < candidate.Count; i++)
                {
                    if (Et[candidate[i]] < value)
                    {
                        value = Et[candidate[i]];
                        index = candidate[i];
                    }
                }
                return index;
            }

        }

        public void BookSolve()
        {
            List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
            for (int i = 0; i < St.Count; i++)
            {
                pairs.Add(new Tuple<int, int>(St[i], Et[i]));
            }

            pairs.Sort((a, b) => a.Item2.CompareTo(b.Item2));

            int t = 0; // 最后一个已选工作的结束时间
            for (int i = 0; i < pairs.Count; i++)
            {
                if (t < pairs[i].Item1)
                {
                    t = pairs[i].Item2;
                    Console.WriteLine("S :" + pairs[i].Item1 + " T: " + pairs[i].Item2);
                }
            }


        }


    }
}
